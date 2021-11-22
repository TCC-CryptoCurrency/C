namespace TccRatioAlpha
{
    partial class ucConsultaTransação
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtValord = new System.Windows.Forms.TextBox();
            this.grdUsu = new System.Windows.Forms.DataGridView();
            this.IdCarteira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenhaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbOrigem = new System.Windows.Forms.ComboBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbMoeda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(475, 269);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 44);
            this.btnExcluir.TabIndex = 89;
            this.btnExcluir.Text = "🗑️\r\nExcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(475, 215);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 48);
            this.btnEditar.TabIndex = 81;
            this.btnEditar.Text = "💾\r\nEditar\r\n";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(20, 177);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(120, 20);
            this.txtId.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Origem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Moeda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Valor";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(20, 273);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(186, 20);
            this.txtData.TabIndex = 77;
            // 
            // txtValord
            // 
            this.txtValord.Location = new System.Drawing.Point(20, 224);
            this.txtValord.Name = "txtValord";
            this.txtValord.Size = new System.Drawing.Size(186, 20);
            this.txtValord.TabIndex = 75;
            // 
            // grdUsu
            // 
            this.grdUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCarteira,
            this.NomeCliente,
            this.emailUsuario,
            this.SenhaUsuario,
            this.cpfUsuario,
            this.dataNasc});
            this.grdUsu.Location = new System.Drawing.Point(20, 3);
            this.grdUsu.Name = "grdUsu";
            this.grdUsu.Size = new System.Drawing.Size(542, 140);
            this.grdUsu.TabIndex = 82;
            this.grdUsu.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsu_CellContentDoubleClick);
            // 
            // IdCarteira
            // 
            this.IdCarteira.HeaderText = "Id ";
            this.IdCarteira.Name = "IdCarteira";
            // 
            // NomeCliente
            // 
            this.NomeCliente.HeaderText = "Valor da Transação";
            this.NomeCliente.Name = "NomeCliente";
            // 
            // emailUsuario
            // 
            this.emailUsuario.HeaderText = "Data da transação";
            this.emailUsuario.Name = "emailUsuario";
            // 
            // SenhaUsuario
            // 
            this.SenhaUsuario.HeaderText = "Origem";
            this.SenhaUsuario.Name = "SenhaUsuario";
            // 
            // cpfUsuario
            // 
            this.cpfUsuario.HeaderText = "Moeda Transferida";
            this.cpfUsuario.Name = "cpfUsuario";
            // 
            // dataNasc
            // 
            this.dataNasc.HeaderText = "Destino";
            this.dataNasc.Name = "dataNasc";
            // 
            // cbOrigem
            // 
            this.cbOrigem.FormattingEnabled = true;
            this.cbOrigem.Location = new System.Drawing.Point(255, 176);
            this.cbOrigem.Name = "cbOrigem";
            this.cbOrigem.Size = new System.Drawing.Size(161, 21);
            this.cbOrigem.TabIndex = 90;
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(255, 275);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(161, 21);
            this.cbDestino.TabIndex = 91;
            // 
            // cbMoeda
            // 
            this.cbMoeda.FormattingEnabled = true;
            this.cbMoeda.Location = new System.Drawing.Point(255, 223);
            this.cbMoeda.Name = "cbMoeda";
            this.cbMoeda.Size = new System.Drawing.Size(161, 21);
            this.cbMoeda.TabIndex = 92;
            // 
            // ucConsultaTransação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbMoeda);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.cbOrigem);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtValord);
            this.Controls.Add(this.grdUsu);
            this.Name = "ucConsultaTransação";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtValord;
        private System.Windows.Forms.DataGridView grdUsu;
        private System.Windows.Forms.ComboBox cbOrigem;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.ComboBox cbMoeda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCarteira;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenhaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasc;
    }
}
