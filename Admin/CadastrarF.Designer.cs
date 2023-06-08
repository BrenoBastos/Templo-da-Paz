
namespace WindowsFormsApp1
{
    partial class CadastrarF
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
            this.cStatus = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.CPF = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.Endereço = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.bVoltar = new System.Windows.Forms.Button();
            this.cContato = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mCelular = new System.Windows.Forms.TextBox();
            this.Contato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cStatus
            // 
            this.cStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cStatus.FormattingEnabled = true;
            this.cStatus.Location = new System.Drawing.Point(372, 388);
            this.cStatus.Name = "cStatus";
            this.cStatus.Size = new System.Drawing.Size(121, 21);
            this.cStatus.TabIndex = 73;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(315, 391);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 72;
            this.Status.Text = "Status";
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(438, 161);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(100, 20);
            this.textCpf.TabIndex = 71;
            this.textCpf.Click += new System.EventHandler(this.textCpf_Click);
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Location = new System.Drawing.Point(263, 164);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(27, 13);
            this.CPF.TabIndex = 70;
            this.CPF.Text = "CPF";
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(438, 250);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(100, 20);
            this.textEndereco.TabIndex = 67;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(438, 110);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 66;
            // 
            // Endereço
            // 
            this.Endereço.AutoSize = true;
            this.Endereço.Location = new System.Drawing.Point(263, 253);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(53, 13);
            this.Endereço.TabIndex = 64;
            this.Endereço.Text = "Endereço";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(263, 114);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 62;
            this.Nome.Text = "Nome";
            // 
            // bCadastrar
            // 
            this.bCadastrar.Location = new System.Drawing.Point(372, 415);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(75, 23);
            this.bCadastrar.TabIndex = 74;
            this.bCadastrar.Text = "Cadastrar";
            this.bCadastrar.UseVisualStyleBackColor = true;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(172, 415);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 90;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // cContato
            // 
            this.cContato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cContato.FormattingEnabled = true;
            this.cContato.Location = new System.Drawing.Point(392, 296);
            this.cContato.Name = "cContato";
            this.cContato.Size = new System.Drawing.Size(121, 21);
            this.cContato.TabIndex = 97;
            this.cContato.SelectedIndexChanged += new System.EventHandler(this.cContato_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "Contato";
            // 
            // mCelular
            // 
            this.mCelular.Location = new System.Drawing.Point(387, 323);
            this.mCelular.Name = "mCelular";
            this.mCelular.Size = new System.Drawing.Size(100, 20);
            this.mCelular.TabIndex = 107;
            // 
            // Contato
            // 
            this.Contato.AutoSize = true;
            this.Contato.Location = new System.Drawing.Point(313, 330);
            this.Contato.Name = "Contato";
            this.Contato.Size = new System.Drawing.Size(44, 13);
            this.Contato.TabIndex = 105;
            this.Contato.Text = "Contato";
            // 
            // CadastrarF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mCelular);
            this.Controls.Add(this.Contato);
            this.Controls.Add(this.cContato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.bCadastrar);
            this.Controls.Add(this.cStatus);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.Nome);
            this.Name = "CadastrarF";
            this.Text = "CadastrarF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cStatus;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label Endereço;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button bCadastrar;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.ComboBox cContato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mCelular;
        private System.Windows.Forms.Label Contato;
    }
}