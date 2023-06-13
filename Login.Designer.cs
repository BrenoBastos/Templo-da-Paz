namespace WindowsFormsApp1
{
    partial class Login
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BotaoLogin = new System.Windows.Forms.Button();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotaoLogin
            // 
            this.BotaoLogin.BackColor = System.Drawing.Color.Transparent;
            this.BotaoLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotaoLogin.BackgroundImage")));
            this.BotaoLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotaoLogin.FlatAppearance.BorderSize = 0;
            this.BotaoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoLogin.Location = new System.Drawing.Point(179, 566);
            this.BotaoLogin.Name = "BotaoLogin";
            this.BotaoLogin.Size = new System.Drawing.Size(338, 83);
            this.BotaoLogin.TabIndex = 0;
            this.BotaoLogin.UseVisualStyleBackColor = false;
            this.BotaoLogin.Click += new System.EventHandler(this.BotaoLogin_Click);
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(214, 454);
            this.textSenha.Multiline = true;
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(374, 41);
            this.textSenha.TabIndex = 87;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(214, 343);
            this.textNome.Multiline = true;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(374, 41);
            this.textNome.TabIndex = 89;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(158, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 41);
            this.button1.TabIndex = 90;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(158, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 41);
            this.button2.TabIndex = 91;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(614, 711);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.BotaoLogin);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoLogin;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

