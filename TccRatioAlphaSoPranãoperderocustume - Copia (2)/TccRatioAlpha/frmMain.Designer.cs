namespace TccRatioAlpha
{
    partial class frmMain
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noticiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moedaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noticiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelPrincipal.Location = new System.Drawing.Point(111, 120);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(600, 350);
            this.panelPrincipal.TabIndex = 26;
            // 
            // panelTop
            // 
            this.panelTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(123)))), ((int)(((byte)(29)))));
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Location = new System.Drawing.Point(0, 27);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 87);
            this.panelTop.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 76);
            this.label1.TabIndex = 14;
            this.label1.Text = "Virtua\'let";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(123)))), ((int)(((byte)(29)))));
            this.pictureBox1.BackgroundImage = global::TccRatioAlpha.Properties.Resources.branco;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.graficoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginaInicialToolStripMenuItem
            // 
            this.paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            this.paginaInicialToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.paginaInicialToolStripMenuItem.Text = "Pagina Inicial";
            this.paginaInicialToolStripMenuItem.Click += new System.EventHandler(this.paginaInicialToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.moedaToolStripMenuItem,
            this.noticiaToolStripMenuItem,
            this.transaçãoToolStripMenuItem,
            this.tagsToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // moedaToolStripMenuItem
            // 
            this.moedaToolStripMenuItem.Name = "moedaToolStripMenuItem";
            this.moedaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moedaToolStripMenuItem.Text = "Moeda";
            this.moedaToolStripMenuItem.Click += new System.EventHandler(this.moedaToolStripMenuItem_Click);
            // 
            // noticiaToolStripMenuItem
            // 
            this.noticiaToolStripMenuItem.Name = "noticiaToolStripMenuItem";
            this.noticiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noticiaToolStripMenuItem.Text = "Noticia";
            this.noticiaToolStripMenuItem.Click += new System.EventHandler(this.noticiaToolStripMenuItem_Click);
            // 
            // transaçãoToolStripMenuItem
            // 
            this.transaçãoToolStripMenuItem.Name = "transaçãoToolStripMenuItem";
            this.transaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transaçãoToolStripMenuItem.Text = "Transação";
            this.transaçãoToolStripMenuItem.Click += new System.EventHandler(this.transaçãoToolStripMenuItem_Click);
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tagsToolStripMenuItem.Text = "Tags";
            this.tagsToolStripMenuItem.Click += new System.EventHandler(this.tagsToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.moedaToolStripMenuItem1,
            this.noticiaToolStripMenuItem1,
            this.transaçãoToolStripMenuItem1,
            this.tagsToolStripMenuItem1});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // moedaToolStripMenuItem1
            // 
            this.moedaToolStripMenuItem1.Name = "moedaToolStripMenuItem1";
            this.moedaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.moedaToolStripMenuItem1.Text = "Moeda";
            this.moedaToolStripMenuItem1.Click += new System.EventHandler(this.moedaToolStripMenuItem1_Click);
            // 
            // noticiaToolStripMenuItem1
            // 
            this.noticiaToolStripMenuItem1.Name = "noticiaToolStripMenuItem1";
            this.noticiaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.noticiaToolStripMenuItem1.Text = "Noticia";
            this.noticiaToolStripMenuItem1.Click += new System.EventHandler(this.noticiaToolStripMenuItem1_Click);
            // 
            // transaçãoToolStripMenuItem1
            // 
            this.transaçãoToolStripMenuItem1.Name = "transaçãoToolStripMenuItem1";
            this.transaçãoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.transaçãoToolStripMenuItem1.Text = "Transação";
            this.transaçãoToolStripMenuItem1.Click += new System.EventHandler(this.transaçãoToolStripMenuItem1_Click);
            // 
            // tagsToolStripMenuItem1
            // 
            this.tagsToolStripMenuItem1.Name = "tagsToolStripMenuItem1";
            this.tagsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tagsToolStripMenuItem1.Text = "Tags";
            this.tagsToolStripMenuItem1.Click += new System.EventHandler(this.tagsToolStripMenuItem1_Click);
            // 
            // graficoToolStripMenuItem
            // 
            this.graficoToolStripMenuItem.Name = "graficoToolStripMenuItem";
            this.graficoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.graficoToolStripMenuItem.Text = "Grafico";
            this.graficoToolStripMenuItem.Click += new System.EventHandler(this.graficoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.FlowLayoutPanel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noticiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moedaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noticiaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem graficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}