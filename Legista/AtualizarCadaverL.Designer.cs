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
            this.asdd = new System.Windows.Forms.Label();
            this.kjty = new System.Windows.Forms.Label();
            this.hgff = new System.Windows.Forms.Label();
            this.hgfgf = new System.Windows.Forms.Label();
            this.adf = new System.Windows.Forms.Label();
            this.asddd = new System.Windows.Forms.Label();
            this.ysd = new System.Windows.Forms.Label();
            this.ads = new System.Windows.Forms.Label();
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
            this.fgd = new System.Windows.Forms.Label();
            this.dfd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bVoltar = new System.Windows.Forms.Button();
            this.dasdas = new System.Windows.Forms.Label();
            this.mHorárioÓbito = new System.Windows.Forms.MaskedTextBox();
            this.mDataObito = new System.Windows.Forms.MaskedTextBox();
            this.jary = new System.Windows.Forms.Label();
            this.ku = new System.Windows.Forms.Label();
            this.mHorarioRetirada = new System.Windows.Forms.MaskedTextBox();
            this.cLegista = new System.Windows.Forms.ComboBox();
            this.cAssistente = new System.Windows.Forms.ComboBox();
            this.cMaterial = new System.Windows.Forms.ComboBox();
            this.btnMateriais = new System.Windows.Forms.Button();
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
            this.textID.ReadOnly = true;
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
            // asdd
            // 
            this.asdd.AutoSize = true;
            this.asdd.Location = new System.Drawing.Point(18, 147);
            this.asdd.Name = "asdd";
            this.asdd.Size = new System.Drawing.Size(42, 13);
            this.asdd.TabIndex = 37;
            this.asdd.Text = "Gaveta";
            // 
            // kjty
            // 
            this.kjty.AutoSize = true;
            this.kjty.Location = new System.Drawing.Point(556, 268);
            this.kjty.Name = "kjty";
            this.kjty.Size = new System.Drawing.Size(47, 13);
            this.kjty.TabIndex = 36;
            this.kjty.Text = "Retirada";
            // 
            // hgff
            // 
            this.hgff.AutoSize = true;
            this.hgff.Location = new System.Drawing.Point(546, 140);
            this.hgff.Name = "hgff";
            this.hgff.Size = new System.Drawing.Size(68, 13);
            this.hgff.TabIndex = 35;
            this.hgff.Text = "Data retirada";
            // 
            // hgfgf
            // 
            this.hgfgf.AutoSize = true;
            this.hgfgf.Location = new System.Drawing.Point(517, 91);
            this.hgfgf.Name = "hgfgf";
            this.hgfgf.Size = new System.Drawing.Size(86, 13);
            this.hgfgf.TabIndex = 34;
            this.hgfgf.Text = "Horário chegada";
            // 
            // adf
            // 
            this.adf.AutoSize = true;
            this.adf.Location = new System.Drawing.Point(517, 56);
            this.adf.Name = "adf";
            this.adf.Size = new System.Drawing.Size(75, 13);
            this.adf.TabIndex = 33;
            this.adf.Text = "Data chegada";
            // 
            // asddd
            // 
            this.asddd.AutoSize = true;
            this.asddd.Location = new System.Drawing.Point(283, 49);
            this.asddd.Name = "asddd";
            this.asddd.Size = new System.Drawing.Size(37, 13);
            this.asddd.TabIndex = 32;
            this.asddd.Text = "Laudo";
            // 
            // ysd
            // 
            this.ysd.AutoSize = true;
            this.ysd.Location = new System.Drawing.Point(42, 84);
            this.ysd.Name = "ysd";
            this.ysd.Size = new System.Drawing.Size(18, 13);
            this.ysd.TabIndex = 28;
            this.ysd.Text = "ID";
            // 
            // ads
            // 
            this.ads.AutoSize = true;
            this.ads.Location = new System.Drawing.Point(42, 49);
            this.ads.Name = "ads";
            this.ads.Size = new System.Drawing.Size(35, 13);
            this.ads.TabIndex = 27;
            this.ads.Text = "Nome";
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
            this.Nome,
            this.Id,
            this.Gaveta,
            this.DataChegada,
            this.HorarioChegada,
            this.Assistente});
            this.dDados.Location = new System.Drawing.Point(65, 322);
            this.dDados.Name = "dDados";
            this.dDados.Size = new System.Drawing.Size(647, 128);
            this.dDados.TabIndex = 25;
            this.dDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dDados_CellDoubleClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // Gaveta
            // 
            this.Gaveta.DataPropertyName = "Gaveta";
            this.Gaveta.HeaderText = "Gaveta";
            this.Gaveta.Name = "Gaveta";
            // 
            // DataChegada
            // 
            this.DataChegada.DataPropertyName = "DataChegada";
            this.DataChegada.HeaderText = "DataChegada";
            this.DataChegada.Name = "DataChegada";
            // 
            // HorarioChegada
            // 
            this.HorarioChegada.DataPropertyName = "HorarioChegada";
            this.HorarioChegada.HeaderText = "HorarioChegada";
            this.HorarioChegada.Name = "HorarioChegada";
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
            // fgd
            // 
            this.fgd.AutoSize = true;
            this.fgd.Location = new System.Drawing.Point(298, 228);
            this.fgd.Name = "fgd";
            this.fgd.Size = new System.Drawing.Size(62, 13);
            this.fgd.TabIndex = 53;
            this.fgd.Text = "Quantidade";
            // 
            // dfd
            // 
            this.dfd.AutoSize = true;
            this.dfd.Location = new System.Drawing.Point(264, 179);
            this.dfd.Name = "dfd";
            this.dfd.Size = new System.Drawing.Size(44, 13);
            this.dfd.TabIndex = 29;
            this.dfd.Text = "Material";
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
            // dasdas
            // 
            this.dasdas.AutoSize = true;
            this.dasdas.Location = new System.Drawing.Point(541, 181);
            this.dasdas.Name = "dasdas";
            this.dasdas.Size = new System.Drawing.Size(84, 13);
            this.dasdas.TabIndex = 75;
            this.dasdas.Text = "Horário Retirada";
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
            // jary
            // 
            this.jary.AutoSize = true;
            this.jary.Location = new System.Drawing.Point(561, 241);
            this.jary.Name = "jary";
            this.jary.Size = new System.Drawing.Size(69, 13);
            this.jary.TabIndex = 78;
            this.jary.Text = "Horário Óbito";
            // 
            // ku
            // 
            this.ku.AutoSize = true;
            this.ku.Location = new System.Drawing.Point(561, 206);
            this.ku.Name = "ku";
            this.ku.Size = new System.Drawing.Size(58, 13);
            this.ku.TabIndex = 77;
            this.ku.Text = "Data Óbito";
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
            // cLegista
            // 
            this.cLegista.FormattingEnabled = true;
            this.cLegista.Location = new System.Drawing.Point(136, 233);
            this.cLegista.Name = "cLegista";
            this.cLegista.Size = new System.Drawing.Size(121, 21);
            this.cLegista.TabIndex = 98;
            // 
            // cAssistente
            // 
            this.cAssistente.FormattingEnabled = true;
            this.cAssistente.Location = new System.Drawing.Point(135, 184);
            this.cAssistente.Name = "cAssistente";
            this.cAssistente.Size = new System.Drawing.Size(121, 21);
            this.cAssistente.TabIndex = 97;
            // 
            // cMaterial
            // 
            this.cMaterial.FormattingEnabled = true;
            this.cMaterial.Location = new System.Drawing.Point(362, 161);
            this.cMaterial.Name = "cMaterial";
            this.cMaterial.Size = new System.Drawing.Size(121, 21);
            this.cMaterial.TabIndex = 96;
            // 
            // btnMateriais
            // 
            this.btnMateriais.Location = new System.Drawing.Point(365, 254);
            this.btnMateriais.Name = "btnMateriais";
            this.btnMateriais.Size = new System.Drawing.Size(118, 23);
            this.btnMateriais.TabIndex = 99;
            this.btnMateriais.Text = "Atualizar materiais";
            this.btnMateriais.UseVisualStyleBackColor = true;
            this.btnMateriais.Click += new System.EventHandler(this.btnMateriais_Click);
            // 
            // AtualizarCadaverL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 563);
            this.Controls.Add(this.btnMateriais);
            this.Controls.Add(this.cLegista);
            this.Controls.Add(this.cAssistente);
            this.Controls.Add(this.cMaterial);
            this.Controls.Add(this.mHorárioÓbito);
            this.Controls.Add(this.mDataObito);
            this.Controls.Add(this.jary);
            this.Controls.Add(this.ku);
            this.Controls.Add(this.mHorarioRetirada);
            this.Controls.Add(this.dasdas);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fgd);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.cRetirada);
            this.Controls.Add(this.textLaudo);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textGaveta);
            this.Controls.Add(this.mHorarioChegada);
            this.Controls.Add(this.mDataRetirada);
            this.Controls.Add(this.mDataChegada);
            this.Controls.Add(this.asdd);
            this.Controls.Add(this.kjty);
            this.Controls.Add(this.hgff);
            this.Controls.Add(this.hgfgf);
            this.Controls.Add(this.adf);
            this.Controls.Add(this.asddd);
            this.Controls.Add(this.dfd);
            this.Controls.Add(this.ysd);
            this.Controls.Add(this.ads);
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
        private System.Windows.Forms.Label asdd;
        private System.Windows.Forms.Label kjty;
        private System.Windows.Forms.Label hgff;
        private System.Windows.Forms.Label hgfgf;
        private System.Windows.Forms.Label adf;
        private System.Windows.Forms.Label asddd;
        private System.Windows.Forms.Label ysd;
        private System.Windows.Forms.Label ads;
        private System.Windows.Forms.Button bAtualizar;
        private System.Windows.Forms.DataGridView dDados;
        private System.Windows.Forms.RichTextBox textLaudo;
        private System.Windows.Forms.ComboBox cRetirada;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.Label fgd;
        private System.Windows.Forms.Label dfd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.Label dasdas;
        private System.Windows.Forms.MaskedTextBox mHorárioÓbito;
        private System.Windows.Forms.MaskedTextBox mDataObito;
        private System.Windows.Forms.Label jary;
        private System.Windows.Forms.Label ku;
        private System.Windows.Forms.MaskedTextBox mHorarioRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gaveta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assistente;
        private System.Windows.Forms.ComboBox cLegista;
        private System.Windows.Forms.ComboBox cAssistente;
        private System.Windows.Forms.ComboBox cMaterial;
        private System.Windows.Forms.Button btnMateriais;
    }
}