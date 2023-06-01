
namespace WindowsFormsApp1
{
    partial class DadosA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadosA));
            this.textNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bLocalizar = new System.Windows.Forms.Button();
            this.textNome1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dDados = new System.Windows.Forms.DataGridView();
            this.bVoltar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).BeginInit();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(-106, 14);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-168, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // bLocalizar
            // 
            this.bLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.bLocalizar.FlatAppearance.BorderSize = 0;
            this.bLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLocalizar.Location = new System.Drawing.Point(1094, 801);
            this.bLocalizar.Name = "bLocalizar";
            this.bLocalizar.Size = new System.Drawing.Size(203, 65);
            this.bLocalizar.TabIndex = 0;
            this.bLocalizar.UseVisualStyleBackColor = false;
            this.bLocalizar.Click += new System.EventHandler(this.bLocalizar_Click);
            // 
            // textNome1
            // 
            this.textNome1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.textNome1.Location = new System.Drawing.Point(355, 172);
            this.textNome1.Multiline = true;
            this.textNome1.Name = "textNome1";
            this.textNome1.Size = new System.Drawing.Size(935, 37);
            this.textNome1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome";
            // 
            // dDados
            // 
            this.dDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Status});
            this.dDados.Location = new System.Drawing.Point(53, 226);
            this.dDados.Name = "dDados";
            this.dDados.Size = new System.Drawing.Size(1237, 550);
            this.dDados.TabIndex = 19;
            this.dDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dDados_CellDoubleClick);
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Transparent;
            this.bVoltar.FlatAppearance.BorderSize = 0;
            this.bVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Image = ((System.Drawing.Image)(resources.GetObject("bVoltar.Image")));
            this.bVoltar.Location = new System.Drawing.Point(918, 794);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(183, 79);
            this.bVoltar.TabIndex = 92;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 400;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 399;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 395;
            // 
            // DadosA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1302, 872);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.dDados);
            this.Controls.Add(this.textNome1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bLocalizar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DadosA";
            this.Text = "DadosA";
            this.DoubleClick += new System.EventHandler(this.DadosA_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLocalizar;
        private System.Windows.Forms.TextBox textNome1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dDados;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}