
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadosCadaverA));
            this.bLocalizar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.dDados = new System.Windows.Forms.DataGridView();
            this.bVoltar = new System.Windows.Forms.Button();
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
            // bLocalizar
            // 
            this.bLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.bLocalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bLocalizar.BackgroundImage")));
            this.bLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bLocalizar.FlatAppearance.BorderSize = 0;
            this.bLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLocalizar.Location = new System.Drawing.Point(817, 656);
            this.bLocalizar.Name = "bLocalizar";
            this.bLocalizar.Size = new System.Drawing.Size(206, 67);
            this.bLocalizar.TabIndex = 31;
            this.bLocalizar.UseVisualStyleBackColor = false;
            this.bLocalizar.Click += new System.EventHandler(this.bLocalizar_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(302, 140);
            this.textNome.Multiline = true;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(600, 36);
            this.textNome.TabIndex = 30;
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
            this.dDados.Location = new System.Drawing.Point(44, 188);
            this.dDados.Name = "dDados";
            this.dDados.Size = new System.Drawing.Size(964, 452);
            this.dDados.TabIndex = 28;
            this.dDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dDados_CellDoubleClick);
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Transparent;
            this.bVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVoltar.BackgroundImage")));
            this.bVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVoltar.FlatAppearance.BorderSize = 0;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Location = new System.Drawing.Point(645, 656);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(166, 57);
            this.bVoltar.TabIndex = 73;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 160;
            // 
            // DataChegada
            // 
            this.DataChegada.DataPropertyName = "DataChegada";
            this.DataChegada.HeaderText = "DataChegada";
            this.DataChegada.Name = "DataChegada";
            this.DataChegada.ReadOnly = true;
            this.DataChegada.Width = 120;
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
            this.DataRetirada.Width = 120;
            // 
            // Retirada
            // 
            this.Retirada.DataPropertyName = "Retirada";
            this.Retirada.HeaderText = "Retirada";
            this.Retirada.Name = "Retirada";
            this.Retirada.ReadOnly = true;
            this.Retirada.Width = 130;
            // 
            // Legista
            // 
            this.Legista.DataPropertyName = "Legista";
            this.Legista.HeaderText = "Legista";
            this.Legista.Name = "Legista";
            this.Legista.ReadOnly = true;
            this.Legista.Width = 120;
            // 
            // Assistente
            // 
            this.Assistente.DataPropertyName = "Assistente";
            this.Assistente.HeaderText = "Assistente";
            this.Assistente.Name = "Assistente";
            this.Assistente.ReadOnly = true;
            this.Assistente.Width = 140;
            // 
            // DadosCadaverA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 725);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.bLocalizar);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.dDados);
            this.Name = "DadosCadaverA";
            this.Text = "DadosCadaverA";
            this.DoubleClick += new System.EventHandler(this.DadosCadaverA_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLocalizar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.DataGridView dDados;
        private System.Windows.Forms.Button bVoltar;
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