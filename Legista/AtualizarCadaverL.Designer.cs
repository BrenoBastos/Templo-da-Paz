namespace WindowsFormsApp1
{
    partial class AtualizarCadaverL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizarCadaverL));
            this.textNome = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textGaveta = new System.Windows.Forms.TextBox();
            this.mHorarioChegada = new System.Windows.Forms.MaskedTextBox();
            this.mDataRetirada = new System.Windows.Forms.MaskedTextBox();
            this.mDataChegada = new System.Windows.Forms.MaskedTextBox();
            this.bAtualizar = new System.Windows.Forms.Button();
            this.dDados = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gaveta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assistente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textLaudo = new System.Windows.Forms.RichTextBox();
            this.cRetirada = new System.Windows.Forms.ComboBox();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.bVoltar = new System.Windows.Forms.Button();
            this.mHorárioÓbito = new System.Windows.Forms.MaskedTextBox();
            this.mDataObito = new System.Windows.Forms.MaskedTextBox();
            this.mHorarioRetirada = new System.Windows.Forms.MaskedTextBox();
            this.cLegista = new System.Windows.Forms.ComboBox();
            this.cAssistente = new System.Windows.Forms.ComboBox();
            this.cMaterial = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).BeginInit();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(113, 138);
            this.textNome.MaximumSize = new System.Drawing.Size(400, 100);
            this.textNome.MinimumSize = new System.Drawing.Size(20, 20);
            this.textNome.Multiline = true;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(376, 30);
            this.textNome.TabIndex = 47;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(576, 147);
            this.textID.MaximumSize = new System.Drawing.Size(100, 100);
            this.textID.MinimumSize = new System.Drawing.Size(20, 20);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(100, 30);
            this.textID.TabIndex = 46;
            // 
            // textGaveta
            // 
            this.textGaveta.Location = new System.Drawing.Point(627, 340);
            this.textGaveta.MaximumSize = new System.Drawing.Size(100, 100);
            this.textGaveta.MinimumSize = new System.Drawing.Size(20, 20);
            this.textGaveta.Multiline = true;
            this.textGaveta.Name = "textGaveta";
            this.textGaveta.Size = new System.Drawing.Size(100, 30);
            this.textGaveta.TabIndex = 45;
            // 
            // mHorarioChegada
            // 
            this.mHorarioChegada.Location = new System.Drawing.Point(759, 206);
            this.mHorarioChegada.Mask = "00:00";
            this.mHorarioChegada.Name = "mHorarioChegada";
            this.mHorarioChegada.Size = new System.Drawing.Size(207, 20);
            this.mHorarioChegada.TabIndex = 40;
            this.mHorarioChegada.ValidatingType = typeof(System.DateTime);
            this.mHorarioChegada.Click += new System.EventHandler(this.mHorarioChegada_Click);
            // 
            // mDataRetirada
            // 
            this.mDataRetirada.Location = new System.Drawing.Point(236, 260);
            this.mDataRetirada.Mask = "00/00/0000";
            this.mDataRetirada.Name = "mDataRetirada";
            this.mDataRetirada.Size = new System.Drawing.Size(247, 20);
            this.mDataRetirada.TabIndex = 39;
            this.mDataRetirada.ValidatingType = typeof(System.DateTime);
            this.mDataRetirada.Click += new System.EventHandler(this.mDataRetirada_Click);
            // 
            // mDataChegada
            // 
            this.mDataChegada.Location = new System.Drawing.Point(236, 205);
            this.mDataChegada.Mask = "00/00/0000";
            this.mDataChegada.Name = "mDataChegada";
            this.mDataChegada.Size = new System.Drawing.Size(247, 20);
            this.mDataChegada.TabIndex = 38;
            this.mDataChegada.ValidatingType = typeof(System.DateTime);
            this.mDataChegada.Click += new System.EventHandler(this.mDataChegada_Click);
            // 
            // bAtualizar
            // 
            this.bAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.bAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAtualizar.BackgroundImage")));
            this.bAtualizar.FlatAppearance.BorderSize = 0;
            this.bAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAtualizar.Location = new System.Drawing.Point(839, 632);
            this.bAtualizar.Name = "bAtualizar";
            this.bAtualizar.Size = new System.Drawing.Size(169, 57);
            this.bAtualizar.TabIndex = 26;
            this.bAtualizar.UseVisualStyleBackColor = false;
            this.bAtualizar.Click += new System.EventHandler(this.bAtualizar_Click);
            // 
            // dDados
            // 
            this.dDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Id,
            this.Gaveta,
            this.DataChegada,
            this.HorarioChegada,
            this.Assistente});
            this.dDados.Location = new System.Drawing.Point(781, 489);
            this.dDados.Name = "dDados";
            this.dDados.Size = new System.Drawing.Size(227, 122);
            this.dDados.TabIndex = 25;
            this.dDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dDados_CellDoubleClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Gaveta
            // 
            this.Gaveta.DataPropertyName = "Gaveta";
            this.Gaveta.HeaderText = "Gaveta";
            this.Gaveta.Name = "Gaveta";
            this.Gaveta.ReadOnly = true;
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
            // Assistente
            // 
            this.Assistente.DataPropertyName = "Assistente";
            this.Assistente.HeaderText = "Assistente";
            this.Assistente.Name = "Assistente";
            this.Assistente.ReadOnly = true;
            // 
            // textLaudo
            // 
            this.textLaudo.Location = new System.Drawing.Point(113, 489);
            this.textLaudo.Name = "textLaudo";
            this.textLaudo.Size = new System.Drawing.Size(646, 135);
            this.textLaudo.TabIndex = 49;
            this.textLaudo.Text = "";
            // 
            // cRetirada
            // 
            this.cRetirada.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.cRetirada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cRetirada.FormattingEnabled = true;
            this.cRetirada.Location = new System.Drawing.Point(135, 437);
            this.cRetirada.Name = "cRetirada";
            this.cRetirada.Size = new System.Drawing.Size(348, 21);
            this.cRetirada.TabIndex = 50;
            this.cRetirada.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(671, 437);
            this.textQuantidade.Multiline = true;
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(337, 30);
            this.textQuantidade.TabIndex = 52;
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Transparent;
            this.bVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVoltar.BackgroundImage")));
            this.bVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVoltar.FlatAppearance.BorderSize = 0;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Location = new System.Drawing.Point(671, 635);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(169, 60);
            this.bVoltar.TabIndex = 74;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // mHorárioÓbito
            // 
            this.mHorárioÓbito.Location = new System.Drawing.Point(715, 301);
            this.mHorárioÓbito.Mask = "00:00";
            this.mHorárioÓbito.Name = "mHorárioÓbito";
            this.mHorárioÓbito.Size = new System.Drawing.Size(217, 20);
            this.mHorárioÓbito.TabIndex = 80;
            this.mHorárioÓbito.ValidatingType = typeof(System.DateTime);
            this.mHorárioÓbito.Click += new System.EventHandler(this.mHorárioÓbito_Click);
            // 
            // mDataObito
            // 
            this.mDataObito.Location = new System.Drawing.Point(189, 292);
            this.mDataObito.Mask = "00/00/0000";
            this.mDataObito.Name = "mDataObito";
            this.mDataObito.Size = new System.Drawing.Size(294, 20);
            this.mDataObito.TabIndex = 79;
            this.mDataObito.ValidatingType = typeof(System.DateTime);
            this.mDataObito.Click += new System.EventHandler(this.mDataObito_Click);
            // 
            // mHorarioRetirada
            // 
            this.mHorarioRetirada.Location = new System.Drawing.Point(740, 261);
            this.mHorarioRetirada.Mask = "00:00";
            this.mHorarioRetirada.Name = "mHorarioRetirada";
            this.mHorarioRetirada.Size = new System.Drawing.Size(192, 20);
            this.mHorarioRetirada.TabIndex = 76;
            this.mHorarioRetirada.ValidatingType = typeof(System.DateTime);
            this.mHorarioRetirada.Click += new System.EventHandler(this.mHorarioRetirada_Click);
            // 
            // cLegista
            // 
            this.cLegista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cLegista.FormattingEnabled = true;
            this.cLegista.Location = new System.Drawing.Point(127, 349);
            this.cLegista.Name = "cLegista";
            this.cLegista.Size = new System.Drawing.Size(356, 21);
            this.cLegista.TabIndex = 98;
            // 
            // cAssistente
            // 
            this.cAssistente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cAssistente.FormattingEnabled = true;
            this.cAssistente.Location = new System.Drawing.Point(153, 392);
            this.cAssistente.Name = "cAssistente";
            this.cAssistente.Size = new System.Drawing.Size(330, 21);
            this.cAssistente.TabIndex = 97;
            // 
            // cMaterial
            // 
            this.cMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cMaterial.FormattingEnabled = true;
            this.cMaterial.Location = new System.Drawing.Point(626, 392);
            this.cMaterial.Name = "cMaterial";
            this.cMaterial.Size = new System.Drawing.Size(382, 21);
            this.cMaterial.TabIndex = 96;
            // 
            // AtualizarCadaverL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 701);
            this.Controls.Add(this.cLegista);
            this.Controls.Add(this.cAssistente);
            this.Controls.Add(this.cMaterial);
            this.Controls.Add(this.mHorárioÓbito);
            this.Controls.Add(this.mDataObito);
            this.Controls.Add(this.mHorarioRetirada);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.cRetirada);
            this.Controls.Add(this.textLaudo);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textGaveta);
            this.Controls.Add(this.mHorarioChegada);
            this.Controls.Add(this.mDataRetirada);
            this.Controls.Add(this.mDataChegada);
            this.Controls.Add(this.bAtualizar);
            this.Controls.Add(this.dDados);
            this.Name = "AtualizarCadaverL";
            this.Text = "AtualizarCadaverT";
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textGaveta;
        private System.Windows.Forms.MaskedTextBox mHorarioChegada;
        private System.Windows.Forms.MaskedTextBox mDataRetirada;
        private System.Windows.Forms.MaskedTextBox mDataChegada;
        private System.Windows.Forms.Button bAtualizar;
        private System.Windows.Forms.DataGridView dDados;
        private System.Windows.Forms.RichTextBox textLaudo;
        private System.Windows.Forms.ComboBox cRetirada;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.MaskedTextBox mHorárioÓbito;
        private System.Windows.Forms.MaskedTextBox mDataObito;
        private System.Windows.Forms.MaskedTextBox mHorarioRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRetirada;
        private System.Windows.Forms.ComboBox cLegista;
        private System.Windows.Forms.ComboBox cAssistente;
        private System.Windows.Forms.ComboBox cMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gaveta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assistente;
    }
}