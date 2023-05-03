
namespace WindowsFormsApp1
{
    partial class DadosE
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
            this.textMaterial = new System.Windows.Forms.TextBox();
            this.Material = new System.Windows.Forms.Label();
            this.bLocalizar = new System.Windows.Forms.Button();
            this.dDados = new System.Windows.Forms.DataGridView();
            this.dMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).BeginInit();
            this.SuspendLayout();
            // 
            // textMaterial
            // 
            this.textMaterial.Location = new System.Drawing.Point(389, 20);
            this.textMaterial.Name = "textMaterial";
            this.textMaterial.Size = new System.Drawing.Size(100, 20);
            this.textMaterial.TabIndex = 14;
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Location = new System.Drawing.Point(300, 27);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(44, 13);
            this.Material.TabIndex = 13;
            this.Material.Text = "Material";
            // 
            // bLocalizar
            // 
            this.bLocalizar.Location = new System.Drawing.Point(377, 102);
            this.bLocalizar.Name = "bLocalizar";
            this.bLocalizar.Size = new System.Drawing.Size(75, 23);
            this.bLocalizar.TabIndex = 12;
            this.bLocalizar.Text = "Localizar";
            this.bLocalizar.UseVisualStyleBackColor = true;
            this.bLocalizar.Click += new System.EventHandler(this.bLocalizar_Click);
            // 
            // dDados
            // 
            this.dDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dMaterial,
            this.dQuantidade,
            this.dFornecedor,
            this.dTotal});
            this.dDados.Location = new System.Drawing.Point(174, 150);
            this.dDados.Name = "dDados";
            this.dDados.Size = new System.Drawing.Size(453, 150);
            this.dDados.TabIndex = 15;
            // 
            // dMaterial
            // 
            this.dMaterial.HeaderText = "Material";
            this.dMaterial.Name = "dMaterial";
            this.dMaterial.ReadOnly = true;
            // 
            // dQuantidade
            // 
            this.dQuantidade.HeaderText = "Quantidade";
            this.dQuantidade.Name = "dQuantidade";
            this.dQuantidade.ReadOnly = true;
            // 
            // dFornecedor
            // 
            this.dFornecedor.HeaderText = "Fornecedor";
            this.dFornecedor.Name = "dFornecedor";
            this.dFornecedor.ReadOnly = true;
            // 
            // dTotal
            // 
            this.dTotal.HeaderText = "Total";
            this.dTotal.Name = "dTotal";
            this.dTotal.ReadOnly = true;
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(31, 248);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 93;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // DadosE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.dDados);
            this.Controls.Add(this.textMaterial);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.bLocalizar);
            this.Name = "DadosE";
            this.Text = "DadosE";
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMaterial;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.Button bLocalizar;
        private System.Windows.Forms.DataGridView dDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotal;
        private System.Windows.Forms.Button bVoltar;
    }
}