
namespace WindowsFormsApp1
{
    partial class AlterarA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarA));
            this.button1 = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.cEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cSexo = new System.Windows.Forms.ComboBox();
            this.mDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.textRG = new System.Windows.Forms.MaskedTextBox();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.cStatus = new System.Windows.Forms.ComboBox();
            this.bVoltar = new System.Windows.Forms.Button();
            this.cContato = new System.Windows.Forms.ComboBox();
            this.mCelular = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(823, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 63);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(149, 247);
            this.textNome.Multiline = true;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(351, 30);
            this.textNome.TabIndex = 12;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(107, 198);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(202, 30);
            this.textID.TabIndex = 15;
            this.textID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textID_KeyPress);
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(653, 359);
            this.textSenha.Multiline = true;
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(292, 30);
            this.textSenha.TabIndex = 16;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(175, 369);
            this.textEndereco.Multiline = true;
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(356, 30);
            this.textEndereco.TabIndex = 18;
            // 
            // cEstadoCivil
            // 
            this.cEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cEstadoCivil.FormattingEnabled = true;
            this.cEstadoCivil.Location = new System.Drawing.Point(210, 484);
            this.cEstadoCivil.Name = "cEstadoCivil";
            this.cEstadoCivil.Size = new System.Drawing.Size(190, 21);
            this.cEstadoCivil.TabIndex = 22;
            // 
            // cSexo
            // 
            this.cSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cSexo.FormattingEnabled = true;
            this.cSexo.Location = new System.Drawing.Point(616, 484);
            this.cSexo.Name = "cSexo";
            this.cSexo.Size = new System.Drawing.Size(235, 21);
            this.cSexo.TabIndex = 23;
            // 
            // mDataNascimento
            // 
            this.mDataNascimento.Location = new System.Drawing.Point(732, 238);
            this.mDataNascimento.Mask = "00/00/0000";
            this.mDataNascimento.Name = "mDataNascimento";
            this.mDataNascimento.Size = new System.Drawing.Size(213, 20);
            this.mDataNascimento.TabIndex = 24;
            this.mDataNascimento.ValidatingType = typeof(System.DateTime);
            this.mDataNascimento.Click += new System.EventHandler(this.mDataNascimento_Click);
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(548, 302);
            this.textRG.Mask = "00.000.000-0";
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(258, 20);
            this.textRG.TabIndex = 26;
            this.textRG.Click += new System.EventHandler(this.textRG_Click);
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(130, 302);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(249, 20);
            this.textCpf.TabIndex = 27;
            this.textCpf.Click += new System.EventHandler(this.textCpf_Click);
            // 
            // cStatus
            // 
            this.cStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cStatus.FormattingEnabled = true;
            this.cStatus.Location = new System.Drawing.Point(606, 181);
            this.cStatus.Name = "cStatus";
            this.cStatus.Size = new System.Drawing.Size(200, 21);
            this.cStatus.TabIndex = 63;
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Transparent;
            this.bVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVoltar.BackgroundImage")));
            this.bVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVoltar.FlatAppearance.BorderSize = 0;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Location = new System.Drawing.Point(634, 532);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(172, 63);
            this.bVoltar.TabIndex = 64;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // cContato
            // 
            this.cContato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cContato.FormattingEnabled = true;
            this.cContato.Location = new System.Drawing.Point(165, 424);
            this.cContato.Name = "cContato";
            this.cContato.Size = new System.Drawing.Size(235, 21);
            this.cContato.TabIndex = 65;
            this.cContato.SelectedIndexChanged += new System.EventHandler(this.CContato_SelectedIndexChanged);
            // 
            // mCelular
            // 
            this.mCelular.Location = new System.Drawing.Point(666, 424);
            this.mCelular.Multiline = true;
            this.mCelular.Name = "mCelular";
            this.mCelular.Size = new System.Drawing.Size(279, 30);
            this.mCelular.TabIndex = 69;
            // 
            // AlterarA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 607);
            this.Controls.Add(this.mCelular);
            this.Controls.Add(this.cContato);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.cStatus);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.mDataNascimento);
            this.Controls.Add(this.cSexo);
            this.Controls.Add(this.cEstadoCivil);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.button1);
            this.Name = "AlterarA";
            this.Text = "AlterarA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.ComboBox cEstadoCivil;
        private System.Windows.Forms.ComboBox cSexo;
        private System.Windows.Forms.MaskedTextBox mDataNascimento;
        private System.Windows.Forms.MaskedTextBox textRG;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.ComboBox cStatus;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.ComboBox cContato;
        private System.Windows.Forms.TextBox mCelular;
    }
}