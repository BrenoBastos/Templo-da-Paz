
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
            this.textFornecedor = new System.Windows.Forms.TextBox();
            this.Fornecedor = new System.Windows.Forms.Label();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.textMaterial = new System.Windows.Forms.TextBox();
            this.Quantidade = new System.Windows.Forms.Label();
            this.Material = new System.Windows.Forms.Label();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.bVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textFornecedor
            // 
            this.textFornecedor.Location = new System.Drawing.Point(416, 238);
            this.textFornecedor.Name = "textFornecedor";
            this.textFornecedor.Size = new System.Drawing.Size(100, 20);
            this.textFornecedor.TabIndex = 14;
            // 
            // Fornecedor
            // 
            this.Fornecedor.AutoSize = true;
            this.Fornecedor.Location = new System.Drawing.Point(312, 245);
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(61, 13);
            this.Fornecedor.TabIndex = 13;
            this.Fornecedor.Text = "Fornecedor";
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(416, 182);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textQuantidade.TabIndex = 12;
            // 
            // textMaterial
            // 
            this.textMaterial.Location = new System.Drawing.Point(374, 104);
            this.textMaterial.Name = "textMaterial";
            this.textMaterial.Size = new System.Drawing.Size(100, 20);
            this.textMaterial.TabIndex = 11;
            this.textMaterial.TextChanged += new System.EventHandler(this.textMaterial_TextChanged);
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(285, 181);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(62, 13);
            this.Quantidade.TabIndex = 10;
            this.Quantidade.Text = "Quantidade";
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Location = new System.Drawing.Point(285, 111);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(44, 13);
            this.Material.TabIndex = 9;
            this.Material.Text = "Material";
            this.Material.Click += new System.EventHandler(this.Material_Click);
            // 
            // bCadastrar
            // 
            this.bCadastrar.Location = new System.Drawing.Point(363, 324);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(75, 23);
            this.bCadastrar.TabIndex = 8;
            this.bCadastrar.Text = "Cadastrar";
            this.bCadastrar.UseVisualStyleBackColor = true;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(109, 283);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 89;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // CadastrarE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.textFornecedor);
            this.Controls.Add(this.Fornecedor);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.textMaterial);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.bCadastrar);
            this.Name = "CadastrarE";
            this.Text = "CadastrarE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFornecedor;
        private System.Windows.Forms.Label Fornecedor;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.TextBox textMaterial;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.Button bCadastrar;
        private System.Windows.Forms.Button bVoltar;
    }
}