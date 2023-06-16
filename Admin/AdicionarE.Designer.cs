
namespace WindowsFormsApp1
{
    partial class AdicionarE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarE));
            this.bAdicionar = new System.Windows.Forms.Button();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bVoltar = new System.Windows.Forms.Button();
            this.cFornecedor = new System.Windows.Forms.ComboBox();
            this.cMaterial = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bAdicionar
            // 
            this.bAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.bAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAdicionar.BackgroundImage")));
            this.bAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bAdicionar.FlatAppearance.BorderSize = 0;
            this.bAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdicionar.Location = new System.Drawing.Point(774, 283);
            this.bAdicionar.Name = "bAdicionar";
            this.bAdicionar.Size = new System.Drawing.Size(236, 86);
            this.bAdicionar.TabIndex = 0;
            this.bAdicionar.UseVisualStyleBackColor = false;
            this.bAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(233, 254);
            this.textQuantidade.Multiline = true;
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(213, 30);
            this.textQuantidade.TabIndex = 4;
            this.textQuantidade.TextChanged += new System.EventHandler(this.textQuantidade_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Transparent;
            this.bVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVoltar.BackgroundImage")));
            this.bVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVoltar.FlatAppearance.BorderSize = 0;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Location = new System.Drawing.Point(533, 283);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(236, 84);
            this.bVoltar.TabIndex = 8;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // cFornecedor
            // 
            this.cFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cFornecedor.FormattingEnabled = true;
            this.cFornecedor.Location = new System.Drawing.Point(227, 191);
            this.cFornecedor.Name = "cFornecedor";
            this.cFornecedor.Size = new System.Drawing.Size(234, 21);
            this.cFornecedor.TabIndex = 91;
            // 
            // cMaterial
            // 
            this.cMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cMaterial.FormattingEnabled = true;
            this.cMaterial.Location = new System.Drawing.Point(194, 133);
            this.cMaterial.Name = "cMaterial";
            this.cMaterial.Size = new System.Drawing.Size(267, 21);
            this.cMaterial.TabIndex = 92;
            // 
            // AdicionarE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 363);
            this.Controls.Add(this.cMaterial);
            this.Controls.Add(this.cFornecedor);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.bAdicionar);
            this.Name = "AdicionarE";
            this.Text = "AdicionarE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdicionar;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.ComboBox cFornecedor;
        private System.Windows.Forms.ComboBox cMaterial;
    }
}