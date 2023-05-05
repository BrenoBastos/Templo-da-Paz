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
            this.textNome = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textGaveta = new System.Windows.Forms.TextBox();
            this.mHorarioChegada = new System.Windows.Forms.MaskedTextBox();
            this.mDataRetirada = new System.Windows.Forms.MaskedTextBox();
            this.mDataChegada = new System.Windows.Forms.MaskedTextBox();
            this.Gaveta = new System.Windows.Forms.Label();
            this.Retirada = new System.Windows.Forms.Label();
            this.Datare = new System.Windows.Forms.Label();
            this.Horario = new System.Windows.Forms.Label();
            this.DataCheg = new System.Windows.Forms.Label();
            this.Laudo = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.bAtualizar = new System.Windows.Forms.Button();
            this.dDados = new System.Windows.Forms.DataGridView();
            this.NomeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GavetaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataChegadaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorariChegadaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAssistente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textLaudo = new System.Windows.Forms.RichTextBox();
            this.cRetirada = new System.Windows.Forms.ComboBox();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.Quantidade = new System.Windows.Forms.Label();
            this.textMaterial = new System.Windows.Forms.TextBox();
            this.Material = new System.Windows.Forms.Label();
            this.textAssistente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textLegista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bVoltar = new System.Windows.Forms.Button();
            this.HorárioRetirada = new System.Windows.Forms.Label();
            this.mHorárioÓbito = new System.Windows.Forms.MaskedTextBox();
            this.mDataObito = new System.Windows.Forms.MaskedTextBox();
            this.HorárioÓbito = new System.Windows.Forms.Label();
            this.DataÓbito = new System.Windows.Forms.Label();
            this.mHorarioRetirada = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).BeginInit();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(83, 49);
            this.textNome.MaximumSize = new System.Drawing.Size(100, 100);
            this.textNome.MinimumSize = new System.Drawing.Size(20, 20);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 47;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(83, 84);
            this.textID.MaximumSize = new System.Drawing.Size(100, 100);
            this.textID.MinimumSize = new System.Drawing.Size(20, 20);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 46;
            // 
            // textGaveta
            // 
            this.textGaveta.Location = new System.Drawing.Point(83, 140);
            this.textGaveta.MaximumSize = new System.Drawing.Size(100, 100);
            this.textGaveta.MinimumSize = new System.Drawing.Size(20, 20);
            this.textGaveta.Name = "textGaveta";
            this.textGaveta.Size = new System.Drawing.Size(100, 20);
            this.textGaveta.TabIndex = 45;
            // 
            // mHorarioChegada
            // 
            this.mHorarioChegada.Location = new System.Drawing.Point(647, 87);
            this.mHorarioChegada.Mask = "00:00";
            this.mHorarioChegada.Name = "mHorarioChegada";
            this.mHorarioChegada.Size = new System.Drawing.Size(100, 20);
            this.mHorarioChegada.TabIndex = 40;
            this.mHorarioChegada.ValidatingType = typeof(System.DateTime);
            this.mHorarioChegada.Click += new System.EventHandler(this.mHorarioChegada_Click);
            // 
            // mDataRetirada
            // 
            this.mDataRetirada.Location = new System.Drawing.Point(671, 137);
            this.mDataRetirada.Mask = "00/00/0000";
            this.mDataRetirada.Name = "mDataRetirada";
            this.mDataRetirada.Size = new System.Drawing.Size(100, 20);
            this.mDataRetirada.TabIndex = 39;
            this.mDataRetirada.ValidatingType = typeof(System.DateTime);
            this.mDataRetirada.Click += new System.EventHandler(this.mDataRetirada_Click);
            // 
            // mDataChegada
            // 
            this.mDataChegada.Location = new System.Drawing.Point(627, 53);
            this.mDataChegada.Mask = "00/00/0000";
            this.mDataChegada.Name = "mDataChegada";
            this.mDataChegada.Size = new System.Drawing.Size(100, 20);
            this.mDataChegada.TabIndex = 38;
            this.mDataChegada.ValidatingType = typeof(System.DateTime);
            this.mDataChegada.Click += new System.EventHandler(this.mDataChegada_Click);
            // 
            // Gaveta
            // 
            this.Gaveta.AutoSize = true;
            this.Gaveta.Location = new System.Drawing.Point(18, 147);
            this.Gaveta.Name = "Gaveta";
            this.Gaveta.Size = new System.Drawing.Size(42, 13);
            this.Gaveta.TabIndex = 37;
            this.Gaveta.Text = "Gaveta";
            // 
            // Retirada
            // 
            this.Retirada.AutoSize = true;
            this.Retirada.Location = new System.Drawing.Point(556, 268);
            this.Retirada.Name = "Retirada";
            this.Retirada.Size = new System.Drawing.Size(47, 13);
            this.Retirada.TabIndex = 36;
            this.Retirada.Text = "Retirada";
            // 
            // Datare
            // 
            this.Datare.AutoSize = true;
            this.Datare.Location = new System.Drawing.Point(546, 140);
            this.Datare.Name = "Datare";
            this.Datare.Size = new System.Drawing.Size(68, 13);
            this.Datare.TabIndex = 35;
            this.Datare.Text = "Data retirada";
            // 
            // Horario
            // 
            this.Horario.AutoSize = true;
            this.Horario.Location = new System.Drawing.Point(517, 91);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(86, 13);
            this.Horario.TabIndex = 34;
            this.Horario.Text = "Horário chegada";
            // 
            // DataCheg
            // 
            this.DataCheg.AutoSize = true;
            this.DataCheg.Location = new System.Drawing.Point(517, 56);
            this.DataCheg.Name = "DataCheg";
            this.DataCheg.Size = new System.Drawing.Size(75, 13);
            this.DataCheg.TabIndex = 33;
            this.DataCheg.Text = "Data chegada";
            // 
            // Laudo
            // 
            this.Laudo.AutoSize = true;
            this.Laudo.Location = new System.Drawing.Point(283, 49);
            this.Laudo.Name = "Laudo";
            this.Laudo.Size = new System.Drawing.Size(37, 13);
            this.Laudo.TabIndex = 32;
            this.Laudo.Text = "Laudo";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(42, 84);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 28;
            this.ID.Text = "ID";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(42, 49);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 27;
            this.Nome.Text = "Nome";
            // 
            // bAtualizar
            // 
            this.bAtualizar.Location = new System.Drawing.Point(365, 283);
            this.bAtualizar.Name = "bAtualizar";
            this.bAtualizar.Size = new System.Drawing.Size(75, 23);
            this.bAtualizar.TabIndex = 26;
            this.bAtualizar.Text = "Atualizar";
            this.bAtualizar.UseVisualStyleBackColor = true;
            this.bAtualizar.Click += new System.EventHandler(this.bAtualizar_Click);
            // 
            // dDados
            // 
            this.dDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeD,
            this.IDData,
            this.GavetaData,
            this.DataChegadaData,
            this.HorariChegadaData,
            this.dAssistente});
            this.dDados.Location = new System.Drawing.Point(65, 322);
            this.dDados.Name = "dDados";
            this.dDados.Size = new System.Drawing.Size(718, 128);
            this.dDados.TabIndex = 25;
            this.dDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dDados_CellDoubleClick);
            // 
            // NomeD
            // 
            this.NomeD.HeaderText = "Nome";
            this.NomeD.Name = "NomeD";
            // 
            // IDData
            // 
            this.IDData.HeaderText = "ID";
            this.IDData.Name = "IDData";
            // 
            // GavetaData
            // 
            this.GavetaData.HeaderText = "Gaveta";
            this.GavetaData.Name = "GavetaData";
            // 
            // DataChegadaData
            // 
            this.DataChegadaData.HeaderText = "DataChegada";
            this.DataChegadaData.Name = "DataChegadaData";
            // 
            // HorariChegadaData
            // 
            this.HorariChegadaData.HeaderText = "HorarioChegada";
            this.HorariChegadaData.Name = "HorariChegadaData";
            // 
            // dAssistente
            // 
            this.dAssistente.HeaderText = "Assistente";
            this.dAssistente.Name = "dAssistente";
            this.dAssistente.ReadOnly = true;
            // 
            // textLaudo
            // 
            this.textLaudo.Location = new System.Drawing.Point(340, 46);
            this.textLaudo.Name = "textLaudo";
            this.textLaudo.Size = new System.Drawing.Size(100, 96);
            this.textLaudo.TabIndex = 49;
            this.textLaudo.Text = "";
            // 
            // cRetirada
            // 
            this.cRetirada.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.cRetirada.FormattingEnabled = true;
            this.cRetirada.Location = new System.Drawing.Point(647, 268);
            this.cRetirada.Name = "cRetirada";
            this.cRetirada.Size = new System.Drawing.Size(156, 21);
            this.cRetirada.TabIndex = 50;
            this.cRetirada.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(384, 221);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textQuantidade.TabIndex = 52;
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(298, 228);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(62, 13);
            this.Quantidade.TabIndex = 53;
            this.Quantidade.Text = "Quantidade";
            // 
            // textMaterial
            // 
            this.textMaterial.Location = new System.Drawing.Point(340, 177);
            this.textMaterial.Name = "textMaterial";
            this.textMaterial.Size = new System.Drawing.Size(100, 20);
            this.textMaterial.TabIndex = 51;
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Location = new System.Drawing.Point(264, 179);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(44, 13);
            this.Material.TabIndex = 29;
            this.Material.Text = "Material";
            // 
            // textAssistente
            // 
            this.textAssistente.Location = new System.Drawing.Point(112, 184);
            this.textAssistente.MaximumSize = new System.Drawing.Size(100, 100);
            this.textAssistente.MinimumSize = new System.Drawing.Size(20, 20);
            this.textAssistente.Name = "textAssistente";
            this.textAssistente.Size = new System.Drawing.Size(100, 20);
            this.textAssistente.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Assistente";
            // 
            // textLegista
            // 
            this.textLegista.Location = new System.Drawing.Point(145, 235);
            this.textLegista.MaximumSize = new System.Drawing.Size(100, 100);
            this.textLegista.MinimumSize = new System.Drawing.Size(20, 20);
            this.textLegista.Name = "textLegista";
            this.textLegista.Size = new System.Drawing.Size(100, 20);
            this.textLegista.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Legista";
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(170, 283);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 74;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // HorárioRetirada
            // 
            this.HorárioRetirada.AutoSize = true;
            this.HorárioRetirada.Location = new System.Drawing.Point(541, 181);
            this.HorárioRetirada.Name = "HorárioRetirada";
            this.HorárioRetirada.Size = new System.Drawing.Size(84, 13);
            this.HorárioRetirada.TabIndex = 75;
            this.HorárioRetirada.Text = "Horário Retirada";
            // 
            // mHorárioÓbito
            // 
            this.mHorárioÓbito.Location = new System.Drawing.Point(691, 237);
            this.mHorárioÓbito.Mask = "00:00";
            this.mHorárioÓbito.Name = "mHorárioÓbito";
            this.mHorárioÓbito.Size = new System.Drawing.Size(100, 20);
            this.mHorárioÓbito.TabIndex = 80;
            this.mHorárioÓbito.ValidatingType = typeof(System.DateTime);
            this.mHorárioÓbito.Click += new System.EventHandler(this.mHorárioÓbito_Click);
            // 
            // mDataObito
            // 
            this.mDataObito.Location = new System.Drawing.Point(671, 203);
            this.mDataObito.Mask = "00/00/0000";
            this.mDataObito.Name = "mDataObito";
            this.mDataObito.Size = new System.Drawing.Size(100, 20);
            this.mDataObito.TabIndex = 79;
            this.mDataObito.ValidatingType = typeof(System.DateTime);
            this.mDataObito.Click += new System.EventHandler(this.mDataObito_Click);
            // 
            // HorárioÓbito
            // 
            this.HorárioÓbito.AutoSize = true;
            this.HorárioÓbito.Location = new System.Drawing.Point(561, 241);
            this.HorárioÓbito.Name = "HorárioÓbito";
            this.HorárioÓbito.Size = new System.Drawing.Size(69, 13);
            this.HorárioÓbito.TabIndex = 78;
            this.HorárioÓbito.Text = "Horário Óbito";
            // 
            // DataÓbito
            // 
            this.DataÓbito.AutoSize = true;
            this.DataÓbito.Location = new System.Drawing.Point(561, 206);
            this.DataÓbito.Name = "DataÓbito";
            this.DataÓbito.Size = new System.Drawing.Size(58, 13);
            this.DataÓbito.TabIndex = 77;
            this.DataÓbito.Text = "Data Óbito";
            // 
            // mHorarioRetirada
            // 
            this.mHorarioRetirada.Location = new System.Drawing.Point(671, 178);
            this.mHorarioRetirada.Mask = "00:00";
            this.mHorarioRetirada.Name = "mHorarioRetirada";
            this.mHorarioRetirada.Size = new System.Drawing.Size(100, 20);
            this.mHorarioRetirada.TabIndex = 76;
            this.mHorarioRetirada.ValidatingType = typeof(System.DateTime);
            this.mHorarioRetirada.Click += new System.EventHandler(this.mHorarioRetirada_Click);
            // 
            // AtualizarCadaverL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.mHorárioÓbito);
            this.Controls.Add(this.mDataObito);
            this.Controls.Add(this.HorárioÓbito);
            this.Controls.Add(this.DataÓbito);
            this.Controls.Add(this.mHorarioRetirada);
            this.Controls.Add(this.HorárioRetirada);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.textLegista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAssistente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.textMaterial);
            this.Controls.Add(this.cRetirada);
            this.Controls.Add(this.textLaudo);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textGaveta);
            this.Controls.Add(this.mHorarioChegada);
            this.Controls.Add(this.mDataRetirada);
            this.Controls.Add(this.mDataChegada);
            this.Controls.Add(this.Gaveta);
            this.Controls.Add(this.Retirada);
            this.Controls.Add(this.Datare);
            this.Controls.Add(this.Horario);
            this.Controls.Add(this.DataCheg);
            this.Controls.Add(this.Laudo);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Nome);
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
        private System.Windows.Forms.Label Gaveta;
        private System.Windows.Forms.Label Retirada;
        private System.Windows.Forms.Label Datare;
        private System.Windows.Forms.Label Horario;
        private System.Windows.Forms.Label DataCheg;
        private System.Windows.Forms.Label Laudo;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button bAtualizar;
        private System.Windows.Forms.DataGridView dDados;
        private System.Windows.Forms.RichTextBox textLaudo;
        private System.Windows.Forms.ComboBox cRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDData;
        private System.Windows.Forms.DataGridViewTextBoxColumn GavetaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataChegadaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorariChegadaData;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.TextBox textMaterial;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.TextBox textAssistente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLegista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAssistente;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.Label HorárioRetirada;
        private System.Windows.Forms.MaskedTextBox mHorárioÓbito;
        private System.Windows.Forms.MaskedTextBox mDataObito;
        private System.Windows.Forms.Label HorárioÓbito;
        private System.Windows.Forms.Label DataÓbito;
        private System.Windows.Forms.MaskedTextBox mHorarioRetirada;
    }
}