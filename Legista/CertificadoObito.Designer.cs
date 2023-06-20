
namespace WindowsFormsApp1
{
    partial class CertificadoObito
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
            this.bBaixar = new System.Windows.Forms.Button();
            this.textNomeMedico = new System.Windows.Forms.TextBox();
            this.textAnotacoes = new System.Windows.Forms.TextBox();
            this.textSepultamento = new System.Windows.Forms.TextBox();
            this.bVoltar = new System.Windows.Forms.Button();
            this.textDeclarante = new System.Windows.Forms.TextBox();
            this.textCausadaMorte = new System.Windows.Forms.TextBox();
            this.textDocumentoIdentificação = new System.Windows.Forms.MaskedTextBox();
            this.textEstadoCivil = new System.Windows.Forms.TextBox();
            this.mEleitor = new System.Windows.Forms.MaskedTextBox();
            this.textLocal = new System.Windows.Forms.TextBox();
            this.textFiliação = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.textAno = new System.Windows.Forms.TextBox();
            this.cSexo = new System.Windows.Forms.ComboBox();
            this.comboCor = new System.Windows.Forms.ComboBox();
            this.textNaturalidade = new System.Windows.Forms.TextBox();
            this.mDataFalecimento = new System.Windows.Forms.MaskedTextBox();
            this.textMês = new System.Windows.Forms.TextBox();
            this.textDia = new System.Windows.Forms.TextBox();
            this.textAverbacoes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bBaixar
            // 
            this.bBaixar.Location = new System.Drawing.Point(424, 697);
            this.bBaixar.Name = "bBaixar";
            this.bBaixar.Size = new System.Drawing.Size(199, 24);
            this.bBaixar.TabIndex = 23;
            this.bBaixar.Text = "Baixar";
            this.bBaixar.UseVisualStyleBackColor = true;
            this.bBaixar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNomeMedico
            // 
            this.textNomeMedico.Location = new System.Drawing.Point(39, 566);
            this.textNomeMedico.Name = "textNomeMedico";
            this.textNomeMedico.Size = new System.Drawing.Size(524, 20);
            this.textNomeMedico.TabIndex = 85;
            // 
            // textAnotacoes
            // 
            this.textAnotacoes.Location = new System.Drawing.Point(39, 651);
            this.textAnotacoes.Multiline = true;
            this.textAnotacoes.Name = "textAnotacoes";
            this.textAnotacoes.Size = new System.Drawing.Size(524, 27);
            this.textAnotacoes.TabIndex = 86;
            // 
            // textSepultamento
            // 
            this.textSepultamento.Location = new System.Drawing.Point(39, 524);
            this.textSepultamento.Name = "textSepultamento";
            this.textSepultamento.Size = new System.Drawing.Size(312, 20);
            this.textSepultamento.TabIndex = 87;
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(336, 698);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 92;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // textDeclarante
            // 
            this.textDeclarante.Location = new System.Drawing.Point(376, 524);
            this.textDeclarante.Name = "textDeclarante";
            this.textDeclarante.Size = new System.Drawing.Size(197, 20);
            this.textDeclarante.TabIndex = 93;
            // 
            // textCausadaMorte
            // 
            this.textCausadaMorte.Location = new System.Drawing.Point(39, 480);
            this.textCausadaMorte.Name = "textCausadaMorte";
            this.textCausadaMorte.Size = new System.Drawing.Size(524, 20);
            this.textCausadaMorte.TabIndex = 94;
            // 
            // textDocumentoIdentificação
            // 
            this.textDocumentoIdentificação.Location = new System.Drawing.Point(39, 347);
            this.textDocumentoIdentificação.Mask = "00.000.000-0";
            this.textDocumentoIdentificação.Name = "textDocumentoIdentificação";
            this.textDocumentoIdentificação.Size = new System.Drawing.Size(164, 20);
            this.textDocumentoIdentificação.TabIndex = 95;
            this.textDocumentoIdentificação.Click += new System.EventHandler(this.textRG_Click);
            // 
            // textEstadoCivil
            // 
            this.textEstadoCivil.Location = new System.Drawing.Point(39, 306);
            this.textEstadoCivil.Name = "textEstadoCivil";
            this.textEstadoCivil.Size = new System.Drawing.Size(224, 20);
            this.textEstadoCivil.TabIndex = 96;
            // 
            // mEleitor
            // 
            this.mEleitor.Location = new System.Drawing.Point(235, 345);
            this.mEleitor.Mask = "000000000000";
            this.mEleitor.Name = "mEleitor";
            this.mEleitor.Size = new System.Drawing.Size(116, 20);
            this.mEleitor.TabIndex = 97;
            this.mEleitor.ValidatingType = typeof(System.DateTime);
            this.mEleitor.Click += new System.EventHandler(this.mEleitor_Click);
            // 
            // textLocal
            // 
            this.textLocal.Location = new System.Drawing.Point(39, 441);
            this.textLocal.Name = "textLocal";
            this.textLocal.Size = new System.Drawing.Size(524, 20);
            this.textLocal.TabIndex = 98;
            // 
            // textFiliação
            // 
            this.textFiliação.Location = new System.Drawing.Point(366, 345);
            this.textFiliação.Name = "textFiliação";
            this.textFiliação.Size = new System.Drawing.Size(524, 20);
            this.textFiliação.TabIndex = 99;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(166, 189);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(301, 20);
            this.textNome.TabIndex = 100;
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(39, 252);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(82, 20);
            this.textCpf.TabIndex = 101;
            this.textCpf.Click += new System.EventHandler(this.textCpf_Click);
            // 
            // textAno
            // 
            this.textAno.Location = new System.Drawing.Point(509, 402);
            this.textAno.Name = "textAno";
            this.textAno.Size = new System.Drawing.Size(54, 20);
            this.textAno.TabIndex = 102;
            // 
            // cSexo
            // 
            this.cSexo.FormattingEnabled = true;
            this.cSexo.Location = new System.Drawing.Point(171, 251);
            this.cSexo.Name = "cSexo";
            this.cSexo.Size = new System.Drawing.Size(92, 21);
            this.cSexo.TabIndex = 104;
            this.cSexo.SelectedIndexChanged += new System.EventHandler(this.cSexo_SelectedIndexChanged);
            // 
            // comboCor
            // 
            this.comboCor.FormattingEnabled = true;
            this.comboCor.Location = new System.Drawing.Point(325, 252);
            this.comboCor.Name = "comboCor";
            this.comboCor.Size = new System.Drawing.Size(117, 21);
            this.comboCor.TabIndex = 105;
            this.comboCor.SelectedIndexChanged += new System.EventHandler(this.comboCor_SelectedIndexChanged);
            // 
            // textNaturalidade
            // 
            this.textNaturalidade.Location = new System.Drawing.Point(325, 306);
            this.textNaturalidade.Name = "textNaturalidade";
            this.textNaturalidade.Size = new System.Drawing.Size(213, 20);
            this.textNaturalidade.TabIndex = 106;
            // 
            // mDataFalecimento
            // 
            this.mDataFalecimento.Location = new System.Drawing.Point(39, 402);
            this.mDataFalecimento.Mask = "00/00/0000 00:00";
            this.mDataFalecimento.Name = "mDataFalecimento";
            this.mDataFalecimento.Size = new System.Drawing.Size(341, 20);
            this.mDataFalecimento.TabIndex = 109;
            this.mDataFalecimento.ValidatingType = typeof(System.DateTime);
            this.mDataFalecimento.Click += new System.EventHandler(this.mDataNascimento_Click);
            // 
            // textMês
            // 
            this.textMês.Location = new System.Drawing.Point(443, 401);
            this.textMês.Name = "textMês";
            this.textMês.Size = new System.Drawing.Size(43, 20);
            this.textMês.TabIndex = 112;
            // 
            // textDia
            // 
            this.textDia.Location = new System.Drawing.Point(386, 402);
            this.textDia.Name = "textDia";
            this.textDia.Size = new System.Drawing.Size(47, 20);
            this.textDia.TabIndex = 113;
            // 
            // textAverbacoes
            // 
            this.textAverbacoes.Location = new System.Drawing.Point(39, 607);
            this.textAverbacoes.Name = "textAverbacoes";
            this.textAverbacoes.Size = new System.Drawing.Size(524, 20);
            this.textAverbacoes.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 119;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 120;
            this.label2.Text = "Declarante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 13);
            this.label3.TabIndex = 121;
            this.label3.Text = "Sepultamento/Cremação(Município e Cemitério,se Conhecido)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "Averbações/Anotações à Acrescer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 635);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 123;
            this.label5.Text = "Anotações de Cadastro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 124;
            this.label6.Text = "Data e Hora de Falecimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "Mês";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 126;
            this.label8.Text = "Dia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 127;
            this.label9.Text = "Documento de Identificação";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 128;
            this.label10.Text = "Causa da Morte";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 550);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(307, 13);
            this.label11.TabIndex = 129;
            this.label11.Text = "Nome e Número de Documento do Médico que Atestou o Óbito";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(322, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 130;
            this.label12.Text = "Naturalidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 425);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 131;
            this.label13.Text = "Local de Falecimento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(506, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 132;
            this.label14.Text = "Ano";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(363, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 133;
            this.label15.Text = "Filiação e Residência";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(232, 329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 134;
            this.label16.Text = "Título de Eleitor";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 135;
            this.label17.Text = "Estado Civil e Idade";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(322, 236);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 136;
            this.label18.Text = "Cor";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(172, 235);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 137;
            this.label19.Text = "Sexo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 235);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 138;
            this.label20.Text = "CPF";
            // 
            // CertificadoObito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 731);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAverbacoes);
            this.Controls.Add(this.textDia);
            this.Controls.Add(this.textMês);
            this.Controls.Add(this.mDataFalecimento);
            this.Controls.Add(this.textNaturalidade);
            this.Controls.Add(this.comboCor);
            this.Controls.Add(this.cSexo);
            this.Controls.Add(this.textAno);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textFiliação);
            this.Controls.Add(this.textLocal);
            this.Controls.Add(this.mEleitor);
            this.Controls.Add(this.textEstadoCivil);
            this.Controls.Add(this.textDocumentoIdentificação);
            this.Controls.Add(this.textCausadaMorte);
            this.Controls.Add(this.textDeclarante);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.textSepultamento);
            this.Controls.Add(this.textAnotacoes);
            this.Controls.Add(this.textNomeMedico);
            this.Controls.Add(this.bBaixar);
            this.Name = "CertificadoObito";
            this.Text = "CertificadoObito";
            this.Load += new System.EventHandler(this.CertificadoObito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bBaixar;
        private System.Windows.Forms.TextBox textNomeMedico;
        private System.Windows.Forms.TextBox textAnotacoes;
        private System.Windows.Forms.TextBox textSepultamento;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.TextBox textDeclarante;
        private System.Windows.Forms.TextBox textCausadaMorte;
        private System.Windows.Forms.MaskedTextBox textDocumentoIdentificação;
        private System.Windows.Forms.TextBox textEstadoCivil;
        private System.Windows.Forms.MaskedTextBox mEleitor;
        private System.Windows.Forms.TextBox textLocal;
        private System.Windows.Forms.TextBox textFiliação;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.TextBox textAno;
        private System.Windows.Forms.ComboBox cSexo;
        private System.Windows.Forms.ComboBox comboCor;
        private System.Windows.Forms.TextBox textNaturalidade;
        private System.Windows.Forms.MaskedTextBox mDataFalecimento;
        private System.Windows.Forms.TextBox textMês;
        private System.Windows.Forms.TextBox textDia;
        private System.Windows.Forms.TextBox textAverbacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}