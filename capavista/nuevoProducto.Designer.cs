namespace capavista
{
    partial class nuevoProducto
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
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtentrada = new System.Windows.Forms.TextBox();
            this.txtvencimiento = new System.Windows.Forms.TextBox();
            this.combotproducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ultimoadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(197, 140);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(126, 20);
            this.txtdescripcion.TabIndex = 0;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(197, 196);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(126, 20);
            this.txtstock.TabIndex = 1;
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(197, 249);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(126, 20);
            this.txtmin.TabIndex = 2;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(197, 300);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(126, 20);
            this.txtprecio.TabIndex = 3;
            // 
            // txtentrada
            // 
            this.txtentrada.Location = new System.Drawing.Point(197, 352);
            this.txtentrada.Name = "txtentrada";
            this.txtentrada.Size = new System.Drawing.Size(126, 20);
            this.txtentrada.TabIndex = 4;
            // 
            // txtvencimiento
            // 
            this.txtvencimiento.Location = new System.Drawing.Point(197, 404);
            this.txtvencimiento.Name = "txtvencimiento";
            this.txtvencimiento.Size = new System.Drawing.Size(126, 20);
            this.txtvencimiento.TabIndex = 5;
            // 
            // combotproducto
            // 
            this.combotproducto.FormattingEnabled = true;
            this.combotproducto.Location = new System.Drawing.Point(197, 83);
            this.combotproducto.Name = "combotproducto";
            this.combotproducto.Size = new System.Drawing.Size(126, 21);
            this.combotproducto.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo de producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad en stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stock minimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de entrada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de vencimiento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 83);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 61);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ultimoadd});
            this.dataGridView1.Location = new System.Drawing.Point(378, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 284);
            this.dataGridView1.TabIndex = 16;
            // 
            // ultimoadd
            // 
            this.ultimoadd.FillWeight = 150F;
            this.ultimoadd.HeaderText = "Ultimo agregado";
            this.ultimoadd.Name = "ultimoadd";
            this.ultimoadd.ReadOnly = true;
            this.ultimoadd.Width = 200;
            // 
            // nuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combotproducto);
            this.Controls.Add(this.txtvencimiento);
            this.Controls.Add(this.txtentrada);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtdescripcion);
            this.Name = "nuevoProducto";
            this.Text = "nuevoProducto";
            this.Load += new System.EventHandler(this.NuevoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtentrada;
        private System.Windows.Forms.TextBox txtvencimiento;
        private System.Windows.Forms.ComboBox combotproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoadd;
    }
}