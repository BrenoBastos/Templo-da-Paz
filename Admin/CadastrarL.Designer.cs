
namespace WindowsFormsApp1
{
    partial class CadastrarL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarL));
            this.cStatus = new System.Windows.Forms.ComboBox();
            this.mCRM = new System.Windows.Forms.MaskedTextBox();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.textRG = new System.Windows.Forms.MaskedTextBox();
            this.mDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.cSexo = new System.Windows.Forms.ComboBox();
            this.cEstadoCivil = new System.Windows.Forms.ComboBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.bVoltar = new System.Windows.Forms.Button();
            this.cContato = new System.Windows.Forms.ComboBox();
            this.mCelular = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cStatus
            // 
            this.cStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cStatus.FormattingEnabled = true;
            this.cStatus.Location = new System.Drawing.Point(705, 422);
            this.cStatus.Name = "cStatus";
            this.cStatus.Size = new System.Drawing.Size(303, 21);
            this.cStatus.TabIndex = 85;
            // 
            // mCRM
            // 
            this.mCRM.Location = new System.Drawing.Point(139, 318);
            this.mCRM.Mask = "0000000";
            this.mCRM.Name = "mCRM";
            this.mCRM.Size = new System.Drawing.Size(439, 20);
            this.mCRM.TabIndex = 83;
            this.mCRM.ValidatingType = typeof(System.DateTime);
            this.mCRM.Click += new System.EventHandler(this.mCRM_Click);
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(134, 266);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(439, 20);
            this.textCpf.TabIndex = 76;
            this.textCpf.Click += new System.EventHandler(this.textCpf_Click);
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(669, 266);
            this.textRG.Mask = "00.000.000-0";
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(319, 20);
            this.textRG.TabIndex = 75;
            this.textRG.Click += new System.EventHandler(this.textRG_Click);
            // 
            // mDataNascimento
            // 
            this.mDataNascimento.Location = new System.Drawing.Point(859, 214);
            this.mDataNascimento.Mask = "00/00/0000";
            this.mDataNascimento.Name = "mDataNascimento";
            this.mDataNascimento.Size = new System.Drawing.Size(152, 20);
            this.mDataNascimento.TabIndex = 73;
            this.mDataNascimento.ValidatingType = typeof(System.DateTime);
            this.mDataNascimento.Click += new System.EventHandler(this.mDataNascimento_Click);
            // 
            // cSexo
            // 
            this.cSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cSexo.FormattingEnabled = true;
            this.cSexo.Location = new System.Drawing.Point(761, 473);
            this.cSexo.Name = "cSexo";
            this.cSexo.Size = new System.Drawing.Size(244, 21);
            this.cSexo.TabIndex = 72;
            // 
            // cEstadoCivil
            // 
            this.cEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cEstadoCivil.FormattingEnabled = true;
            this.cEstadoCivil.Location = new System.Drawing.Point(208, 422);
            this.cEstadoCivil.Name = "cEstadoCivil";
            this.cEstadoCivil.Size = new System.Drawing.Size(307, 21);
            this.cEstadoCivil.TabIndex = 71;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(190, 474);
            this.textEndereco.Multiline = true;
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(388, 30);
            this.textEndereco.TabIndex = 70;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(151, 215);
            this.textNome.Multiline = true;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(427, 30);
            this.textNome.TabIndex = 67;
            // 
            // bCadastrar
            // 
            this.bCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.bCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCadastrar.BackgroundImage")));
            this.bCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bCadastrar.FlatAppearance.BorderSize = 0;
            this.bCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCadastrar.Location = new System.Drawing.Point(779, 534);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(229, 75);
            this.bCadastrar.TabIndex = 60;
            this.bCadastrar.UseVisualStyleBackColor = false;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Transparent;
            this.bVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVoltar.BackgroundImage")));
            this.bVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVoltar.FlatAppearance.BorderSize = 0;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Location = new System.Drawing.Point(544, 534);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(228, 75);
            this.bVoltar.TabIndex = 91;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // cContato
            // 
            this.cContato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cContato.FormattingEnabled = true;
            this.cContato.Location = new System.Drawing.Point(174, 368);
            this.cContato.Name = "cContato";
            this.cContato.Size = new System.Drawing.Size(336, 21);
            this.cContato.TabIndex = 93;
            this.cContato.SelectedIndexChanged += new System.EventHandler(this.cContato_SelectedIndexChanged);
            // 
            // mCelular
            // 
            this.mCelular.Location = new System.Drawing.Point(748, 370);
            this.mCelular.Multiline = true;
            this.mCelular.Name = "mCelular";
            this.mCelular.Size = new System.Drawing.Size(256, 30);
            this.mCelular.TabIndex = 107;
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.Location = new System.Drawing.Point(764, 318);
            this.textSenha.Multiline = true;
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(244, 30);
            this.textSenha.TabIndex = 108;
            // 
            // CadastrarL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 621);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.mCelular);
            this.Controls.Add(this.cContato);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.cStatus);
            this.Controls.Add(this.mCRM);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.mDataNascimento);
            this.Controls.Add(this.cSexo);
            this.Controls.Add(this.cEstadoCivil);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.bCadastrar);
            this.Name = "CadastrarL";
            this.Text = "CadastrarL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cStatus;
        private System.Windows.Forms.MaskedTextBox mCRM;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.MaskedTextBox textRG;
        private System.Windows.Forms.MaskedTextBox mDataNascimento;
        private System.Windows.Forms.ComboBox cSexo;
        private System.Windows.Forms.ComboBox cEstadoCivil;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button bCadastrar;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.ComboBox cContato;
        private System.Windows.Forms.TextBox mCelular;
        private System.Windows.Forms.TextBox textSenha;
    }
}