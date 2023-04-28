
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Gaveta = new System.Windows.Forms.Label();
            this.Horario = new System.Windows.Forms.Label();
            this.DataCheg = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
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
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(83, 73);
            this.textBox6.MaximumSize = new System.Drawing.Size(100, 100);
            this.textBox6.MinimumSize = new System.Drawing.Size(20, 20);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 57;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(83, 108);
            this.textBox5.MaximumSize = new System.Drawing.Size(100, 100);
            this.textBox5.MinimumSize = new System.Drawing.Size(20, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 56;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 164);
            this.textBox4.MaximumSize = new System.Drawing.Size(100, 100);
            this.textBox4.MinimumSize = new System.Drawing.Size(20, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 55;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(647, 111);
            this.maskedTextBox3.Mask = "00:00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 54;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(627, 77);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 53;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
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
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(42, 108);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 49;
            this.ID.Text = "ID";
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
            // CadastrarCadaverA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Gaveta);
            this.Controls.Add(this.Horario);
            this.Controls.Add(this.DataCheg);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.bCadastrar);
            this.Name = "CadastrarCadaverA";
            this.Text = "CadastrarCadaverA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCadastrar;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label Gaveta;
        private System.Windows.Forms.Label Horario;
        private System.Windows.Forms.Label DataCheg;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nome;
    }
}