namespace TccRatioAlpha
{
    partial class ucModeloCadastro
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
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(452, 261);
            this.txtCep.Mask = "00000-9999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(77, 20);
            this.txtCep.TabIndex = 43;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(229, 262);
            this.txtTel.Mask = "(999) 00000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(114, 20);
            this.txtTel.TabIndex = 37;
            // 
            // btnCad
            // 
            this.btnCad.FlatAppearance.BorderSize = 0;
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad.Location = new System.Drawing.Point(362, 304);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(87, 27);
            this.btnCad.TabIndex = 45;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(461, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Cep";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(461, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 51;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(461, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Pais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nome Completo";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(452, 213);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(174, 20);
            this.txtPais.TabIndex = 42;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(452, 165);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(174, 20);
            this.txtCid.TabIndex = 41;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(452, 116);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(174, 20);
            this.txtEnd.TabIndex = 40;
            // 
            // txtUsu
            // 
            this.txtUsu.Location = new System.Drawing.Point(229, 164);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(186, 20);
            this.txtUsu.TabIndex = 38;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(229, 213);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(186, 20);
            this.txtPass.TabIndex = 39;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(229, 112);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 20);
            this.txtNome.TabIndex = 36;
            // 
            // ucModeloCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNome);
            this.Name = "ucModeloCadastro";
            this.Size = new System.Drawing.Size(852, 424);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtNome;
    }
}
