using TitosRestobarPorPartes.Modelo;

namespace TitosRestobarPorPartes.Vistas
{
    partial class PedidosVista
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
            listPedidos = new ListBox();
            cmbProductos = new ComboBox();
            btnAgregarProducto = new Button();
            lblProducto = new Label();
            lblCantidad = new Label();
            numUDCantidad = new NumericUpDown();
            btnCerrarPedido = new Button();
            label1 = new Label();
            btnAbrirPedido = new Button();
            btnListarPedido = new Button();
            btnVolver = new Button();
            button1 = new Button();
            button2 = new Button();
            lblIdMesaSeleccionada = new Label();
            lblIdPedido = new Label();
            ((System.ComponentModel.ISupportInitialize)numUDCantidad).BeginInit();
            SuspendLayout();
            // 
            // listPedidos
            // 
            listPedidos.FormattingEnabled = true;
            listPedidos.ItemHeight = 20;
            listPedidos.Location = new Point(43, 36);
            listPedidos.Name = "listPedidos";
            listPedidos.Size = new Size(243, 304);
            listPedidos.TabIndex = 0;
            listPedidos.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(394, 92);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(151, 28);
            cmbProductos.TabIndex = 1;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(319, 186);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(94, 29);
            btnAgregarProducto.TabIndex = 2;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(319, 95);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(72, 20);
            lblProducto.TabIndex = 4;
            lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(319, 140);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad:";
            // 
            // numUDCantidad
            // 
            numUDCantidad.Location = new Point(397, 138);
            numUDCantidad.Name = "numUDCantidad";
            numUDCantidad.Size = new Size(46, 27);
            numUDCantidad.TabIndex = 6;
            numUDCantidad.ValueChanged += numUDCantidad_ValueChanged;
            // 
            // btnCerrarPedido
            // 
            btnCerrarPedido.Location = new Point(311, 288);
            btnCerrarPedido.Name = "btnCerrarPedido";
            btnCerrarPedido.Size = new Size(191, 40);
            btnCerrarPedido.TabIndex = 7;
            btnCerrarPedido.Text = "Cerrar Pedido";
            btnCerrarPedido.UseVisualStyleBackColor = true;
            btnCerrarPedido.Click += btnCerrarPedido_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 373);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 8;
            label1.Text = "Total:    $";
            // 
            // btnAbrirPedido
            // 
            btnAbrirPedido.Location = new Point(319, 27);
            btnAbrirPedido.Name = "btnAbrirPedido";
            btnAbrirPedido.Size = new Size(191, 40);
            btnAbrirPedido.TabIndex = 9;
            btnAbrirPedido.Text = "Abrir Pedido";
            btnAbrirPedido.UseVisualStyleBackColor = true;
            btnAbrirPedido.Click += btnAbrirPedido_Click;
            // 
            // btnListarPedido
            // 
            btnListarPedido.Location = new Point(619, 373);
            btnListarPedido.Name = "btnListarPedido";
            btnListarPedido.Size = new Size(146, 47);
            btnListarPedido.TabIndex = 10;
            btnListarPedido.Text = "Listar Pedidos";
            btnListarPedido.UseVisualStyleBackColor = true;
            btnListarPedido.Click += btnListarPedido_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(619, 332);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(146, 35);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // button1
            // 
            button1.Location = new Point(364, 221);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(419, 186);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblIdMesaSeleccionada
            // 
            lblIdMesaSeleccionada.AutoSize = true;
            lblIdMesaSeleccionada.Location = new Point(43, 9);
            lblIdMesaSeleccionada.Name = "lblIdMesaSeleccionada";
            lblIdMesaSeleccionada.Size = new Size(0, 20);
            lblIdMesaSeleccionada.TabIndex = 14;
            // 
            // lblIdPedido
            // 
            lblIdPedido.AutoSize = true;
            lblIdPedido.Location = new Point(341, 386);
            lblIdPedido.Name = "lblIdPedido";
            lblIdPedido.Size = new Size(0, 20);
            lblIdPedido.TabIndex = 15;
            // 
            // PedidosVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIdPedido);
            Controls.Add(lblIdMesaSeleccionada);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnVolver);
            Controls.Add(btnListarPedido);
            Controls.Add(btnAbrirPedido);
            Controls.Add(label1);
            Controls.Add(btnCerrarPedido);
            Controls.Add(numUDCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(cmbProductos);
            Controls.Add(listPedidos);
            Name = "PedidosVista";
            Text = "Pedidos";
            Load += PedidosVista_Load;
            ((System.ComponentModel.ISupportInitialize)numUDCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listPedidos;
        private ComboBox cmbProductos;
        private Button btnAgregarProducto;
        private Label lblProducto;
        private Label lblCantidad;
        private NumericUpDown numUDCantidad;
        private Button btnCerrarPedido;
        private Label label1;
        private Button btnAbrirPedido;
        private Button btnListarPedido;
        private Button btnVolver;
        private Button button1;
        private Button button2;
        private Label lblIdMesaSeleccionada;
        private Label lblIdPedido;
    }
}