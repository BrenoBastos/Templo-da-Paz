
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCadaverA));
            this.bCadastrar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textGaveta = new System.Windows.Forms.TextBox();
            this.mHorarioChegada = new System.Windows.Forms.MaskedTextBox();
            this.mDataChegada = new System.Windows.Forms.MaskedTextBox();
            this.bVoltar = new System.Windows.Forms.Button();
            this.cAssistente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bCadastrar
            // 
            this.bCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.bCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCadastrar.BackgroundImage")));
            this.bCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bCadastrar.FlatAppearance.BorderSize = 0;
            this.bCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCadastrar.Location = new System.Drawing.Point(764, 360);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(232, 78);
            this.bCadastrar.TabIndex = 0;
            this.bCadastrar.UseVisualStyleBackColor = false;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(330, 205);
            this.textNome.MaximumSize = new System.Drawing.Size(400, 100);
            this.textNome.MinimumSize = new System.Drawing.Size(20, 20);
            this.textNome.Multiline = true;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(400, 30);
            this.textNome.TabIndex = 57;
            // 
            // textGaveta
            // 
            this.textGaveta.Location = new System.Drawing.Point(659, 299);
            this.textGaveta.MaximumSize = new System.Drawing.Size(100, 100);
            this.textGaveta.MinimumSize = new System.Drawing.Size(20, 20);
            this.textGaveta.Multiline = true;
            this.textGaveta.Name = "textGaveta";
            this.textGaveta.Size = new System.Drawing.Size(100, 30);
            this.textGaveta.TabIndex = 55;
            // 
            // mHorarioChegada
            // 
            this.mHorarioChegada.Location = new System.Drawing.Point(375, 300);
            this.mHorarioChegada.Mask = "00:00";
            this.mHorarioChegada.Name = "mHorarioChegada";
            this.mHorarioChegada.Size = new System.Drawing.Size(144, 20);
            this.mHorarioChegada.TabIndex = 54;
            this.mHorarioChegada.ValidatingType = typeof(System.DateTime);
            this.mHorarioChegada.Click += new System.EventHandler(this.mHorarioChegada_Click);
            // 
            // mDataChegada
            // 
            this.mDataChegada.Location = new System.Drawing.Point(354, 250);
            this.mDataChegada.Mask = "00/00/0000";
            this.mDataChegada.Name = "mDataChegada";
            this.mDataChegada.Size = new System.Drawing.Size(152, 20);
            this.mDataChegada.TabIndex = 53;
            this.mDataChegada.ValidatingType = typeof(System.DateTime);
            this.mDataChegada.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.mDataChegada.Click += new System.EventHandler(this.mDataChegada_Click);
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Transparent;
            this.bVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVoltar.BackgroundImage")));
            this.bVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVoltar.FlatAppearance.BorderSize = 0;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Location = new System.Drawing.Point(496, 360);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(243, 75);
            this.bVoltar.TabIndex = 72;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // cAssistente
            // 
            this.cAssistente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cAssistente.FormattingEnabled = true;
            this.cAssistente.Location = new System.Drawing.Point(685, 250);
            this.cAssistente.Name = "cAssistente";
            this.cAssistente.Size = new System.Drawing.Size(288, 21);
            this.cAssistente.TabIndex = 98;
            // 
            // CadastrarCadaverA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.cAssistente);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textGaveta);
            this.Controls.Add(this.mHorarioChegada);
            this.Controls.Add(this.mDataChegada);
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
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.ComboBox cAssistente;
    }
}