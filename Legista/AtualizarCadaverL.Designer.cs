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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Gaveta = new System.Windows.Forms.Label();
            this.Retirada = new System.Windows.Forms.Label();
            this.Datare = new System.Windows.Forms.Label();
            this.Horario = new System.Windows.Forms.Label();
            this.DataCheg = new System.Windows.Forms.Label();
            this.Laudo = new System.Windows.Forms.Label();
            this.Material = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.bAtualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.NomeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GavetaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataChegadaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorariChegadaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Espera",
            "IML",
            "Funerária"});
            this.comboBox1.Location = new System.Drawing.Point(662, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 48;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(83, 49);
            this.textBox6.MaximumSize = new System.Drawing.Size(100, 100);
            this.textBox6.MinimumSize = new System.Drawing.Size(20, 20);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 47;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(83, 84);
            this.textBox5.MaximumSize = new System.Drawing.Size(100, 100);
            this.textBox5.MinimumSize = new System.Drawing.Size(20, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 46;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 140);
            this.textBox4.MaximumSize = new System.Drawing.Size(100, 100);
            this.textBox4.MinimumSize = new System.Drawing.Size(20, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 45;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(647, 87);
            this.maskedTextBox3.Mask = "00:00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 40;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(671, 137);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 39;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(627, 53);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 38;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
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
            this.Retirada.Location = new System.Drawing.Point(546, 184);
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
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Location = new System.Drawing.Point(276, 204);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(44, 13);
            this.Material.TabIndex = 29;
            this.Material.Text = "Material";
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeD,
            this.IDData,
            this.GavetaData,
            this.DataChegadaData,
            this.HorariChegadaData});
            this.dataGridView1.Location = new System.Drawing.Point(65, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 128);
            this.dataGridView1.TabIndex = 25;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(340, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 49;
            this.richTextBox1.Text = "";
            // 
            // comboBox2
            // 
            this.comboBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(627, 184);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 21);
            this.comboBox2.TabIndex = 50;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(340, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 51;
            // 
            // AtualizarCadaverT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "AtualizarCadaverT";
            this.Text = "AtualizarCadaverT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label Gaveta;
        private System.Windows.Forms.Label Retirada;
        private System.Windows.Forms.Label Datare;
        private System.Windows.Forms.Label Horario;
        private System.Windows.Forms.Label DataCheg;
        private System.Windows.Forms.Label Laudo;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button bAtualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDData;
        private System.Windows.Forms.DataGridViewTextBoxColumn GavetaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataChegadaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorariChegadaData;
        private System.Windows.Forms.ListBox listBox1;
    }
}