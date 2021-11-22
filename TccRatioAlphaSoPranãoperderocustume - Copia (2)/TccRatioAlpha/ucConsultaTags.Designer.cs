namespace TccRatioAlpha
{
    partial class ucConsultaTags
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdUsu = new System.Windows.Forms.DataGridView();
            this.IdCarteira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(487, 278);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 44);
            this.btnExcluir.TabIndex = 94;
            this.btnExcluir.Text = "🗑️\r\nExcluir\r\n";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(487, 224);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 48);
            this.btnEditar.TabIndex = 89;
            this.btnEditar.Text = "💾\r\nEditar\r\n";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(25, 235);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(156, 20);
            this.txtId.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Descrição da Tag";
            // 
            // grdUsu
            // 
            this.grdUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCarteira,
            this.NomeTags,
            this.descTags});
            this.grdUsu.Location = new System.Drawing.Point(66, 12);
            this.grdUsu.Name = "grdUsu";
            this.grdUsu.Size = new System.Drawing.Size(444, 140);
            this.grdUsu.TabIndex = 86;
            this.grdUsu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsu_CellDoubleClick);
            // 
            // IdCarteira
            // 
            this.IdCarteira.HeaderText = "Id ";
            this.IdCarteira.Name = "IdCarteira";
            // 
            // NomeTags
            // 
            this.NomeTags.HeaderText = "Nome";
            this.NomeTags.Name = "NomeTags";
            // 
            // descTags
            // 
            this.descTags.HeaderText = "Descrição";
            this.descTags.Name = "descTags";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(262, 235);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(156, 70);
            this.txtDesc.TabIndex = 101;
            this.txtDesc.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Nome da tag";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 285);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 20);
            this.txtNome.TabIndex = 102;
            // 
            // ucConsultaTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdUsu);
            this.Name = "ucConsultaTags";
            this.Size = new System.Drawing.Size(600, 350);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCarteira;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn descTags;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
    }
}
