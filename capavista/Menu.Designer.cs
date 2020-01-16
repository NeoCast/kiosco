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
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelSub = new System.Windows.Forms.Panel();
            this.panelStock = new System.Windows.Forms.Panel();
            this.panelModElim = new System.Windows.Forms.Panel();
            this.btnModElim = new System.Windows.Forms.Button();
            this.panelAltaProd = new System.Windows.Forms.Panel();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnAltaProd = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConfiguración = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.Horafecha = new System.Windows.Forms.Timer(this.components);
            this.panelCont = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelBtn.SuspendLayout();
            this.panelSub.SuspendLayout();
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
            this.panelBtn.Controls.Add(this.pictureBox2);
            this.panelBtn.Controls.Add(this.lblFecha);
            this.panelBtn.Controls.Add(this.panelSub);
            this.panelBtn.Controls.Add(this.panel5);
            this.panelBtn.Controls.Add(this.btnProductos);
            this.panelBtn.Controls.Add(this.panel4);
            this.panelBtn.Controls.Add(this.btnConfiguración);
            this.panelBtn.Controls.Add(this.panel3);
            this.panelBtn.Controls.Add(this.btnFacturacion);
            this.panelBtn.Controls.Add(this.panel2);
            this.panelBtn.Controls.Add(this.btnVentas);
            this.panelBtn.Controls.Add(this.panel1);
            this.panelBtn.Controls.Add(this.btnMenu);
            this.panelBtn.Controls.Add(this.lblHora);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBtn.Location = new System.Drawing.Point(0, 38);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(220, 612);
            this.panelBtn.TabIndex = 1;
            this.panelBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBtn_Paint);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.LightGray;
            this.lblFecha.Location = new System.Drawing.Point(64, 106);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 24);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelSub
            // 
            this.panelSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSub.Controls.Add(this.panelStock);
            this.panelSub.Controls.Add(this.panelModElim);
            this.panelSub.Controls.Add(this.btnModElim);
            this.panelSub.Controls.Add(this.panelAltaProd);
            this.panelSub.Controls.Add(this.btnStock);
            this.panelSub.Controls.Add(this.btnAltaProd);
            this.panelSub.Location = new System.Drawing.Point(44, 410);
            this.panelSub.Name = "panelSub";
            this.panelSub.Size = new System.Drawing.Size(176, 116);
            this.panelSub.TabIndex = 13;
            this.panelSub.Visible = false;
            this.panelSub.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panelStock
            // 
            this.panelStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.panelStock.Location = new System.Drawing.Point(0, 0);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(5, 33);
            this.panelStock.TabIndex = 4;
            this.panelStock.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // panelModElim
            // 
            this.panelModElim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.panelModElim.Location = new System.Drawing.Point(0, 78);
            this.panelModElim.Name = "panelModElim";
            this.panelModElim.Size = new System.Drawing.Size(5, 33);
            this.panelModElim.TabIndex = 6;
            this.panelModElim.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // btnModElim
            // 
            this.btnModElim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btnModElim.FlatAppearance.BorderSize = 0;
            this.btnModElim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnModElim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModElim.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModElim.ForeColor = System.Drawing.Color.White;
            this.btnModElim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModElim.Location = new System.Drawing.Point(3, 78);
            this.btnModElim.Name = "btnModElim";
            this.btnModElim.Size = new System.Drawing.Size(173, 33);
            this.btnModElim.TabIndex = 5;
            this.btnModElim.Text = "Consultas";
            this.btnModElim.UseVisualStyleBackColor = false;
            this.btnModElim.Click += new System.EventHandler(this.btnModElim_Click);
            // 
            // panelAltaProd
            // 
            this.panelAltaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.panelAltaProd.Location = new System.Drawing.Point(0, 39);
            this.panelAltaProd.Name = "panelAltaProd";
            this.panelAltaProd.Size = new System.Drawing.Size(5, 33);
            this.panelAltaProd.TabIndex = 4;
            this.panelAltaProd.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(4, 0);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(173, 33);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnAltaProd
            // 
            this.btnAltaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btnAltaProd.FlatAppearance.BorderSize = 0;
            this.btnAltaProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnAltaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaProd.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProd.ForeColor = System.Drawing.Color.White;
            this.btnAltaProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaProd.Location = new System.Drawing.Point(3, 39);
            this.btnAltaProd.Name = "btnAltaProd";
            this.btnAltaProd.Size = new System.Drawing.Size(173, 33);
            this.btnAltaProd.TabIndex = 3;
            this.btnAltaProd.Text = "Agregar productos";
            this.btnAltaProd.UseVisualStyleBackColor = false;
            this.btnAltaProd.Click += new System.EventHandler(this.btnAltaProd_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.panel5.Location = new System.Drawing.Point(0, 363);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 41);
            this.panel5.TabIndex = 10;
            // 
            // btnProductos
            // 
            this.btnProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(3, 363);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(217, 41);
            this.btnProductos.TabIndex = 9;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.panel4.Location = new System.Drawing.Point(0, 316);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 41);
            this.panel4.TabIndex = 8;
            // 
            // btnConfiguración
            // 
            this.btnConfiguración.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguración.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btnConfiguración.FlatAppearance.BorderSize = 0;
            this.btnConfiguración.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnConfiguración.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguración.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguración.ForeColor = System.Drawing.Color.White;
            this.btnConfiguración.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguración.Image")));
            this.btnConfiguración.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguración.Location = new System.Drawing.Point(3, 316);
            this.btnConfiguración.Name = "btnConfiguración";
            this.btnConfiguración.Size = new System.Drawing.Size(217, 41);
            this.btnConfiguración.TabIndex = 7;
            this.btnConfiguración.Text = "Promociónes";
            this.btnConfiguración.UseVisualStyleBackColor = false;
            this.btnConfiguración.Click += new System.EventHandler(this.btnConfiguración_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.panel3.Location = new System.Drawing.Point(0, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 41);
            this.panel3.TabIndex = 6;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(3, 269);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(217, 41);
            this.btnFacturacion.TabIndex = 5;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.panel2.Location = new System.Drawing.Point(0, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 41);
            this.panel2.TabIndex = 4;
            // 
            // btnVentas
            // 
            this.btnVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(3, 222);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(217, 41);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 41);
            this.panel1.TabIndex = 2;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(3, 175);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(217, 41);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHora.Location = new System.Drawing.Point(3, 41);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(125, 54);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
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
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 554);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
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
            this.panelSub.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSub;
        private System.Windows.Forms.Panel panelAltaProd;
        private System.Windows.Forms.Button btnAltaProd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnConfiguración;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelModElim;
        private System.Windows.Forms.Button btnModElim;
        private System.Windows.Forms.Panel panelStock;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panelCont;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}