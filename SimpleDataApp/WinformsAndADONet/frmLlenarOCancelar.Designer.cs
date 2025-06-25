namespace WinformsAndADONet
{
    partial class frmLlenarOCancelar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtOrderID = new TextBox();
            label2 = new Label();
            btnFindByOrderID = new Button();
            label1 = new Label();
            dtpFillDate = new DateTimePicker();
            dgvCustomerOrders = new DataGridView();
            btnCancelOrder = new Button();
            btnFillOrder = new Button();
            btnFinishUpdates = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).BeginInit();
            SuspendLayout();
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(195, 16);
            txtOrderID.Margin = new Padding(3, 2, 3, 2);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(173, 23);
            txtOrderID.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 22);
            label2.Name = "label2";
            label2.Size = new Size(153, 19);
            label2.TabIndex = 4;
            label2.Text = "Identificador de pedido:";
            // 
            // btnFindByOrderID
            // 
            btnFindByOrderID.Location = new Point(401, 17);
            btnFindByOrderID.Margin = new Padding(3, 2, 3, 2);
            btnFindByOrderID.Name = "btnFindByOrderID";
            btnFindByOrderID.Size = new Size(124, 22);
            btnFindByOrderID.TabIndex = 6;
            btnFindByOrderID.Text = "Buscar pedido";
            btnFindByOrderID.UseVisualStyleBackColor = true;
            btnFindByOrderID.Click += btnFindByOrderID_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 64);
            label1.Name = "label1";
            label1.Size = new Size(298, 40);
            label1.TabIndex = 7;
            label1.Text = "Si está rellando un pedido, especifique la fecha rellenada";
            // 
            // dtpFillDate
            // 
            dtpFillDate.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFillDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFillDate.Format = DateTimePickerFormat.Short;
            dtpFillDate.Location = new Point(341, 64);
            dtpFillDate.Margin = new Padding(3, 2, 3, 2);
            dtpFillDate.Name = "dtpFillDate";
            dtpFillDate.Size = new Size(184, 26);
            dtpFillDate.TabIndex = 8;
            // 
            // dgvCustomerOrders
            // 
            dgvCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerOrders.Location = new Point(19, 106);
            dgvCustomerOrders.Margin = new Padding(3, 2, 3, 2);
            dgvCustomerOrders.Name = "dgvCustomerOrders";
            dgvCustomerOrders.ReadOnly = true;
            dgvCustomerOrders.RowHeadersVisible = false;
            dgvCustomerOrders.RowHeadersWidth = 51;
            dgvCustomerOrders.Size = new Size(506, 141);
            dgvCustomerOrders.TabIndex = 9;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(19, 273);
            btnCancelOrder.Margin = new Padding(3, 2, 3, 2);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(124, 22);
            btnCancelOrder.TabIndex = 10;
            btnCancelOrder.Text = "Cancelar pedido";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // btnFillOrder
            // 
            btnFillOrder.Location = new Point(182, 273);
            btnFillOrder.Margin = new Padding(3, 2, 3, 2);
            btnFillOrder.Name = "btnFillOrder";
            btnFillOrder.Size = new Size(124, 22);
            btnFillOrder.TabIndex = 11;
            btnFillOrder.Text = "Rellenar pedido";
            btnFillOrder.UseVisualStyleBackColor = true;
            btnFillOrder.Click += btnFillOrder_Click;
            // 
            // btnFinishUpdates
            // 
            btnFinishUpdates.Location = new Point(401, 273);
            btnFinishUpdates.Margin = new Padding(3, 2, 3, 2);
            btnFinishUpdates.Name = "btnFinishUpdates";
            btnFinishUpdates.Size = new Size(124, 22);
            btnFinishUpdates.TabIndex = 12;
            btnFinishUpdates.Text = "Finalizar";
            btnFinishUpdates.UseVisualStyleBackColor = true;
            btnFinishUpdates.Click += btnFinishUpdates_Click;
            // 
            // frmLlenarOCancelar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 311);
            Controls.Add(btnFinishUpdates);
            Controls.Add(btnFillOrder);
            Controls.Add(btnCancelOrder);
            Controls.Add(dgvCustomerOrders);
            Controls.Add(dtpFillDate);
            Controls.Add(label1);
            Controls.Add(btnFindByOrderID);
            Controls.Add(txtOrderID);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLlenarOCancelar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rellenar o cancelar un pedido";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOrderID;
        private Label label2;
        private Button btnFindByOrderID;
        private Label label1;
        private DateTimePicker dtpFillDate;
        private DataGridView dgvCustomerOrders;
        private Button btnCancelOrder;
        private Button btnFillOrder;
        private Button btnFinishUpdates;
    }
}
