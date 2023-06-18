
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarF));
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.bAlterar = new System.Windows.Forms.Button();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.cStatus = new System.Windows.Forms.ComboBox();
            this.bVoltar = new System.Windows.Forms.Button();
            this.cContato = new System.Windows.Forms.ComboBox();
            this.mCelular = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(182, 231);
            this.textNome.Multiline = true;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(349, 30);
            this.textNome.TabIndex = 4;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(211, 347);
            this.textEndereco.Multiline = true;
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(316, 30);
            this.textEndereco.TabIndex = 5;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(142, 169);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(148, 30);
            this.textID.TabIndex = 6;
            // 
            // bAlterar
            // 
            this.bAlterar.BackColor = System.Drawing.Color.Transparent;
            this.bAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAlterar.BackgroundImage")));
            this.bAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bAlterar.FlatAppearance.BorderSize = 0;
            this.bAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAlterar.Location = new System.Drawing.Point(827, 396);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(185, 63);
            this.bAlterar.TabIndex = 8;
            this.bAlterar.UseVisualStyleBackColor = false;
            this.bAlterar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(742, 167);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(168, 20);
            this.textCpf.TabIndex = 11;
            this.textCpf.Click += new System.EventHandler(this.textCpf_Click);
            // 
            // cStatus
            // 
            this.cStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cStatus.FormattingEnabled = true;
            this.cStatus.Location = new System.Drawing.Point(755, 293);
            this.cStatus.Name = "cStatus";
            this.cStatus.Size = new System.Drawing.Size(121, 21);
            this.cStatus.TabIndex = 61;
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Transparent;
            this.bVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVoltar.BackgroundImage")));
            this.bVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVoltar.FlatAppearance.BorderSize = 0;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Location = new System.Drawing.Point(650, 397);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(172, 63);
            this.bVoltar.TabIndex = 65;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // cContato
            // 
            this.cContato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cContato.FormattingEnabled = true;
            this.cContato.Location = new System.Drawing.Point(210, 288);
            this.cContato.Name = "cContato";
            this.cContato.Size = new System.Drawing.Size(121, 21);
            this.cContato.TabIndex = 69;
            this.cContato.SelectedIndexChanged += new System.EventHandler(this.cContato_SelectedIndexChanged);
            // 
            // mCelular
            // 
            this.mCelular.Location = new System.Drawing.Point(857, 234);
            this.mCelular.Multiline = true;
            this.mCelular.Name = "mCelular";
            this.mCelular.Size = new System.Drawing.Size(153, 30);
            this.mCelular.TabIndex = 72;
            // 
            // AlterarF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 461);
            this.Controls.Add(this.mCelular);
            this.Controls.Add(this.cContato);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.cStatus);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.bAlterar);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textNome);
            this.Name = "AlterarF";
            this.Text = "AlterarF";
            this.Load += new System.EventHandler(this.AlterarF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button bAlterar;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.ComboBox cStatus;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.ComboBox cContato;
        private System.Windows.Forms.TextBox mCelular;
    }
}