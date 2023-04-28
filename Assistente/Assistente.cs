using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Assistente : Form
    {
        public Assistente()
        {
            InitializeComponent();
            TreeNode parentNode = treeView2.Nodes.Add("Cadáver");
            TreeNode childNode = parentNode.Nodes.Add("Cadastrar");
            TreeNode childNode1 = parentNode.Nodes.Add("Dados");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
       

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Cadastrar")
            {
                metodoCadastrar();
            }
            else if (e.Node.Text == "Dados")
            {
                metodoDados();
            }
        }
        private void metodoCadastrar()

        {
            this.Hide();

            CadastrarCadaverA novaTela = new CadastrarCadaverA();
            novaTela.ShowDialog();
        }
        private void metodoDados()
        {
            this.Hide();

            DadosCadaverA novaTela = new DadosCadaverA();
            novaTela.ShowDialog();
        }
    }
}
