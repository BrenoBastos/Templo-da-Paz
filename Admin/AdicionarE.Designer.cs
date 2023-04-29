
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
            this.bAdicionar = new System.Windows.Forms.Button();
            this.Material = new System.Windows.Forms.Label();
            this.Quantidade = new System.Windows.Forms.Label();
            this.textMaterial = new System.Windows.Forms.TextBox();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fornecedor = new System.Windows.Forms.Label();
            this.textFornecedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAdicionar
            // 
            this.bAdicionar.Location = new System.Drawing.Point(380, 313);
            this.bAdicionar.Name = "bAdicionar";
            this.bAdicionar.Size = new System.Drawing.Size(75, 23);
            this.bAdicionar.TabIndex = 0;
            this.bAdicionar.Text = "Adicionar";
            this.bAdicionar.UseVisualStyleBackColor = true;
            this.bAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Location = new System.Drawing.Point(302, 100);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(44, 13);
            this.Material.TabIndex = 1;
            this.Material.Text = "Material";
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(302, 170);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(62, 13);
            this.Quantidade.TabIndex = 2;
            this.Quantidade.Text = "Quantidade";
            // 
            // textMaterial
            // 
            this.textMaterial.Location = new System.Drawing.Point(391, 93);
            this.textMaterial.Name = "textMaterial";
            this.textMaterial.Size = new System.Drawing.Size(100, 20);
            this.textMaterial.TabIndex = 3;
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(433, 171);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textQuantidade.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // Fornecedor
            // 
            this.Fornecedor.AutoSize = true;
            this.Fornecedor.Location = new System.Drawing.Point(329, 234);
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(61, 13);
            this.Fornecedor.TabIndex = 6;
            this.Fornecedor.Text = "Fornecedor";
            // 
            // textFornecedor
            // 
            this.textFornecedor.Location = new System.Drawing.Point(433, 227);
            this.textFornecedor.Name = "textFornecedor";
            this.textFornecedor.Size = new System.Drawing.Size(100, 20);
            this.textFornecedor.TabIndex = 7;
            // 
            // AdicionarE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textFornecedor);
            this.Controls.Add(this.Fornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.textMaterial);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.bAdicionar);
            this.Name = "AdicionarE";
            this.Text = "AdicionarE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdicionar;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.TextBox textMaterial;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Fornecedor;
        private System.Windows.Forms.TextBox textFornecedor;
    }
}