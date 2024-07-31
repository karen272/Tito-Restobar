namespace TitosRestobarPorPartes.Vistas
{
    partial class MesasVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPedidosMesa = new Button();
            listMesa = new ListBox();
            btnVolver = new Button();
            txtMesa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCrearMesa = new Button();
            btnEditarMesa = new Button();
            btnEliminarMesa = new Button();
            lblIdMesa = new Label();
            SuspendLayout();
            // 
            // btnPedidosMesa
            // 
            btnPedidosMesa.Location = new Point(59, 316);
            btnPedidosMesa.Name = "btnPedidosMesa";
            btnPedidosMesa.Size = new Size(153, 42);
            btnPedidosMesa.TabIndex = 0;
            btnPedidosMesa.Text = "Ingresar a la Mesa";
            btnPedidosMesa.UseVisualStyleBackColor = true;
            btnPedidosMesa.Click += btnPedidosMesa_Click;
            // 
            // listMesa
            // 
            listMesa.FormattingEnabled = true;
            listMesa.ItemHeight = 20;
            listMesa.Location = new Point(30, 35);
            listMesa.Name = "listMesa";
            listMesa.Size = new Size(222, 264);
            listMesa.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(590, 369);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(181, 49);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtMesa
            // 
            txtMesa.Location = new Point(396, 96);
            txtMesa.Name = "txtMesa";
            txtMesa.Size = new Size(125, 27);
            txtMesa.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 96);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 48);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 5;
            label2.Text = "Mesa";
            // 
            // btnCrearMesa
            // 
            btnCrearMesa.Location = new Point(317, 152);
            btnCrearMesa.Name = "btnCrearMesa";
            btnCrearMesa.Size = new Size(104, 29);
            btnCrearMesa.TabIndex = 6;
            btnCrearMesa.Text = "Crear Mesa";
            btnCrearMesa.UseVisualStyleBackColor = true;
            btnCrearMesa.Click += btnCrearMesa_Click;
            // 
            // btnEditarMesa
            // 
            btnEditarMesa.Location = new Point(427, 152);
            btnEditarMesa.Name = "btnEditarMesa";
            btnEditarMesa.Size = new Size(104, 29);
            btnEditarMesa.TabIndex = 7;
            btnEditarMesa.Text = "Editar Mesa";
            btnEditarMesa.UseVisualStyleBackColor = true;
            btnEditarMesa.Click += btnEditarMesa_Click;
            // 
            // btnEliminarMesa
            // 
            btnEliminarMesa.Location = new Point(370, 203);
            btnEliminarMesa.Name = "btnEliminarMesa";
            btnEliminarMesa.Size = new Size(111, 26);
            btnEliminarMesa.TabIndex = 8;
            btnEliminarMesa.Text = "Eliminar Mesa";
            btnEliminarMesa.UseVisualStyleBackColor = true;
            btnEliminarMesa.Click += btnEliminarMesa_Click;
            // 
            // lblIdMesa
            // 
            lblIdMesa.AutoSize = true;
            lblIdMesa.Location = new Point(446, 48);
            lblIdMesa.Name = "lblIdMesa";
            lblIdMesa.Size = new Size(0, 20);
            lblIdMesa.TabIndex = 9;
            lblIdMesa.Click += lblIdMesa_Click;
            // 
            // MesasVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIdMesa);
            Controls.Add(btnEliminarMesa);
            Controls.Add(btnEditarMesa);
            Controls.Add(btnCrearMesa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMesa);
            Controls.Add(btnVolver);
            Controls.Add(listMesa);
            Controls.Add(btnPedidosMesa);
            Name = "MesasVista";
            Text = "Mesas";
            Load += MesasVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPedidosMesa;
        private ListBox listMesa;
        private Button btnVolver;
        private TextBox txtMesa;
        private Label label1;
        private Label label2;
        private Button btnCrearMesa;
        private Button btnEditarMesa;
        private Button btnEliminarMesa;
        private Label lblIdMesa;
    }
}