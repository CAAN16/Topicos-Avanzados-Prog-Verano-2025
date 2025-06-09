#include "Names.h"

using namespace System;
using namespace System::Windows::Forms;

[STAThread]
void Main(array<String^>^ arg)
{
    Application::EnableVisualStyles();
    Application::SetCompatibleTextRenderingDefault(false);
    Application::Run(gcnew NamesCMasMas::Names());
}

