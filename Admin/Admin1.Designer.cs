
namespace WindowsFormsApp1
{
    partial class Admin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin1));
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.bVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.Window;
            this.treeView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView2.ForeColor = System.Drawing.SystemColors.Control;
            this.treeView2.LineColor = System.Drawing.Color.White;
            this.treeView2.Location = new System.Drawing.Point(12, 105);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(196, 551);
            this.treeView2.TabIndex = 3;
            this.treeView2.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView2_NodeMouseClick);
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Transparent;
            this.bVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bVoltar.BackgroundImage")));
            this.bVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVoltar.FlatAppearance.BorderSize = 0;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Location = new System.Drawing.Point(292, 656);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(153, 56);
            this.bVoltar.TabIndex = 82;
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // Admin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(454, 714);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.treeView2);
            this.Name = "Admin1";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button bVoltar;
    }
}