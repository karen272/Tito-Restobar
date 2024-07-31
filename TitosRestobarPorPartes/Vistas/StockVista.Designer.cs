namespace TitosRestobarPorPartes.Vistas
{
    partial class StockVista
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
            label1 = new Label();
            lblNombreProducto = new Label();
            lblIdProductoStock = new Label();
            label2 = new Label();
            numStock = new NumericUpDown();
            button1 = new Button();
            lblIdStock = new Label();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 0;
            label1.Text = "Producto:";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblNombreProducto.Location = new Point(139, 20);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(0, 31);
            lblNombreProducto.TabIndex = 1;
            // 
            // lblIdProductoStock
            // 
            lblIdProductoStock.AutoSize = true;
            lblIdProductoStock.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblIdProductoStock.Location = new Point(168, 83);
            lblIdProductoStock.Name = "lblIdProductoStock";
            lblIdProductoStock.Size = new Size(0, 31);
            lblIdProductoStock.TabIndex = 2;
            lblIdProductoStock.Click += IdProductoStock_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(114, 83);
            label2.Name = "label2";
            label2.Size = new Size(37, 31);
            label2.TabIndex = 3;
            label2.Text = "Id:";
            // 
            // numStock
            // 
            numStock.Location = new Point(114, 147);
            numStock.Name = "numStock";
            numStock.Size = new Size(82, 27);
            numStock.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(90, 203);
            button1.Name = "button1";
            button1.Size = new Size(133, 28);
            button1.TabIndex = 5;
            button1.Text = "Actualizar Stock";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblIdStock
            // 
            lblIdStock.AutoSize = true;
            lblIdStock.Location = new Point(12, 243);
            lblIdStock.Name = "lblIdStock";
            lblIdStock.Size = new Size(0, 20);
            lblIdStock.TabIndex = 6;
            // 
            // StockVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 272);
            Controls.Add(lblIdStock);
            Controls.Add(button1);
            Controls.Add(numStock);
            Controls.Add(label2);
            Controls.Add(lblIdProductoStock);
            Controls.Add(lblNombreProducto);
            Controls.Add(label1);
            Name = "StockVista";
            Text = "StockVista";
            Load += StockVista_Load;
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombreProducto;
        private Label lblIdProductoStock;
        private Label label2;
        private NumericUpDown numStock;
        private Button button1;
        private Label lblIdStock;
    }
}