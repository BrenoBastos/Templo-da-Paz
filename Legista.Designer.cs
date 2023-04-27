namespace WindowsFormsApp1
{
    partial class Legista
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Atualizar");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Dados");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Cadáver", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 1);
            this.treeView1.Name = "treeView1";
            treeNode1.Checked = true;
            treeNode1.Name = "Atualizar";
            treeNode1.Text = "Atualizar";
            treeNode1.ToolTipText = "Atualizar";
            treeNode2.Checked = true;
            treeNode2.Name = "Dados";
            treeNode2.Text = "Dados";
            treeNode2.ToolTipText = "Dados";
            treeNode3.Name = "Cadaver";
            treeNode3.Text = "Cadáver";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(216, 216);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // Legista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Legista";
            this.Text = "Legista";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView treeView1;
    }
}