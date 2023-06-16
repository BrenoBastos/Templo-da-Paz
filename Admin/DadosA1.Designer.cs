
namespace WindowsFormsApp1
{
    partial class DadosA1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadosA1));
            this.dDados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bVoltar = new System.Windows.Forms.Button();
            this.bLocalizar = new System.Windows.Forms.Button();
            this.textNome1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dDados
            // 
            this.dDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Status});
            this.dDados.Location = new System.Drawing.Point(44, 188);
            this.dDados.Name = "dDados";
            this.dDados.Size = new System.Drawing.Size(964, 452);
            this.dDados.TabIndex = 24;
            this.dDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dDados_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 300;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 360;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 300;
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Transparent;
            this.bVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVoltar.BackgroundImage")));
            this.bVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVoltar.FlatAppearance.BorderSize = 0;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.ForeColor = System.Drawing.Color.Transparent;
            this.bVoltar.Location = new System.Drawing.Point(643, 668);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(166, 57);
            this.bVoltar.TabIndex = 97;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // bLocalizar
            // 
            this.bLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.bLocalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bLocalizar.BackgroundImage")));
            this.bLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bLocalizar.FlatAppearance.BorderSize = 0;
            this.bLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLocalizar.ForeColor = System.Drawing.Color.Transparent;
            this.bLocalizar.Location = new System.Drawing.Point(813, 668);
            this.bLocalizar.Name = "bLocalizar";
            this.bLocalizar.Size = new System.Drawing.Size(206, 67);
            this.bLocalizar.TabIndex = 96;
            this.bLocalizar.UseVisualStyleBackColor = false;
            this.bLocalizar.Click += new System.EventHandler(this.bLocalizar_Click);
            // 
            // textNome1
            // 
            this.textNome1.Location = new System.Drawing.Point(302, 140);
            this.textNome1.Multiline = true;
            this.textNome1.Name = "textNome1";
            this.textNome1.Size = new System.Drawing.Size(600, 36);
            this.textNome1.TabIndex = 15;
            // 
            // DadosA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1020, 725);
            this.Controls.Add(this.textNome1);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.bLocalizar);
            this.Controls.Add(this.dDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DadosA1";
            ((System.ComponentModel.ISupportInitialize)(this.dDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dDados;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.Button bLocalizar;
        private System.Windows.Forms.TextBox textNome1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}