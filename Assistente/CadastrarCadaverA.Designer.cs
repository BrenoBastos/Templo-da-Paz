
namespace WindowsFormsApp1
{
    partial class CadastrarCadaverA
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
            this.bCadastrar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textGaveta = new System.Windows.Forms.TextBox();
            this.mHorarioChegada = new System.Windows.Forms.MaskedTextBox();
            this.mDataChegada = new System.Windows.Forms.MaskedTextBox();
            this.Gaveta = new System.Windows.Forms.Label();
            this.Horario = new System.Windows.Forms.Label();
            this.DataCheg = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.textAssistente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCadastrar
            // 
            this.bCadastrar.Location = new System.Drawing.Point(278, 296);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(163, 52);
            this.bCadastrar.TabIndex = 0;
            this.bCadastrar.Text = "Cadastrar";
            this.bCadastrar.UseVisualStyleBackColor = true;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(83, 73);
            this.textNome.MaximumSize = new System.Drawing.Size(100, 100);
            this.textNome.MinimumSize = new System.Drawing.Size(20, 20);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 57;
            // 
            // textGaveta
            // 
            this.textGaveta.Location = new System.Drawing.Point(83, 164);
            this.textGaveta.MaximumSize = new System.Drawing.Size(100, 100);
            this.textGaveta.MinimumSize = new System.Drawing.Size(20, 20);
            this.textGaveta.Name = "textGaveta";
            this.textGaveta.Size = new System.Drawing.Size(100, 20);
            this.textGaveta.TabIndex = 55;
            // 
            // mHorarioChegada
            // 
            this.mHorarioChegada.Location = new System.Drawing.Point(647, 111);
            this.mHorarioChegada.Mask = "00:00";
            this.mHorarioChegada.Name = "mHorarioChegada";
            this.mHorarioChegada.Size = new System.Drawing.Size(100, 20);
            this.mHorarioChegada.TabIndex = 54;
            this.mHorarioChegada.ValidatingType = typeof(System.DateTime);
            this.mHorarioChegada.Click += new System.EventHandler(this.mHorarioChegada_Click);
            // 
            // mDataChegada
            // 
            this.mDataChegada.Location = new System.Drawing.Point(627, 77);
            this.mDataChegada.Mask = "00/00/0000";
            this.mDataChegada.Name = "mDataChegada";
            this.mDataChegada.Size = new System.Drawing.Size(100, 20);
            this.mDataChegada.TabIndex = 53;
            this.mDataChegada.ValidatingType = typeof(System.DateTime);
            this.mDataChegada.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.mDataChegada.Click += new System.EventHandler(this.mDataChegada_Click);
            // 
            // Gaveta
            // 
            this.Gaveta.AutoSize = true;
            this.Gaveta.Location = new System.Drawing.Point(18, 171);
            this.Gaveta.Name = "Gaveta";
            this.Gaveta.Size = new System.Drawing.Size(42, 13);
            this.Gaveta.TabIndex = 52;
            this.Gaveta.Text = "Gaveta";
            // 
            // Horario
            // 
            this.Horario.AutoSize = true;
            this.Horario.Location = new System.Drawing.Point(517, 115);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(86, 13);
            this.Horario.TabIndex = 51;
            this.Horario.Text = "Horário chegada";
            // 
            // DataCheg
            // 
            this.DataCheg.AutoSize = true;
            this.DataCheg.Location = new System.Drawing.Point(517, 80);
            this.DataCheg.Name = "DataCheg";
            this.DataCheg.Size = new System.Drawing.Size(75, 13);
            this.DataCheg.TabIndex = 50;
            this.DataCheg.Text = "Data chegada";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(42, 73);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 48;
            this.Nome.Text = "Nome";
            // 
            // textAssistente
            // 
            this.textAssistente.Location = new System.Drawing.Point(139, 218);
            this.textAssistente.MaximumSize = new System.Drawing.Size(100, 100);
            this.textAssistente.MinimumSize = new System.Drawing.Size(20, 20);
            this.textAssistente.Name = "textAssistente";
            this.textAssistente.Size = new System.Drawing.Size(100, 20);
            this.textAssistente.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Assistente";
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(139, 296);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 72;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // CadastrarCadaverA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.textAssistente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textGaveta);
            this.Controls.Add(this.mHorarioChegada);
            this.Controls.Add(this.mDataChegada);
            this.Controls.Add(this.Gaveta);
            this.Controls.Add(this.Horario);
            this.Controls.Add(this.DataCheg);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.bCadastrar);
            this.Name = "CadastrarCadaverA";
            this.Text = "CadastrarCadaverA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCadastrar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textGaveta;
        private System.Windows.Forms.MaskedTextBox mHorarioChegada;
        private System.Windows.Forms.MaskedTextBox mDataChegada;
        private System.Windows.Forms.Label Gaveta;
        private System.Windows.Forms.Label Horario;
        private System.Windows.Forms.Label DataCheg;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox textAssistente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bVoltar;
    }
}