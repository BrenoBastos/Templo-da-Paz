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
            this.adsa = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.bLocalizar = new System.Windows.Forms.Button();
            this.bVoltar = new System.Windows.Forms.Button();
            this.dDados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRetirada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retirada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assistente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).BeginInit();
            this.SuspendLayout();
            // 
            // adsa
            // 
            this.adsa.AutoSize = true;
            this.adsa.Location = new System.Drawing.Point(171, 53);
            this.adsa.Name = "adsa";
            this.adsa.Size = new System.Drawing.Size(35, 13);
            this.adsa.TabIndex = 1;
            this.adsa.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(323, 44);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 3;
            // 
            // bLocalizar
            // 
            this.bLocalizar.Location = new System.Drawing.Point(323, 102);
            this.bLocalizar.Name = "bLocalizar";
            this.bLocalizar.Size = new System.Drawing.Size(75, 23);
            this.bLocalizar.TabIndex = 27;
            this.bLocalizar.Text = "Localizar";
            this.bLocalizar.UseVisualStyleBackColor = true;
            this.bLocalizar.Click += new System.EventHandler(this.bLocalizar_Click);
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(131, 102);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 75;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // dDados
            // 
            this.dDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.DataChegada,
            this.HorarioChegada,
            this.DataRetirada,
            this.Retirada,
            this.Legista,
            this.Assistente});
            this.dDados.Location = new System.Drawing.Point(51, 165);
            this.dDados.Name = "dDados";
            this.dDados.Size = new System.Drawing.Size(863, 150);
            this.dDados.TabIndex = 76;
            this.dDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dDados_CellDoubleClick_1);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // DataChegada
            // 
            this.DataChegada.DataPropertyName = "DataChegada";
            this.DataChegada.HeaderText = "DataChegada";
            this.DataChegada.Name = "DataChegada";
            this.DataChegada.ReadOnly = true;
            // 
            // HorarioChegada
            // 
            this.HorarioChegada.DataPropertyName = "HorarioChegada";
            this.HorarioChegada.HeaderText = "HorarioChegada";
            this.HorarioChegada.Name = "HorarioChegada";
            this.HorarioChegada.ReadOnly = true;
            // 
            // DataRetirada
            // 
            this.DataRetirada.DataPropertyName = "DataRetirada";
            this.DataRetirada.HeaderText = "DataRetirada";
            this.DataRetirada.Name = "DataRetirada";
            this.DataRetirada.ReadOnly = true;
            // 
            // Retirada
            // 
            this.Retirada.DataPropertyName = "Retirada";
            this.Retirada.HeaderText = "Retirada";
            this.Retirada.Name = "Retirada";
            this.Retirada.ReadOnly = true;
            // 
            // Legista
            // 
            this.Legista.DataPropertyName = "Legista";
            this.Legista.HeaderText = "Legista";
            this.Legista.Name = "Legista";
            this.Legista.ReadOnly = true;
            // 
            // Assistente
            // 
            this.Assistente.DataPropertyName = "Assistente";
            this.Assistente.HeaderText = "Assistente";
            this.Assistente.Name = "Assistente";
            this.Assistente.ReadOnly = true;
            // 
            // DadosCadaverL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.dDados);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.bLocalizar);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.adsa);
            this.Name = "DadosCadaverL";
            this.Text = "DadosCadaverL";
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label adsa;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button bLocalizar;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.DataGridView dDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assistente;
    }
}