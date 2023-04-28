
namespace WindowsFormsApp1
{
    partial class DadosCadaverA
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
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gaveta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retirada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.ID,
            this.Gaveta,
            this.DataChegada,
            this.HorarioChegada,
            this.Retirada});
            this.dataGridView1.Location = new System.Drawing.Point(12, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 144);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Gaveta
            // 
            this.Gaveta.HeaderText = "Gaveta";
            this.Gaveta.Name = "Gaveta";
            // 
            // DataChegada
            // 
            this.DataChegada.HeaderText = "DataChegada";
            this.DataChegada.Name = "DataChegada";
            // 
            // HorarioChegada
            // 
            this.HorarioChegada.HeaderText = "HorarioChegada";
            this.HorarioChegada.Name = "HorarioChegada";
            // 
            // Retirada
            // 
            this.Retirada.HeaderText = "Retirada";
            this.Retirada.Name = "Retirada";
            // 
            // DadosCadaverA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DadosCadaverA";
            this.Text = "DadosCadaverA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gaveta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retirada;
    }
}