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
    public partial class Legista : Form
    {
        public Legista()
        {
            InitializeComponent();
            // Cria um nó raiz para a árvore de exibição da interface gráfica com o texto "Cadáver"
            TreeNode parentNode = treeView1.Nodes.Add("Cadáver");

            // Cria um nó filho do nó raiz com o texto "Atualizar"
            TreeNode childNode = parentNode.Nodes.Add("Atualizar");

            // Cria um nó filho do nó raiz com o texto "Dados"
            TreeNode childNode1 = parentNode.Nodes.Add("Dados");

            // Cria um nó filho do nó raiz com o texto "Certificado"
            TreeNode childNode2 = parentNode.Nodes.Add("Certificado");


        }





        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

      

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
      

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {// Verifica se o texto do nó clicado é "Atualizar"
            if (e.Node.Text == "Atualizar")
            { // Esconde a janela atual
                this.Hide();
                // Cria uma nova instância da classe       AtualizarCadaverL
                AtualizarCadaverL novaTela = new AtualizarCadaverL();
                // Mostra a nova instância da janela         AtualizarCadaverL

                novaTela.ShowDialog();
            }// Verifica se o texto do nó clicado é "Dados"
            else if (e.Node.Text == "Dados")
            {
                // Esconde a janela atual
                    this.Hide();
                // Cria uma nova instância da classe    DadosCadaverL
                DadosCadaverL novaTela = new DadosCadaverL();
                // Mostra a nova instância da janela       DadosCadaverL

                novaTela.ShowDialog();
            }// Verifica se o texto do nó clicado é "Certificado"
            else if (e.Node.Text == "Certificado")
            {// Esconde a janela atual
                this.Hide();
                // Cria uma nova instância da classe    CertificadoObito
                CertificadoObito novaTela = new CertificadoObito();
                // Mostra a nova instância da janela CertificadoObito

                novaTela.ShowDialog();
            }
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {// Esconde a janela atual
            this.Hide();
            // Cria uma nova instância da classe    Login 
            Login novaTela = new Login();
            // Mostra a nova instância da janela Login
            novaTela.ShowDialog();
        }
    }
}
