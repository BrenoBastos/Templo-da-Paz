
namespace WindowsFormsApp1
{
    partial class AlterarL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarL));
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.textRG = new System.Windows.Forms.MaskedTextBox();
            this.mDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.cSexo = new System.Windows.Forms.ComboBox();
            this.cEstadoCivil = new System.Windows.Forms.ComboBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAlterar = new System.Windows.Forms.Button();
            this.cStatus = new System.Windows.Forms.ComboBox();
            this.bVoltar = new System.Windows.Forms.Button();
            this.mCRM = new System.Windows.Forms.MaskedTextBox();
            this.cContato = new System.Windows.Forms.ComboBox();
            this.mCelular = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(161, 309);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(274, 20);
            this.textCpf.TabIndex = 50;
            this.textCpf.Click += new System.EventHandler(this.textCpf_Click_1);
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(660, 309);
            this.textRG.Mask = "00.000.000-0";
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(346, 20);
            this.textRG.TabIndex = 49;
            this.textRG.Click += new System.EventHandler(this.textRG_Click_1);
            // 
            // mDataNascimento
            // 
            this.mDataNascimento.Location = new System.Drawing.Point(838, 249);
            this.mDataNascimento.Mask = "00/00/0000";
            this.mDataNascimento.Name = "mDataNascimento";
            this.mDataNascimento.Size = new System.Drawing.Size(160, 20);
            this.mDataNascimento.TabIndex = 47;
            this.mDataNascimento.ValidatingType = typeof(System.DateTime);
            this.mDataNascimento.Click += new System.EventHandler(this.mDataNascimento_Click_1);
            // 
            // cSexo
            // 
            this.cSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cSexo.FormattingEnabled = true;
            this.cSexo.Location = new System.Drawing.Point(682, 365);
            this.cSexo.Name = "cSexo";
            this.cSexo.Size = new System.Drawing.Size(132, 21);
            this.cSexo.TabIndex = 46;
            // 
            // cEstadoCivil
            // 
            this.cEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cEstadoCivil.FormattingEnabled = true;
            this.cEstadoCivil.Location = new System.Drawing.Point(242, 547);
            this.cEstadoCivil.Name = "cEstadoCivil";
            this.cEstadoCivil.Size = new System.Drawing.Size(223, 21);
            this.cEstadoCivil.TabIndex = 45;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(216, 428);
            this.textEndereco.Multiline = true;
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(391, 30);
            this.textEndereco.TabIndex = 44;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(141, 188);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(100, 30);
            this.textID.TabIndex = 42;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(181, 248);
            this.textNome.Multiline = true;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(409, 30);
            this.textNome.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-84, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "RG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-79, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-84, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-84, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nome";
            // 
            // bAlterar
            // 
            this.bAlterar.BackColor = System.Drawing.Color.Transparent;
            this.bAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAlterar.BackgroundImage")));
            this.bAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bAlterar.FlatAppearance.BorderSize = 0;
            this.bAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAlterar.Location = new System.Drawing.Point(822, 571);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(185, 63);
            this.bAlterar.TabIndex = 29;
            this.bAlterar.UseVisualStyleBackColor = false;
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
            // 
            // cStatus
            // 
            this.cStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cStatus.FormattingEnabled = true;
            this.cStatus.Location = new System.Drawing.Point(693, 188);
            this.cStatus.Name = "cStatus";
            this.cStatus.Size = new System.Drawing.Size(157, 21);
            this.cStatus.TabIndex = 59;
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Transparent;
            this.bVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVoltar.BackgroundImage")));
            this.bVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVoltar.FlatAppearance.BorderSize = 0;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Location = new System.Drawing.Point(643, 572);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(172, 63);
            this.bVoltar.TabIndex = 66;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // mCRM
            // 
            this.mCRM.Location = new System.Drawing.Point(682, 489);
            this.mCRM.Mask = "0000000";
            this.mCRM.Name = "mCRM";
            this.mCRM.Size = new System.Drawing.Size(214, 20);
            this.mCRM.TabIndex = 85;
            this.mCRM.ValidatingType = typeof(System.DateTime);
            this.mCRM.Click += new System.EventHandler(this.mCRM_Click);
            // 
            // cContato
            // 
            this.cContato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cContato.FormattingEnabled = true;
            this.cContato.Location = new System.Drawing.Point(206, 488);
            this.cContato.Name = "cContato";
            this.cContato.Size = new System.Drawing.Size(242, 21);
            this.cContato.TabIndex = 87;
            this.cContato.SelectedIndexChanged += new System.EventHandler(this.cContato_SelectedIndexChanged_1);
            // 
            // mCelular
            // 
            this.mCelular.Location = new System.Drawing.Point(805, 429);
            this.mCelular.Multiline = true;
            this.mCelular.Name = "mCelular";
            this.mCelular.Size = new System.Drawing.Size(202, 30);
            this.mCelular.TabIndex = 90;
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.Location = new System.Drawing.Point(190, 368);
            this.textSenha.Multiline = true;
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(244, 30);
            this.textSenha.TabIndex = 109;
            // 
            // AlterarL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 636);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.mCelular);
            this.Controls.Add(this.cContato);
            this.Controls.Add(this.mCRM);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.cStatus);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.mDataNascimento);
            this.Controls.Add(this.cSexo);
            this.Controls.Add(this.cEstadoCivil);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAlterar);
            this.Name = "AlterarL";
            this.Text = "AlterarL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.MaskedTextBox textRG;
        private System.Windows.Forms.MaskedTextBox mDataNascimento;
        private System.Windows.Forms.ComboBox cSexo;
        private System.Windows.Forms.ComboBox cEstadoCivil;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAlterar;
        private System.Windows.Forms.ComboBox cStatus;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.MaskedTextBox mCRM;
        private System.Windows.Forms.ComboBox cContato;
        private System.Windows.Forms.TextBox mCelular;
        private System.Windows.Forms.TextBox textSenha;
    }
}