namespace TccRatioAlpha
{
    partial class ucCadastroMoeda
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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCad
            // 
            this.btnCad.FlatAppearance.BorderSize = 0;
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad.Location = new System.Drawing.Point(255, 169);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(87, 37);
            this.btnCad.TabIndex = 58;
            this.btnCad.Text = "💾\r\nCadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(303, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "Valor da Moeda (somente numeros)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nome Da Moeda";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(102, 86);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(186, 20);
            this.txt_Nome.TabIndex = 53;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(318, 86);
            this.txt_Valor.Mask = "$00000000.00";
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(186, 20);
            this.txt_Valor.TabIndex = 62;
            // 
            // ucCadastroMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nome);
            this.Name = "ucCadastroMoeda";
            this.Size = new System.Drawing.Size(600, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.MaskedTextBox txt_Valor;
    }
}
