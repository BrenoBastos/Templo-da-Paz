
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadosE));
            this.bLocalizar = new System.Windows.Forms.Button();
            this.dDados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bVoltar = new System.Windows.Forms.Button();
            this.textMaterial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).BeginInit();
            this.SuspendLayout();
            // 
            // bLocalizar
            // 
            this.bLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.bLocalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bLocalizar.BackgroundImage")));
            this.bLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bLocalizar.FlatAppearance.BorderSize = 0;
            this.bLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLocalizar.Location = new System.Drawing.Point(815, 668);
            this.bLocalizar.Name = "bLocalizar";
            this.bLocalizar.Size = new System.Drawing.Size(206, 67);
            this.bLocalizar.TabIndex = 12;
            this.bLocalizar.UseVisualStyleBackColor = false;
            this.bLocalizar.Click += new System.EventHandler(this.bLocalizar_Click);
            // 
            // dDados
            // 
            this.dDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Material,
            this.Quantidade,
            this.Fornecedor,
            this.Total});
            this.dDados.Location = new System.Drawing.Point(44, 188);
            this.dDados.Name = "dDados";
            this.dDados.Size = new System.Drawing.Size(964, 452);
            this.dDados.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 191;
            // 
            // Material
            // 
            this.Material.DataPropertyName = "Material";
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            this.Material.Width = 194;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 191;
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "Fornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            this.Fornecedor.Width = 193;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 191;
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Transparent;
            this.bVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVoltar.BackgroundImage")));
            this.bVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVoltar.FlatAppearance.BorderSize = 0;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Location = new System.Drawing.Point(645, 668);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(166, 57);
            this.bVoltar.TabIndex = 93;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // textMaterial
            // 
            this.textMaterial.Location = new System.Drawing.Point(276, 140);
            this.textMaterial.Multiline = true;
            this.textMaterial.Name = "textMaterial";
            this.textMaterial.Size = new System.Drawing.Size(732, 36);
            this.textMaterial.TabIndex = 95;
            // 
            // DadosE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1020, 725);
            this.Controls.Add(this.textMaterial);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.dDados);
            this.Controls.Add(this.bLocalizar);
            this.DoubleBuffered = true;
            this.Name = "DadosE";
            this.Load += new System.EventHandler(this.DadosE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bLocalizar;
        private System.Windows.Forms.DataGridView dDados;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.TextBox textMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}