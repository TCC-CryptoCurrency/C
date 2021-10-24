namespace TccRatioAlpha
{
    partial class ucCadastroNoticia
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
            this.btnCad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            this.clTags = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnCad
            // 
            this.btnCad.FlatAppearance.BorderSize = 0;
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad.Location = new System.Drawing.Point(263, 258);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(87, 27);
            this.btnCad.TabIndex = 58;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "Descrição da notícia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Titulo da notícia";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(102, 86);
            this.txtTitulo.MaxLength = 20;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(186, 20);
            this.txtTitulo.TabIndex = 53;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(324, 86);
            this.txtDesc.MaxLength = 50;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(185, 131);
            this.txtDesc.TabIndex = 60;
            this.txtDesc.Text = "";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(174, 145);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(31, 13);
            this.label.TabIndex = 62;
            this.label.Text = "Tags";
            // 
            // clTags
            // 
            this.clTags.FormattingEnabled = true;
            this.clTags.Location = new System.Drawing.Point(102, 168);
            this.clTags.Name = "clTags";
            this.clTags.Size = new System.Drawing.Size(186, 49);
            this.clTags.TabIndex = 63;
            // 
            // ucCadastroNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clTags);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.Name = "ucCadastroNoticia";
            this.Size = new System.Drawing.Size(600, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckedListBox clTags;
    }
}
