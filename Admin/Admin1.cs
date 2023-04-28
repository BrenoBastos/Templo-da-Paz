using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Admin;

namespace WindowsFormsApp1
{
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
            TreeNode parentNode = treeView2.Nodes.Add("Legista");
            TreeNode childNode = parentNode.Nodes.Add("Cadastrar");
            TreeNode childNode1 = parentNode.Nodes.Add("Remover");
            TreeNode childNode2 = parentNode.Nodes.Add("Alterar");
            TreeNode parentNode1 = treeView2.Nodes.Add("Assistente");
            TreeNode childNode3 = parentNode1.Nodes.Add("Cadastrar");
            TreeNode childNode4 = parentNode1.Nodes.Add("Remover");
            TreeNode childNode5 = parentNode1.Nodes.Add("Alterar");
            TreeNode parentNode2 = treeView2.Nodes.Add("Estoque");
            TreeNode childNode6 = parentNode2.Nodes.Add("Cadastrar");
            TreeNode childNode7 = parentNode2.Nodes.Add("Adicionar");
            TreeNode parentNode3 = treeView2.Nodes.Add("Dados");
            TreeNode childNode8 = parentNode3.Nodes.Add("Legista");
            TreeNode childNode9 = parentNode3.Nodes.Add("Assistente");
            TreeNode childNode10 = parentNode3.Nodes.Add("Estoque");

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
                if (e.Node.Parent.Text == "Legista" && e.Node.Text == "Cadastrar" )
                {
                    metodoCadastrarL();
                }
                else if (e.Node.Text == "Alterar" && e.Node.Parent.Text == "Legista")
                {

                }
            
            else if (e.Node.Text == "Remover" && e.Node.Parent.Text == "Legista")
            {

            }
            else if (e.Node.Text == "Cadastrar" && e.Node.Parent.Text == "Assistente")
            {

            }
            else if (e.Node.Text == "Alterar" && e.Node.Parent.Text == "Assistente")
            {

            }
            else if (e.Node.Text == "Remover" && e.Node.Parent.Text == "Assistente")
            {

            }
            else if (e.Node.Text == "Cadastrar" && e.Node.Parent.Text == "Estoque")
            {

            }
            else if (e.Node.Text == "Adicionar" && e.Node.Parent.Text == "Estoque")
            {

            }
            else if (e.Node.Text == "Legista" && e.Node.Parent.Text == "Dados")
            {

            }
            else if (e.Node.Text == "Assistente" && e.Node.Parent.Text == "Dados")
            {

            }
            else if (e.Node.Text == "Estoque" && e.Node.Parent.Text == "Dados")
            {

            }

            
        }
        private void metodoCadastrarL()
        {

            CadastrarL novaTela = new CadastrarL();
            novaTela.ShowDialog();
            this.Hide();

        }
    }
}
