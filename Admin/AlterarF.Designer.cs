
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
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.bAlterar = new System.Windows.Forms.Button();
            this.CPF = new System.Windows.Forms.Label();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.cStatus = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.bVoltar = new System.Windows.Forms.Button();
            this.cContato = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mCelular = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.Celular = new System.Windows.Forms.Label();
            this.Contato1 = new System.Windows.Forms.Label();
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
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 6;
            // 
            // bAlterar
            // 
            this.bAlterar.Location = new System.Drawing.Point(378, 415);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 8;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            this.bAlterar.Click += new System.EventHandler(this.button1_Click);
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
            this.textCpf.Click += new System.EventHandler(this.textCpf_Click);
            // 
            // cStatus
            // 
            this.cStatus.FormattingEnabled = true;
            this.cStatus.Location = new System.Drawing.Point(418, 369);
            this.cStatus.Name = "cStatus";
            this.cStatus.Size = new System.Drawing.Size(121, 21);
            this.cStatus.TabIndex = 61;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(309, 372);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 60;
            this.Status.Text = "Status";
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(120, 264);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 65;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // cContato
            // 
            this.cContato.FormattingEnabled = true;
            this.cContato.Location = new System.Drawing.Point(378, 222);
            this.cContato.Name = "cContato";
            this.cContato.Size = new System.Drawing.Size(121, 21);
            this.cContato.TabIndex = 69;
            this.cContato.SelectedIndexChanged += new System.EventHandler(this.cContato_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Contato";
            // 
            // mCelular
            // 
            this.mCelular.Location = new System.Drawing.Point(393, 255);
            this.mCelular.Name = "mCelular";
            this.mCelular.Size = new System.Drawing.Size(100, 20);
            this.mCelular.TabIndex = 72;
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(309, 296);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(49, 13);
            this.Telefone.TabIndex = 71;
            this.Telefone.Text = "Telefone";
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.Location = new System.Drawing.Point(319, 262);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(39, 13);
            this.Celular.TabIndex = 70;
            this.Celular.Text = "Celular";
            // 
            // Contato1
            // 
            this.Contato1.AutoSize = true;
            this.Contato1.Location = new System.Drawing.Point(309, 320);
            this.Contato1.Name = "Contato1";
            this.Contato1.Size = new System.Drawing.Size(44, 13);
            this.Contato1.TabIndex = 73;
            this.Contato1.Text = "Contato";
            // 
            // AlterarF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contato1);
            this.Controls.Add(this.mCelular);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.cContato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.cStatus);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.bAlterar);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Nome);
            this.Name = "AlterarF";
            this.Text = "AlterarF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Endereço;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button bAlterar;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.ComboBox cStatus;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.ComboBox cContato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mCelular;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label Celular;
        private System.Windows.Forms.Label Contato1;
    }
}