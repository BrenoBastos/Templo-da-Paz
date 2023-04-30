
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
            this.cEstado = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.Label();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.CPF = new System.Windows.Forms.Label();
            this.mContato = new System.Windows.Forms.MaskedTextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.Contato = new System.Windows.Forms.Label();
            this.Endereço = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cEstado
            // 
            this.cEstado.FormattingEnabled = true;
            this.cEstado.Location = new System.Drawing.Point(416, 320);
            this.cEstado.Name = "cEstado";
            this.cEstado.Size = new System.Drawing.Size(121, 21);
            this.cEstado.TabIndex = 73;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(341, 320);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(40, 13);
            this.Estado.TabIndex = 72;
            this.Estado.Text = "Estado";
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
            // mContato
            // 
            this.mContato.Location = new System.Drawing.Point(429, 277);
            this.mContato.Name = "mContato";
            this.mContato.Size = new System.Drawing.Size(100, 20);
            this.mContato.TabIndex = 69;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(438, 224);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 68;
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
            // Contato
            // 
            this.Contato.AutoSize = true;
            this.Contato.Location = new System.Drawing.Point(272, 284);
            this.Contato.Name = "Contato";
            this.Contato.Size = new System.Drawing.Size(44, 13);
            this.Contato.TabIndex = 65;
            this.Contato.Text = "Contato";
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
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(263, 231);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 63;
            this.ID.Text = "ID";
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
            this.bCadastrar.Location = new System.Drawing.Point(357, 357);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(75, 23);
            this.bCadastrar.TabIndex = 74;
            this.bCadastrar.Text = "Cadastrar";
            this.bCadastrar.UseVisualStyleBackColor = true;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // CadastrarF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCadastrar);
            this.Controls.Add(this.cEstado);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.mContato);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.Contato);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Nome);
            this.Name = "CadastrarF";
            this.Text = "CadastrarF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cEstado;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.MaskedTextBox mContato;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label Contato;
        private System.Windows.Forms.Label Endereço;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button bCadastrar;
    }
}