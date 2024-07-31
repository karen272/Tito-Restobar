namespace TitosRestobarPorPartes.Vistas
{
    partial class InicioVistas
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
            btnIrAProductos = new Button();
            btnIrAMesas = new Button();
            SuspendLayout();
            // 
            // btnIrAProductos
            // 
            btnIrAProductos.Location = new Point(104, 165);
            btnIrAProductos.Name = "btnIrAProductos";
            btnIrAProductos.Size = new Size(159, 63);
            btnIrAProductos.TabIndex = 0;
            btnIrAProductos.Text = "Productos";
            btnIrAProductos.UseVisualStyleBackColor = true;
            btnIrAProductos.Click += btnIrAProductos_Click;
            // 
            // btnIrAMesas
            // 
            btnIrAMesas.Location = new Point(495, 165);
            btnIrAMesas.Name = "btnIrAMesas";
            btnIrAMesas.Size = new Size(159, 63);
            btnIrAMesas.TabIndex = 1;
            btnIrAMesas.Text = "Mesas";
            btnIrAMesas.UseVisualStyleBackColor = true;
            btnIrAMesas.Click += btnIrAMesas_Click;
            // 
            // InicioVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIrAMesas);
            Controls.Add(btnIrAProductos);
            Name = "InicioVistas";
            Text = "InicioVistas";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIrAProductos;
        private Button btnIrAMesas;
    }
}