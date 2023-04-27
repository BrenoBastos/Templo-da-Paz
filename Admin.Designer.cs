namespace WindowsFormsApp1
{
    partial class Admin
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Cadastrar");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Remover");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Alterar");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Legista", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Cadastrar");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Remover");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Alterar");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Assistente", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Cadastrar");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Adicionar");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Estoque", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Legista");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Assistente");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Estoque");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Dados", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 47);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "CadastrarL";
            treeNode1.Text = "Cadastrar";
            treeNode2.Name = "AlterarL";
            treeNode2.Text = "Remover";
            treeNode3.Name = "AlterarL";
            treeNode3.Text = "Alterar";
            treeNode4.Name = "Legista";
            treeNode4.Text = "Legista";
            treeNode5.Name = "CadastrarF";
            treeNode5.Text = "Cadastrar";
            treeNode6.Name = "RemoverL";
            treeNode6.Text = "Remover";
            treeNode7.Name = "AlterarL";
            treeNode7.Text = "Alterar";
            treeNode8.Name = "Assistente";
            treeNode8.Text = "Assistente";
            treeNode9.Name = "CadastrarE";
            treeNode9.Text = "Cadastrar";
            treeNode10.Name = "AdicionarE";
            treeNode10.Text = "Adicionar";
            treeNode11.Name = "Estoque";
            treeNode11.Text = "Estoque";
            treeNode12.Name = "DadosL";
            treeNode12.Text = "Legista";
            treeNode13.Name = "DadosA";
            treeNode13.Text = "Assistente";
            treeNode14.Name = "DadosE";
            treeNode14.Text = "Estoque";
            treeNode15.Name = "Dados";
            treeNode15.Text = "Dados";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode11,
            treeNode15});
            this.treeView1.Size = new System.Drawing.Size(162, 159);
            this.treeView1.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}