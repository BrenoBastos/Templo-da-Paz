
namespace WindowsFormsApp1
{
    partial class AlterarCadaverA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarCadaverA));
            this.textNome = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textGaveta = new System.Windows.Forms.TextBox();
            this.mHorarioChegada = new System.Windows.Forms.MaskedTextBox();
            this.mDataChegada = new System.Windows.Forms.MaskedTextBox();
            this.bAlterar = new System.Windows.Forms.Button();
            this.bVoltar = new System.Windows.Forms.Button();
            this.cAssistente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(127, 133);
            this.textNome.MaximumSize = new System.Drawing.Size(400, 200);
            this.textNome.MinimumSize = new System.Drawing.Size(20, 20);
            this.textNome.Multiline = true;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(400, 30);
            this.textNome.TabIndex = 68;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(608, 135);
            this.textID.MaximumSize = new System.Drawing.Size(400, 400);
            this.textID.MinimumSize = new System.Drawing.Size(20, 20);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(400, 30);
            this.textID.TabIndex = 67;
            // 
            // textGaveta
            // 
            this.textGaveta.Location = new System.Drawing.Point(668, 290);
            this.textGaveta.MaximumSize = new System.Drawing.Size(400, 400);
            this.textGaveta.MinimumSize = new System.Drawing.Size(20, 20);
            this.textGaveta.Multiline = true;
            this.textGaveta.Name = "textGaveta";
            this.textGaveta.Size = new System.Drawing.Size(340, 30);
            this.textGaveta.TabIndex = 66;
            // 
            // mHorarioChegada
            // 
            this.mHorarioChegada.Location = new System.Drawing.Point(247, 287);
            this.mHorarioChegada.Mask = "00:00";
            this.mHorarioChegada.Name = "mHorarioChegada";
            this.mHorarioChegada.Size = new System.Drawing.Size(280, 20);
            this.mHorarioChegada.TabIndex = 65;
            this.mHorarioChegada.ValidatingType = typeof(System.DateTime);
            this.mHorarioChegada.Click += new System.EventHandler(this.mHorarioChegada_Click);
            // 
            // mDataChegada
            // 
            this.mDataChegada.Location = new System.Drawing.Point(247, 205);
            this.mDataChegada.Mask = "00/00/0000";
            this.mDataChegada.Name = "mDataChegada";
            this.mDataChegada.Size = new System.Drawing.Size(280, 20);
            this.mDataChegada.TabIndex = 64;
            this.mDataChegada.ValidatingType = typeof(System.DateTime);
            this.mDataChegada.Click += new System.EventHandler(this.mDataChegada_Click);
            // 
            // bAlterar
            // 
            this.bAlterar.BackColor = System.Drawing.Color.Transparent;
            this.bAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAlterar.BackgroundImage")));
            this.bAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bAlterar.FlatAppearance.BorderSize = 0;
            this.bAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAlterar.Location = new System.Drawing.Point(833, 377);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(185, 63);
            this.bAlterar.TabIndex = 58;
            this.bAlterar.UseVisualStyleBackColor = false;
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Transparent;
            this.bVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVoltar.BackgroundImage")));
            this.bVoltar.FlatAppearance.BorderSize = 0;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Location = new System.Drawing.Point(655, 377);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(172, 63);
            this.bVoltar.TabIndex = 71;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // cAssistente
            // 
            this.cAssistente.FormattingEnabled = true;
            this.cAssistente.Location = new System.Drawing.Point(696, 205);
            this.cAssistente.Name = "cAssistente";
            this.cAssistente.Size = new System.Drawing.Size(312, 21);
            this.cAssistente.TabIndex = 72;
            // 
            // AlterarCadaverA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 441);
            this.Controls.Add(this.cAssistente);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textGaveta);
            this.Controls.Add(this.mHorarioChegada);
            this.Controls.Add(this.mDataChegada);
            this.Controls.Add(this.bAlterar);
            this.Name = "AlterarCadaverA";
            this.Text = "AlterarCadaverA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textGaveta;
        private System.Windows.Forms.MaskedTextBox mHorarioChegada;
        private System.Windows.Forms.MaskedTextBox mDataChegada;
        private System.Windows.Forms.Button bAlterar;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.ComboBox cAssistente;
    }
}