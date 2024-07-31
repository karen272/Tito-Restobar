namespace TitosRestobarPorPartes
{
    partial class ProductosVista
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
            listProducto = new ListBox();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPrecioProducto = new TextBox();
            txtCostoProducto = new TextBox();
            txtDescripcionProducto = new TextBox();
            txtNombreProducto = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnStock = new Button();
            label7 = new Label();
            lblIdProducto = new Label();
            SuspendLayout();
            // 
            // listProducto
            // 
            listProducto.FormattingEnabled = true;
            listProducto.ItemHeight = 20;
            listProducto.Location = new Point(12, 59);
            listProducto.Name = "listProducto";
            listProducto.Size = new Size(290, 344);
            listProducto.TabIndex = 0;
            listProducto.SelectedIndexChanged += listProducto_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(514, 261);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 39);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 208);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Precio: \r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 142);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 3;
            label2.Text = "Descripción: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(453, 109);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(453, 40);
            label4.Name = "label4";
            label4.Size = new Size(278, 31);
            label4.TabIndex = 5;
            label4.Text = "Cargar productos Nuevos";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(453, 175);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 6;
            label5.Text = "Costo:";
            label5.Click += label5_Click;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(580, 201);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(125, 27);
            txtPrecioProducto.TabIndex = 7;
            // 
            // txtCostoProducto
            // 
            txtCostoProducto.Location = new Point(580, 168);
            txtCostoProducto.Name = "txtCostoProducto";
            txtCostoProducto.Size = new Size(125, 27);
            txtCostoProducto.TabIndex = 8;
            // 
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.Location = new Point(580, 135);
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Size = new Size(125, 27);
            txtDescripcionProducto.TabIndex = 9;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(580, 102);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(125, 27);
            txtNombreProducto.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 18);
            label6.Name = "label6";
            label6.Size = new Size(228, 31);
            label6.TabIndex = 12;
            label6.Text = "Productos Cargados";
            // 
            // button1
            // 
            button1.Location = new Point(37, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(146, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 15;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(620, 409);
            button4.Name = "button4";
            button4.Size = new Size(168, 29);
            button4.TabIndex = 16;
            button4.Text = "Volver al Menu Principal";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(408, 409);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(168, 29);
            btnStock.TabIndex = 17;
            btnStock.Text = "Controlar Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(453, 71);
            label7.Name = "label7";
            label7.Size = new Size(27, 20);
            label7.TabIndex = 18;
            label7.Text = "ID:";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(486, 71);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(0, 20);
            lblIdProducto.TabIndex = 19;
            // 
            // ProductosVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIdProducto);
            Controls.Add(label7);
            Controls.Add(btnStock);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtDescripcionProducto);
            Controls.Add(txtCostoProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(listProducto);
            Name = "ProductosVista";
            Text = "Form1";
            Load += ProductosVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listProducto;
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPrecioProducto;
        private TextBox txtCostoProducto;
        private TextBox txtDescripcionProducto;
        private TextBox txtNombreProducto;
        private Label label6;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button btnStock;
        private Label label7;
        private Label lblIdProducto;
    }
}