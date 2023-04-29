
namespace WindowsFormsApp1
{
    partial class AlterarF
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
            this.Nome = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Endereço = new System.Windows.Forms.Label();
            this.Contato = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.mContato = new System.Windows.Forms.MaskedTextBox();
            this.bAlterar = new System.Windows.Forms.Button();
            this.dDados = new System.Windows.Forms.DataGridView();
            this.DNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.Label();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.dEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEstado = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(224, 9);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(224, 126);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // Endereço
            // 
            this.Endereço.AutoSize = true;
            this.Endereço.Location = new System.Drawing.Point(224, 148);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(53, 13);
            this.Endereço.TabIndex = 2;
            this.Endereço.Text = "Endereço";
            // 
            // Contato
            // 
            this.Contato.AutoSize = true;
            this.Contato.Location = new System.Drawing.Point(233, 179);
            this.Contato.Name = "Contato";
            this.Contato.Size = new System.Drawing.Size(44, 13);
            this.Contato.TabIndex = 3;
            this.Contato.Text = "Contato";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(399, 5);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 4;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(399, 145);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(100, 20);
            this.textEndereco.TabIndex = 5;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(399, 119);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 6;
            // 
            // mContato
            // 
            this.mContato.Location = new System.Drawing.Point(390, 172);
            this.mContato.Name = "mContato";
            this.mContato.Size = new System.Drawing.Size(100, 20);
            this.mContato.TabIndex = 7;
            this.mContato.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mContato_MaskInputRejected);
            this.mContato.Click += new System.EventHandler(this.mContato_Click);
            // 
            // bAlterar
            // 
            this.bAlterar.Location = new System.Drawing.Point(399, 277);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 8;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            this.bAlterar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dDados
            // 
            this.dDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNome,
            this.dCpf,
            this.DID,
            this.DEndereco,
            this.DContato,
            this.dEstado});
            this.dDados.Location = new System.Drawing.Point(166, 320);
            this.dDados.Name = "dDados";
            this.dDados.Size = new System.Drawing.Size(622, 118);
            this.dDados.TabIndex = 9;
            // 
            // DNome
            // 
            this.DNome.HeaderText = "Nome";
            this.DNome.Name = "DNome";
            this.DNome.ReadOnly = true;
            // 
            // dCpf
            // 
            this.dCpf.HeaderText = "CPF";
            this.dCpf.Name = "dCpf";
            this.dCpf.ReadOnly = true;
            // 
            // DID
            // 
            this.DID.HeaderText = "ID";
            this.DID.Name = "DID";
            this.DID.ReadOnly = true;
            this.DID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DEndereco
            // 
            this.DEndereco.HeaderText = "Endereço";
            this.DEndereco.Name = "DEndereco";
            this.DEndereco.ReadOnly = true;
            // 
            // DContato
            // 
            this.DContato.HeaderText = "Contato";
            this.DContato.Name = "DContato";
            this.DContato.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Location = new System.Drawing.Point(224, 59);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(27, 13);
            this.CPF.TabIndex = 10;
            this.CPF.Text = "CPF";
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(399, 56);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(100, 20);
            this.textCpf.TabIndex = 11;
            this.textCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textCpf_MaskInputRejected);
            this.textCpf.Click += new System.EventHandler(this.textCpf_Click);
            // 
            // dEstado
            // 
            this.dEstado.HeaderText = "Estado";
            this.dEstado.Name = "dEstado";
            this.dEstado.ReadOnly = true;
            // 
            // cEstado
            // 
            this.cEstado.FormattingEnabled = true;
            this.cEstado.Location = new System.Drawing.Point(377, 215);
            this.cEstado.Name = "cEstado";
            this.cEstado.Size = new System.Drawing.Size(121, 21);
            this.cEstado.TabIndex = 61;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(302, 215);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(40, 13);
            this.Estado.TabIndex = 60;
            this.Estado.Text = "Estado";
            // 
            // AlterarF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cEstado);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.dDados);
            this.Controls.Add(this.bAlterar);
            this.Controls.Add(this.mContato);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.Contato);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Nome);
            this.Name = "AlterarF";
            this.Text = "AlterarF";
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Endereço;
        private System.Windows.Forms.Label Contato;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.MaskedTextBox mContato;
        private System.Windows.Forms.Button bAlterar;
        private System.Windows.Forms.DataGridView dDados;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn DID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn DContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEstado;
        private System.Windows.Forms.ComboBox cEstado;
        private System.Windows.Forms.Label Estado;
    }
}