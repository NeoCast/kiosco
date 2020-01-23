namespace capavista
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMint = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelsubm = new System.Windows.Forms.Panel();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.btnConsProd = new System.Windows.Forms.Button();
            this.btnAltaProd = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.panelPromocion = new System.Windows.Forms.Panel();
            this.btnAltaProm = new System.Windows.Forms.Button();
            this.btnpromocion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.Horafecha = new System.Windows.Forms.Timer(this.components);
            this.panelCont = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelBtn.SuspendLayout();
            this.panelsubm.SuspendLayout();
            this.panelProductos.SuspendLayout();
            this.panelPromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.panelTitle.Controls.Add(this.btnMin);
            this.panelTitle.Controls.Add(this.btnMint);
            this.panelTitle.Controls.Add(this.btnMax);
            this.panelTitle.Controls.Add(this.btnCerrar);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1300, 38);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1180, 7);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 6;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMint
            // 
            this.btnMint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMint.Image = ((System.Drawing.Image)(resources.GetObject("btnMint.Image")));
            this.btnMint.Location = new System.Drawing.Point(1221, 7);
            this.btnMint.Name = "btnMint";
            this.btnMint.Size = new System.Drawing.Size(25, 25);
            this.btnMint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMint.TabIndex = 5;
            this.btnMint.TabStop = false;
            this.btnMint.Visible = false;
            this.btnMint.Click += new System.EventHandler(this.btnMint_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(1221, 7);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 25);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 4;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1263, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelBtn
            // 
            this.panelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.panelBtn.Controls.Add(this.lblHora);
            this.panelBtn.Controls.Add(this.lblFecha);
            this.panelBtn.Controls.Add(this.panelsubm);
            this.panelBtn.Controls.Add(this.pictureBox2);
            this.panelBtn.Controls.Add(this.btnFacturacion);
            this.panelBtn.Controls.Add(this.btnVentas);
            this.panelBtn.Controls.Add(this.btnMenu);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBtn.Location = new System.Drawing.Point(0, 38);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(220, 612);
            this.panelBtn.TabIndex = 1;
            this.panelBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBtn_Paint);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHora.Location = new System.Drawing.Point(12, 69);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(125, 54);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.LightGray;
            this.lblFecha.Location = new System.Drawing.Point(73, 134);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 24);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelsubm
            // 
            this.panelsubm.Controls.Add(this.panelProductos);
            this.panelsubm.Controls.Add(this.btnProd);
            this.panelsubm.Controls.Add(this.panelPromocion);
            this.panelsubm.Controls.Add(this.btnpromocion);
            this.panelsubm.Location = new System.Drawing.Point(0, 359);
            this.panelsubm.Name = "panelsubm";
            this.panelsubm.Size = new System.Drawing.Size(220, 186);
            this.panelsubm.TabIndex = 15;
            // 
            // panelProductos
            // 
            this.panelProductos.Controls.Add(this.btnConsProd);
            this.panelProductos.Controls.Add(this.btnAltaProd);
            this.panelProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductos.Location = new System.Drawing.Point(0, 120);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(220, 64);
            this.panelProductos.TabIndex = 4;
            // 
            // btnConsProd
            // 
            this.btnConsProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsProd.FlatAppearance.BorderSize = 0;
            this.btnConsProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnConsProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsProd.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsProd.ForeColor = System.Drawing.Color.White;
            this.btnConsProd.Location = new System.Drawing.Point(0, 30);
            this.btnConsProd.Name = "btnConsProd";
            this.btnConsProd.Size = new System.Drawing.Size(220, 30);
            this.btnConsProd.TabIndex = 2;
            this.btnConsProd.Text = "Consultas de productos";
            this.btnConsProd.UseVisualStyleBackColor = true;
            this.btnConsProd.Click += new System.EventHandler(this.btnConsProd_Click_1);
            // 
            // btnAltaProd
            // 
            this.btnAltaProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaProd.FlatAppearance.BorderSize = 0;
            this.btnAltaProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnAltaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaProd.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProd.ForeColor = System.Drawing.Color.White;
            this.btnAltaProd.Location = new System.Drawing.Point(0, 0);
            this.btnAltaProd.Name = "btnAltaProd";
            this.btnAltaProd.Size = new System.Drawing.Size(220, 30);
            this.btnAltaProd.TabIndex = 1;
            this.btnAltaProd.Text = "Agregar productos";
            this.btnAltaProd.UseVisualStyleBackColor = true;
            this.btnAltaProd.Click += new System.EventHandler(this.btnAltaProd_Click_1);
            // 
            // btnProd
            // 
            this.btnProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProd.FlatAppearance.BorderSize = 0;
            this.btnProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.ForeColor = System.Drawing.Color.White;
            this.btnProd.Image = ((System.Drawing.Image)(resources.GetObject("btnProd.Image")));
            this.btnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProd.Location = new System.Drawing.Point(0, 79);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(220, 41);
            this.btnProd.TabIndex = 3;
            this.btnProd.Text = "Productos";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // panelPromocion
            // 
            this.panelPromocion.Controls.Add(this.btnAltaProm);
            this.panelPromocion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPromocion.Location = new System.Drawing.Point(0, 41);
            this.panelPromocion.Name = "panelPromocion";
            this.panelPromocion.Size = new System.Drawing.Size(220, 38);
            this.panelPromocion.TabIndex = 1;
            // 
            // btnAltaProm
            // 
            this.btnAltaProm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btnAltaProm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaProm.FlatAppearance.BorderSize = 0;
            this.btnAltaProm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnAltaProm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaProm.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProm.ForeColor = System.Drawing.Color.White;
            this.btnAltaProm.Location = new System.Drawing.Point(0, 0);
            this.btnAltaProm.Name = "btnAltaProm";
            this.btnAltaProm.Size = new System.Drawing.Size(220, 30);
            this.btnAltaProm.TabIndex = 1;
            this.btnAltaProm.Text = "Agregar promocion";
            this.btnAltaProm.UseVisualStyleBackColor = false;
            this.btnAltaProm.Click += new System.EventHandler(this.btnAltaProm_Click);
            // 
            // btnpromocion
            // 
            this.btnpromocion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btnpromocion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpromocion.FlatAppearance.BorderSize = 0;
            this.btnpromocion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnpromocion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpromocion.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpromocion.ForeColor = System.Drawing.Color.White;
            this.btnpromocion.Image = ((System.Drawing.Image)(resources.GetObject("btnpromocion.Image")));
            this.btnpromocion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpromocion.Location = new System.Drawing.Point(0, 0);
            this.btnpromocion.Name = "btnpromocion";
            this.btnpromocion.Size = new System.Drawing.Size(220, 41);
            this.btnpromocion.TabIndex = 0;
            this.btnpromocion.Text = "Promociónes";
            this.btnpromocion.UseVisualStyleBackColor = false;
            this.btnpromocion.Click += new System.EventHandler(this.btnpromocion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 551);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 318);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(221, 41);
            this.btnFacturacion.TabIndex = 5;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 277);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(221, 41);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 236);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(220, 41);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Horafecha
            // 
            this.Horafecha.Enabled = true;
            this.Horafecha.Tick += new System.EventHandler(this.Horafecha_Tick);
            // 
            // panelCont
            // 
            this.panelCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panelCont.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCont.Location = new System.Drawing.Point(220, 38);
            this.panelCont.Name = "panelCont";
            this.panelCont.Size = new System.Drawing.Size(1080, 612);
            this.panelCont.TabIndex = 2;
            this.panelCont.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelCont);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelBtn.ResumeLayout(false);
            this.panelBtn.PerformLayout();
            this.panelsubm.ResumeLayout(false);
            this.panelProductos.ResumeLayout(false);
            this.panelPromocion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMint;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.Timer Horafecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panelCont;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelsubm;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Button btnConsProd;
        private System.Windows.Forms.Button btnAltaProd;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Panel panelPromocion;
        private System.Windows.Forms.Button btnAltaProm;
        private System.Windows.Forms.Button btnpromocion;
    }
}