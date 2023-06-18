
namespace WindowsFormsApp1
{
    partial class CadastrarE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarE));
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.textMaterial = new System.Windows.Forms.TextBox();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.bVoltar = new System.Windows.Forms.Button();
            this.cFornecedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(258, 347);
            this.textQuantidade.Multiline = true;
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(227, 30);
            this.textQuantidade.TabIndex = 12;
            // 
            // textMaterial
            // 
            this.textMaterial.Location = new System.Drawing.Point(219, 217);
            this.textMaterial.Multiline = true;
            this.textMaterial.Name = "textMaterial";
            this.textMaterial.Size = new System.Drawing.Size(286, 30);
            this.textMaterial.TabIndex = 11;
            this.textMaterial.TextChanged += new System.EventHandler(this.textMaterial_TextChanged);
            // 
            // bCadastrar
            // 
            this.bCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.bCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCadastrar.BackgroundImage")));
            this.bCadastrar.FlatAppearance.BorderSize = 0;
            this.bCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCadastrar.Location = new System.Drawing.Point(769, 429);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(229, 75);
            this.bCadastrar.TabIndex = 8;
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
            this.bVoltar.Location = new System.Drawing.Point(520, 429);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(228, 75);
            this.bVoltar.TabIndex = 89;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // cFornecedor
            // 
            this.cFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cFornecedor.FormattingEnabled = true;
            this.cFornecedor.Location = new System.Drawing.Point(251, 281);
            this.cFornecedor.Name = "cFornecedor";
            this.cFornecedor.Size = new System.Drawing.Size(248, 21);
            this.cFornecedor.TabIndex = 90;
            // 
            // CadastrarE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 510);
            this.Controls.Add(this.cFornecedor);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.textMaterial);
            this.Controls.Add(this.bCadastrar);
            this.Name = "CadastrarE";
            this.Text = "CadastrarE";
            this.Load += new System.EventHandler(this.CadastrarE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.TextBox textMaterial;
        private System.Windows.Forms.Button bCadastrar;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.ComboBox cFornecedor;
    }
}