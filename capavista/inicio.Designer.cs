namespace capavista
{
    partial class inicio
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.subpanelDeposito = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelDeposito = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.subpanelprod = new System.Windows.Forms.Panel();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnNuevoProd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelproducto = new System.Windows.Forms.Panel();
            this.btnProd = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.subpanelDeposito.SuspendLayout();
            this.panelDeposito.SuspendLayout();
            this.subpanelprod.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelproducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.Controls.Add(this.subpanelDeposito);
            this.panelLateral.Controls.Add(this.panelDeposito);
            this.panelLateral.Controls.Add(this.subpanelprod);
            this.panelLateral.Controls.Add(this.panel2);
            this.panelLateral.Controls.Add(this.panelLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(200, 538);
            this.panelLateral.TabIndex = 0;
            // 
            // subpanelDeposito
            // 
            this.subpanelDeposito.Controls.Add(this.button6);
            this.subpanelDeposito.Controls.Add(this.button5);
            this.subpanelDeposito.Dock = System.Windows.Forms.DockStyle.Top;
            this.subpanelDeposito.Location = new System.Drawing.Point(0, 263);
            this.subpanelDeposito.Name = "subpanelDeposito";
            this.subpanelDeposito.Size = new System.Drawing.Size(200, 75);
            this.subpanelDeposito.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(0, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 33);
            this.button6.TabIndex = 2;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 31);
            this.button5.TabIndex = 1;
            this.button5.Text = "Nuevo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panelDeposito
            // 
            this.panelDeposito.Controls.Add(this.button4);
            this.panelDeposito.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeposito.Location = new System.Drawing.Point(0, 219);
            this.panelDeposito.Name = "panelDeposito";
            this.panelDeposito.Size = new System.Drawing.Size(200, 44);
            this.panelDeposito.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 44);
            this.button4.TabIndex = 1;
            this.button4.Text = "Ventas";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // subpanelprod
            // 
            this.subpanelprod.Controls.Add(this.btnBuscarProd);
            this.subpanelprod.Controls.Add(this.btnNuevoProd);
            this.subpanelprod.Dock = System.Windows.Forms.DockStyle.Top;
            this.subpanelprod.Location = new System.Drawing.Point(0, 148);
            this.subpanelprod.Name = "subpanelprod";
            this.subpanelprod.Size = new System.Drawing.Size(200, 71);
            this.subpanelprod.TabIndex = 1;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarProd.Location = new System.Drawing.Point(0, 32);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(200, 32);
            this.btnBuscarProd.TabIndex = 1;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.BtnBuscarProd_Click);
            // 
            // btnNuevoProd
            // 
            this.btnNuevoProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoProd.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoProd.Name = "btnNuevoProd";
            this.btnNuevoProd.Size = new System.Drawing.Size(200, 32);
            this.btnNuevoProd.TabIndex = 0;
            this.btnNuevoProd.Text = "Nuevo";
            this.btnNuevoProd.UseVisualStyleBackColor = true;
            this.btnNuevoProd.Click += new System.EventHandler(this.BtnNuevoProd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panelproducto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 42);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 3;
            // 
            // panelproducto
            // 
            this.panelproducto.Controls.Add(this.btnProd);
            this.panelproducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelproducto.Location = new System.Drawing.Point(0, 0);
            this.panelproducto.Name = "panelproducto";
            this.panelproducto.Size = new System.Drawing.Size(200, 42);
            this.panelproducto.TabIndex = 2;
            // 
            // btnProd
            // 
            this.btnProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProd.Location = new System.Drawing.Point(0, 0);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(200, 42);
            this.btnProd.TabIndex = 0;
            this.btnProd.Text = "Productos";
            this.btnProd.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 106);
            this.panelLogo.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(200, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(848, 538);
            this.panel9.TabIndex = 1;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 538);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panelLateral);
            this.Name = "inicio";
            this.Text = "inicio";
            this.panelLateral.ResumeLayout(false);
            this.subpanelDeposito.ResumeLayout(false);
            this.panelDeposito.ResumeLayout(false);
            this.subpanelprod.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelproducto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelDeposito;
        private System.Windows.Forms.Panel subpanelDeposito;
        private System.Windows.Forms.Panel subpanelprod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelproducto;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Button btnNuevoProd;
        private System.Windows.Forms.Button btnProd;
    }
}