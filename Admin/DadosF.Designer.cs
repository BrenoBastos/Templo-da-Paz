
namespace WindowsFormsApp1
{
    partial class DadosF
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
            this.dDados = new System.Windows.Forms.DataGridView();
            this.DNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLocalizar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.bVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dDados
            // 
            this.dDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNome,
            this.dEstado});
            this.dDados.Location = new System.Drawing.Point(97, 216);
            this.dDados.Name = "dDados";
            this.dDados.Size = new System.Drawing.Size(371, 118);
            this.dDados.TabIndex = 10;
            this.dDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dDados_CellDoubleClick);
            // 
            // DNome
            // 
            this.DNome.HeaderText = "Nome";
            this.DNome.Name = "DNome";
            this.DNome.ReadOnly = true;
            // 
            // dEstado
            // 
            this.dEstado.HeaderText = "Estado";
            this.dEstado.Name = "dEstado";
            this.dEstado.ReadOnly = true;
            // 
            // bLocalizar
            // 
            this.bLocalizar.Location = new System.Drawing.Point(427, 109);
            this.bLocalizar.Name = "bLocalizar";
            this.bLocalizar.Size = new System.Drawing.Size(75, 23);
            this.bLocalizar.TabIndex = 13;
            this.bLocalizar.Text = "Localizar";
            this.bLocalizar.UseVisualStyleBackColor = true;
            this.bLocalizar.Click += new System.EventHandler(this.bLocalizar_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(427, 18);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 12;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(252, 22);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 11;
            this.Nome.Text = "Nome";
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(3, 185);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 94;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // DadosF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.bLocalizar);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.dDados);
            this.Name = "DadosF";
            this.Text = "DadosF";
            this.Click += new System.EventHandler(this.DadosF_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dDados;
        private System.Windows.Forms.Button bLocalizar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEstado;
        private System.Windows.Forms.Button bVoltar;
    }
}