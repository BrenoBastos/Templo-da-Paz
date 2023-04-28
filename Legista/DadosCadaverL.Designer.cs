namespace WindowsFormsApp1
{
    partial class DadosCadaverL
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.NomeText = new System.Windows.Forms.TextBox();
            this.IDText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(171, 53);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(171, 106);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            // 
            // NomeText
            // 
            this.NomeText.Location = new System.Drawing.Point(323, 44);
            this.NomeText.Name = "NomeText";
            this.NomeText.Size = new System.Drawing.Size(100, 20);
            this.NomeText.TabIndex = 3;
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(323, 106);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(100, 20);
            this.IDText.TabIndex = 4;
            // 
            // DadosCadaverL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.NomeText);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DadosCadaverL";
            this.Text = "DadosCadaverL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox NomeText;
        private System.Windows.Forms.TextBox IDText;
    }
}