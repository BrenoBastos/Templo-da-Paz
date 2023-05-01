
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
            this.bLocalizar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.dDados = new System.Windows.Forms.DataGridView();
            this.dNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dHorarioChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataRetirada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRetirada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLegista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAssistente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).BeginInit();
            this.SuspendLayout();
            // 
            // bLocalizar
            // 
            this.bLocalizar.Location = new System.Drawing.Point(316, 150);
            this.bLocalizar.Name = "bLocalizar";
            this.bLocalizar.Size = new System.Drawing.Size(75, 23);
            this.bLocalizar.TabIndex = 31;
            this.bLocalizar.Text = "Localizar";
            this.bLocalizar.UseVisualStyleBackColor = true;
            this.bLocalizar.Click += new System.EventHandler(this.bLocalizar_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(316, 92);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 30;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(164, 101);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 29;
            this.Nome.Text = "Nome";
            // 
            // dDados
            // 
            this.dDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNome,
            this.dID,
            this.dDataChegada,
            this.dHorarioChegada,
            this.dDataRetirada,
            this.dRetirada,
            this.dLegista,
            this.dAssistente});
            this.dDados.Location = new System.Drawing.Point(12, 288);
            this.dDados.Name = "dDados";
            this.dDados.Size = new System.Drawing.Size(863, 150);
            this.dDados.TabIndex = 28;
            this.dDados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dDados_CellContentDoubleClick);
            // 
            // dNome
            // 
            this.dNome.HeaderText = "Nome";
            this.dNome.Name = "dNome";
            this.dNome.ReadOnly = true;
            // 
            // dID
            // 
            this.dID.HeaderText = "ID";
            this.dID.Name = "dID";
            this.dID.ReadOnly = true;
            // 
            // dDataChegada
            // 
            this.dDataChegada.HeaderText = "DataChegada";
            this.dDataChegada.Name = "dDataChegada";
            this.dDataChegada.ReadOnly = true;
            // 
            // dHorarioChegada
            // 
            this.dHorarioChegada.HeaderText = "HorarioChegada";
            this.dHorarioChegada.Name = "dHorarioChegada";
            this.dHorarioChegada.ReadOnly = true;
            // 
            // dDataRetirada
            // 
            this.dDataRetirada.HeaderText = "DataRetirada";
            this.dDataRetirada.Name = "dDataRetirada";
            this.dDataRetirada.ReadOnly = true;
            // 
            // dRetirada
            // 
            this.dRetirada.HeaderText = "Retirada";
            this.dRetirada.Name = "dRetirada";
            this.dRetirada.ReadOnly = true;
            // 
            // dLegista
            // 
            this.dLegista.HeaderText = "Legista";
            this.dLegista.Name = "dLegista";
            this.dLegista.ReadOnly = true;
            // 
            // dAssistente
            // 
            this.dAssistente.HeaderText = "Assistente";
            this.dAssistente.Name = "dAssistente";
            this.dAssistente.ReadOnly = true;
            // 
            // DadosCadaverA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.bLocalizar);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.dDados);
            this.Name = "DadosCadaverA";
            this.Text = "DadosCadaverA";
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLocalizar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.DataGridView dDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dHorarioChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLegista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAssistente;
    }
}