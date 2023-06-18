
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarF));
            this.cStatus = new System.Windows.Forms.ComboBox();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.bVoltar = new System.Windows.Forms.Button();
            this.cContato = new System.Windows.Forms.ComboBox();
            this.mCelular = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cStatus
            // 
            this.cStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cStatus.FormattingEnabled = true;
            this.cStatus.Location = new System.Drawing.Point(770, 324);
            this.cStatus.Name = "cStatus";
            this.cStatus.Size = new System.Drawing.Size(217, 21);
            this.cStatus.TabIndex = 73;
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(688, 208);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(301, 20);
            this.textCpf.TabIndex = 71;
            this.textCpf.Click += new System.EventHandler(this.textCpf_Click);
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(168, 326);
            this.textEndereco.Multiline = true;
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(320, 30);
            this.textEndereco.TabIndex = 67;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(128, 208);
            this.textNome.Multiline = true;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(365, 30);
            this.textNome.TabIndex = 66;
            // 
            // bCadastrar
            // 
            this.bCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.bCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCadastrar.BackgroundImage")));
            this.bCadastrar.FlatAppearance.BorderSize = 0;
            this.bCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCadastrar.Location = new System.Drawing.Point(777, 384);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(229, 75);
            this.bCadastrar.TabIndex = 74;
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
            this.bVoltar.Location = new System.Drawing.Point(528, 384);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(228, 75);
            this.bVoltar.TabIndex = 90;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // cContato
            // 
            this.cContato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cContato.FormattingEnabled = true;
            this.cContato.Location = new System.Drawing.Point(152, 266);
            this.cContato.Name = "cContato";
            this.cContato.Size = new System.Drawing.Size(243, 21);
            this.cContato.TabIndex = 97;
            this.cContato.SelectedIndexChanged += new System.EventHandler(this.cContato_SelectedIndexChanged);
            // 
            // mCelular
            // 
            this.mCelular.Location = new System.Drawing.Point(734, 267);
            this.mCelular.Multiline = true;
            this.mCelular.Name = "mCelular";
            this.mCelular.Size = new System.Drawing.Size(260, 30);
            this.mCelular.TabIndex = 107;
            // 
            // CadastrarF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 471);
            this.Controls.Add(this.mCelular);
            this.Controls.Add(this.cContato);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.bCadastrar);
            this.Controls.Add(this.cStatus);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textNome);
            this.Name = "CadastrarF";
            this.Text = "CadastrarF";
            this.Load += new System.EventHandler(this.CadastrarF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cStatus;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button bCadastrar;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.ComboBox cContato;
        private System.Windows.Forms.TextBox mCelular;
    }
}