namespace TitosRestobarPorPartes.Vistas
{
    partial class ListadoPedidos
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
            listPedidosAntiguos = new ListBox();
            btnSeleccionarPedido = new Button();
            listDetallePedido = new ListBox();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // listPedidosAntiguos
            // 
            listPedidosAntiguos.FormattingEnabled = true;
            listPedidosAntiguos.ItemHeight = 20;
            listPedidosAntiguos.Location = new Point(21, 23);
            listPedidosAntiguos.Name = "listPedidosAntiguos";
            listPedidosAntiguos.Size = new Size(190, 344);
            listPedidosAntiguos.TabIndex = 0;
            // 
            // btnSeleccionarPedido
            // 
            btnSeleccionarPedido.Location = new Point(217, 309);
            btnSeleccionarPedido.Name = "btnSeleccionarPedido";
            btnSeleccionarPedido.Size = new Size(97, 58);
            btnSeleccionarPedido.TabIndex = 1;
            btnSeleccionarPedido.Text = "Seleccionar Pedido";
            btnSeleccionarPedido.UseVisualStyleBackColor = true;
            // 
            // listDetallePedido
            // 
            listDetallePedido.FormattingEnabled = true;
            listDetallePedido.ItemHeight = 20;
            listDetallePedido.Location = new Point(412, 23);
            listDetallePedido.Name = "listDetallePedido";
            listDetallePedido.Size = new Size(353, 304);
            listDetallePedido.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(649, 393);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(139, 45);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver al inicio";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // ListadoPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(listDetallePedido);
            Controls.Add(btnSeleccionarPedido);
            Controls.Add(listPedidosAntiguos);
            Name = "ListadoPedidos";
            Text = "ListadoPedidos";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listPedidosAntiguos;
        private Button btnSeleccionarPedido;
        private ListBox listDetallePedido;
        private Button btnVolver;
    }
}