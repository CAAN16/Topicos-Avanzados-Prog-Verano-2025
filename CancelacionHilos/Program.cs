using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // 1. Crear fuente de token
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;

        // 2. Iniciar hilo que escucha con sondeo
        ThreadPool.QueueUserWorkItem(DoSomeWork, token);

        // 3. Registrar objetos que reaccionan cuando se cancele
        var obj1 = new CancelableObject("Objeto 1");
        var obj2 = new CancelableObject("Objeto 2");
        token.Register(() => obj1.Cancel());
        token.Register(() => obj2.Cancel());

        // 4. Simular trabajo principal
        Thread.Sleep(2000);

        // 5. Solicitar cancelación
        Console.WriteLine("\n>> Solicitando cancelación...\n");
        cts.Cancel();

        // 6. Probar cancelación con excepción lanzada
        try
        {
            DoCancellableWithException(token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine(">> Se lanzó OperationCanceledException correctamente.\n");
        }

        // 7. Esperar para mostrar salidas
        Thread.Sleep(2000);
        cts.Dispose();
    }

    // Método de trabajo que usa sondeo
    static void DoSomeWork(object? obj)
    {
        if (obj is not CancellationToken token) return;

        for (int i = 0; i < 100000; i++)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine($">> Hilo detectó cancelación en iteración {i}.");
                break;
            }

            Thread.SpinWait(500000);
        }
    }

    // Clase personalizada que reacciona a la cancelación
    class CancelableObject
    {
        private readonly string _id;

        public CancelableObject(string id)
        {
            _id = id;
        }

        public void Cancel()
        {
            Console.WriteLine($"--> [{_id}] recibió notificación de cancelación.");
        }
    }

    // Método que lanza una excepción si se solicita cancelación
    static void DoCancellableWithException(CancellationToken token)
    {
        Console.WriteLine(">> Verificando cancelación con excepción...");

        // Esto lanza inmediatamente la excepción si la cancelación fue solicitada.
        token.ThrowIfCancellationRequested();
    }
}
