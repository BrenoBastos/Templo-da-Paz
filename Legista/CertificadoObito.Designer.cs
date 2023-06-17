
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertificadoObito));
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
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.textMês = new System.Windows.Forms.TextBox();
            this.textDia = new System.Windows.Forms.TextBox();
            this.textAverbacoes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bBaixar
            // 
            this.bBaixar.Location = new System.Drawing.Point(139, 673);
            this.bBaixar.Name = "bBaixar";
            this.bBaixar.Size = new System.Drawing.Size(199, 62);
            this.bBaixar.TabIndex = 23;
            this.bBaixar.Text = "Baixar";
            this.bBaixar.UseVisualStyleBackColor = true;
            this.bBaixar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNomeMedico
            // 
            this.textNomeMedico.Location = new System.Drawing.Point(68, 541);
            this.textNomeMedico.Name = "textNomeMedico";
            this.textNomeMedico.Size = new System.Drawing.Size(881, 20);
            this.textNomeMedico.TabIndex = 85;
            // 
            // textAnotacoes
            // 
            this.textAnotacoes.Location = new System.Drawing.Point(68, 638);
            this.textAnotacoes.Name = "textAnotacoes";
            this.textAnotacoes.Size = new System.Drawing.Size(100, 20);
            this.textAnotacoes.TabIndex = 86;
            // 
            // textSepultamento
            // 
            this.textSepultamento.Location = new System.Drawing.Point(68, 500);
            this.textSepultamento.Name = "textSepultamento";
            this.textSepultamento.Size = new System.Drawing.Size(522, 20);
            this.textSepultamento.TabIndex = 87;
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(68, 686);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 92;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // textDeclarante
            // 
            this.textDeclarante.Location = new System.Drawing.Point(619, 497);
            this.textDeclarante.Name = "textDeclarante";
            this.textDeclarante.Size = new System.Drawing.Size(330, 20);
            this.textDeclarante.TabIndex = 93;
            // 
            // textCausadaMorte
            // 
            this.textCausadaMorte.Location = new System.Drawing.Point(65, 469);
            this.textCausadaMorte.Name = "textCausadaMorte";
            this.textCausadaMorte.Size = new System.Drawing.Size(534, 20);
            this.textCausadaMorte.TabIndex = 94;
            // 
            // textDocumentoIdentificação
            // 
            this.textDocumentoIdentificação.Location = new System.Drawing.Point(458, 338);
            this.textDocumentoIdentificação.Mask = "00.000.000-0";
            this.textDocumentoIdentificação.Name = "textDocumentoIdentificação";
            this.textDocumentoIdentificação.Size = new System.Drawing.Size(274, 20);
            this.textDocumentoIdentificação.TabIndex = 95;
            this.textDocumentoIdentificação.Click += new System.EventHandler(this.textRG_Click);
            // 
            // textEstadoCivil
            // 
            this.textEstadoCivil.Location = new System.Drawing.Point(458, 308);
            this.textEstadoCivil.Name = "textEstadoCivil";
            this.textEstadoCivil.Size = new System.Drawing.Size(300, 20);
            this.textEstadoCivil.TabIndex = 96;
            // 
            // mEleitor
            // 
            this.mEleitor.Location = new System.Drawing.Point(758, 336);
            this.mEleitor.Mask = "000000000000";
            this.mEleitor.Name = "mEleitor";
            this.mEleitor.Size = new System.Drawing.Size(191, 20);
            this.mEleitor.TabIndex = 97;
            this.mEleitor.ValidatingType = typeof(System.DateTime);
            this.mEleitor.Click += new System.EventHandler(this.mEleitor_Click);
            // 
            // textLocal
            // 
            this.textLocal.Location = new System.Drawing.Point(65, 438);
            this.textLocal.Name = "textLocal";
            this.textLocal.Size = new System.Drawing.Size(881, 20);
            this.textLocal.TabIndex = 98;
            // 
            // textFiliação
            // 
            this.textFiliação.Location = new System.Drawing.Point(65, 370);
            this.textFiliação.Name = "textFiliação";
            this.textFiliação.Size = new System.Drawing.Size(881, 20);
            this.textFiliação.TabIndex = 99;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(388, 221);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(301, 20);
            this.textNome.TabIndex = 100;
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(68, 256);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(82, 20);
            this.textCpf.TabIndex = 101;
            this.textCpf.Click += new System.EventHandler(this.textCpf_Click);
            // 
            // textAno
            // 
            this.textAno.Location = new System.Drawing.Point(865, 406);
            this.textAno.Name = "textAno";
            this.textAno.Size = new System.Drawing.Size(81, 20);
            this.textAno.TabIndex = 102;
            // 
            // cSexo
            // 
            this.cSexo.FormattingEnabled = true;
            this.cSexo.Location = new System.Drawing.Point(68, 308);
            this.cSexo.Name = "cSexo";
            this.cSexo.Size = new System.Drawing.Size(121, 21);
            this.cSexo.TabIndex = 104;
            this.cSexo.SelectedIndexChanged += new System.EventHandler(this.cSexo_SelectedIndexChanged);
            // 
            // comboCor
            // 
            this.comboCor.FormattingEnabled = true;
            this.comboCor.Location = new System.Drawing.Point(242, 308);
            this.comboCor.Name = "comboCor";
            this.comboCor.Size = new System.Drawing.Size(184, 21);
            this.comboCor.TabIndex = 105;
            // 
            // textNaturalidade
            // 
            this.textNaturalidade.Location = new System.Drawing.Point(65, 340);
            this.textNaturalidade.Name = "textNaturalidade";
            this.textNaturalidade.Size = new System.Drawing.Size(361, 20);
            this.textNaturalidade.TabIndex = 106;
            // 
            // mDataFalecimento
            // 
            this.mDataFalecimento.Location = new System.Drawing.Point(65, 409);
            this.mDataFalecimento.Mask = "00/00/0000 00:00";
            this.mDataFalecimento.Name = "mDataFalecimento";
            this.mDataFalecimento.Size = new System.Drawing.Size(573, 20);
            this.mDataFalecimento.TabIndex = 109;
            this.mDataFalecimento.ValidatingType = typeof(System.DateTime);
            this.mDataFalecimento.Click += new System.EventHandler(this.mDataNascimento_Click);
            // 
            // textMatricula
            // 
            this.textMatricula.Location = new System.Drawing.Point(581, 267);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(368, 20);
            this.textMatricula.TabIndex = 111;
            // 
            // textMês
            // 
            this.textMês.Location = new System.Drawing.Point(758, 406);
            this.textMês.Name = "textMês";
            this.textMês.Size = new System.Drawing.Size(72, 20);
            this.textMês.TabIndex = 112;
            // 
            // textDia
            // 
            this.textDia.Location = new System.Drawing.Point(659, 406);
            this.textDia.Name = "textDia";
            this.textDia.Size = new System.Drawing.Size(73, 20);
            this.textDia.TabIndex = 113;
            // 
            // textAverbacoes
            // 
            this.textAverbacoes.Location = new System.Drawing.Point(68, 582);
            this.textAverbacoes.Name = "textAverbacoes";
            this.textAverbacoes.Size = new System.Drawing.Size(881, 20);
            this.textAverbacoes.TabIndex = 118;
            // 
            // CertificadoObito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 721);
            this.Controls.Add(this.textAverbacoes);
            this.Controls.Add(this.textDia);
            this.Controls.Add(this.textMês);
            this.Controls.Add(this.textMatricula);
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
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.TextBox textMês;
        private System.Windows.Forms.TextBox textDia;
        private System.Windows.Forms.TextBox textAverbacoes;
    }
}