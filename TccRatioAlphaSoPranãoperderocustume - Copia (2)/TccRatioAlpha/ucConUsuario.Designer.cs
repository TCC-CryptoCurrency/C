namespace TccRatioAlpha
{
    partial class ucConUsuario
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
            this.grdCli = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenhaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CepCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaisCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Excluir = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCli)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCli
            // 
            this.grdCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.NomeCliente,
            this.UsuarioCliente,
            this.SenhaCliente,
            this.EnderecoCliente,
            this.CidadeCliente,
            this.CepCliente,
            this.PaisCliente});
            this.grdCli.Location = new System.Drawing.Point(3, 3);
            this.grdCli.Name = "grdCli";
            this.grdCli.Size = new System.Drawing.Size(594, 140);
            this.grdCli.TabIndex = 13;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            // 
            // NomeCliente
            // 
            this.NomeCliente.HeaderText = "Nome";
            this.NomeCliente.Name = "NomeCliente";
            // 
            // UsuarioCliente
            // 
            this.UsuarioCliente.HeaderText = "Email";
            this.UsuarioCliente.Name = "UsuarioCliente";
            // 
            // SenhaCliente
            // 
            this.SenhaCliente.HeaderText = "DataNasc";
            this.SenhaCliente.Name = "SenhaCliente";
            // 
            // EnderecoCliente
            // 
            this.EnderecoCliente.HeaderText = "Cpf";
            this.EnderecoCliente.Name = "EnderecoCliente";
            // 
            // CidadeCliente
            // 
            this.CidadeCliente.HeaderText = "Senha";
            this.CidadeCliente.Name = "CidadeCliente";
            // 
            // CepCliente
            // 
            this.CepCliente.HeaderText = "ChaveTemp";
            this.CepCliente.Name = "CepCliente";
            // 
            // PaisCliente
            // 
            this.PaisCliente.HeaderText = "DataChave";
            this.PaisCliente.Name = "PaisCliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(407, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(222, 285);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(222, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(222, 166);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(27, 285);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(27, 223);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 20;
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(407, 282);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 21;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(407, 223);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Atualizar.TabIndex = 22;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            // 
            // ucConUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grdCli);
            this.Name = "ucConUsuario";
            this.Size = new System.Drawing.Size(600, 350);
            ((System.ComponentModel.ISupportInitialize)(this.grdCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenhaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CepCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaisCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Atualizar;
    }
}
