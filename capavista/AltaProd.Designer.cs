namespace capavista
{
    partial class AltaProd
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kioscoDataSet = new capavista.KioscoDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtminimo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBarra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCostos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PanelP = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tipoProductoTableAdapter = new capavista.KioscoDataSetTableAdapters.tipoProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kioscoDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelP.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de producto";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdescripcion.Location = new System.Drawing.Point(156, 209);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(185, 20);
            this.txtdescripcion.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.tipoProductoBindingSource;
            this.comboBox1.DisplayMember = "codTipop";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "codTipop";
            // 
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataMember = "tipoProducto";
            this.tipoProductoBindingSource.DataSource = this.kioscoDataSet;
            // 
            // kioscoDataSet
            // 
            this.kioscoDataSet.DataSetName = "KioscoDataSet";
            this.kioscoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock:";
            // 
            // txtstock
            // 
            this.txtstock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtstock.Location = new System.Drawing.Point(156, 252);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(185, 20);
            this.txtstock.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(156, 417);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 376);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtprecio.Location = new System.Drawing.Point(156, 334);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(185, 20);
            this.txtprecio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Stock Mínimo:";
            // 
            // txtminimo
            // 
            this.txtminimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtminimo.Location = new System.Drawing.Point(156, 291);
            this.txtminimo.Name = "txtminimo";
            this.txtminimo.Size = new System.Drawing.Size(185, 20);
            this.txtminimo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha de vencimiento:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fecha de entrada:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(53, 514);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(294, 65);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(49, 47);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(298, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ingresar producto al sistema";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.txtBarra);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtCostos);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtdescripcion);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtstock);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtprecio);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtminimo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 612);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // txtBarra
            // 
            this.txtBarra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarra.Location = new System.Drawing.Point(156, 127);
            this.txtBarra.Name = "txtBarra";
            this.txtBarra.Size = new System.Drawing.Size(185, 20);
            this.txtBarra.TabIndex = 0;
            this.txtBarra.TextChanged += new System.EventHandler(this.txtBarra_TextChanged);
            this.txtBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarra_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Código de barras:";
            // 
            // txtCostos
            // 
            this.txtCostos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCostos.Location = new System.Drawing.Point(156, 458);
            this.txtCostos.Name = "txtCostos";
            this.txtCostos.Size = new System.Drawing.Size(185, 20);
            this.txtCostos.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Costos:";
            // 
            // PanelP
            // 
            this.PanelP.Controls.Add(this.panel3);
            this.PanelP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelP.Location = new System.Drawing.Point(0, 0);
            this.PanelP.Name = "PanelP";
            this.PanelP.Size = new System.Drawing.Size(1080, 612);
            this.PanelP.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 612);
            this.panel3.TabIndex = 42;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(467, 47);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(210, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Productos cargados";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(23, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(654, 453);
            this.dataGridView1.TabIndex = 37;
            // 
            // tipoProductoTableAdapter
            // 
            this.tipoProductoTableAdapter.ClearBeforeFill = true;
            // 
            // AltaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaProd";
            this.Text = "AltaProd";
            this.Load += new System.EventHandler(this.AltaProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kioscoDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelP.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtminimo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private KioscoDataSet kioscoDataSet;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private KioscoDataSetTableAdapters.tipoProductoTableAdapter tipoProductoTableAdapter;
        private System.Windows.Forms.TextBox txtCostos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBarra;
        private System.Windows.Forms.Label label11;
    }
}