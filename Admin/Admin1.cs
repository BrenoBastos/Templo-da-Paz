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
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
            // Cria um novo nó pai na árvore e define seu texto como "Legista"
            TreeNode parentNode = treeView2.Nodes.Add("Legista");

            // Cria um novo nó filho no nó pai "Legista" e define seu texto como "Cadastrar"
            TreeNode childNode = parentNode.Nodes.Add("Cadastrar");

            // Cria um novo nó pai na árvore e define seu texto como "Assistente"
            TreeNode parentNode1 = treeView2.Nodes.Add("Assistente");

            // Cria um novo nó filho no nó pai "Assistente" e define seu texto como "Cadastrar"
            TreeNode childNode3 = parentNode1.Nodes.Add("Cadastrar");

            // Cria um novo nó pai na árvore e define seu texto como "Estoque"
            TreeNode parentNode2 = treeView2.Nodes.Add("Estoque");

            // Cria um novo nó filho no nó pai "Estoque" e define seu texto como "Cadastrar"
            TreeNode childNode6 = parentNode2.Nodes.Add("Cadastrar");

            // Cria um novo nó filho no nó pai "Estoque" e define seu texto como "Adicionar"
            TreeNode childNode7 = parentNode2.Nodes.Add("Adicionar");

            // Cria um novo nó pai na árvore e define seu texto como "Fornecedor"
            TreeNode parentNode3 = treeView2.Nodes.Add("Fornecedor");

            // Cria um novo nó filho no nó pai "Fornecedor" e define seu texto como "Cadastrar"
            TreeNode childNode8 = parentNode3.Nodes.Add("Cadastrar");

            // Cria um novo nó pai na árvore e define seu texto como "Dados"
            TreeNode parentNode4 = treeView2.Nodes.Add("Dados");

            // Cria um novo nó filho no nó pai "Dados" e define seu texto como "Legista"
            TreeNode childNode11 = parentNode4.Nodes.Add("Legista");

            // Cria um novo nó filho no nó pai "Dados" e define seu texto como "Assistente"
            TreeNode childNode12 = parentNode4.Nodes.Add("Assistente");

            // Cria um novo nó filho no nó pai "Dados" e define seu texto como "Estoque"
            TreeNode childNode13 = parentNode4.Nodes.Add("Estoque");

            // Cria um novo nó filho no nó pai "Dados" e define seu texto como "Fornecedor"
            TreeNode childNode14 = parentNode4.Nodes.Add("Fornecedor");
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
                

            
        }
      

        private void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Verifica se o nó clicado é "Cadastrar" e o pai é "Legista"
            if (e.Node.Text == "Cadastrar" && e.Node.Parent.Text == "Legista")
            {
                // Esconde a tela atual
                this.Hide();

                // Cria uma nova instância da tela CadastrarL
                CadastrarL novaTela = new CadastrarL();

                // Abre a nova tela em um diálogo
                novaTela.ShowDialog();
            }

            // Verifica se o nó clicado é "Cadastrar" e o pai é "Assistente"
            else if (e.Node.Text == "Cadastrar" && e.Node.Parent.Text == "Assistente")
            {
                // Esconde a tela atual
                this.Hide();

                // Cria uma nova instância da tela CadastrarA
                CadastrarA novaTela = new CadastrarA();

                // Abre a nova tela em um diálogo
                novaTela.ShowDialog();
            }

            // Verifica se o nó clicado é "Cadastrar" e o pai é "Estoque"
            else if (e.Node.Text == "Cadastrar" && e.Node.Parent.Text == "Estoque")
            {
                // Esconde a tela atual
                this.Hide();

                // Cria uma nova instância da tela CadastrarE
                CadastrarE novaTela = new CadastrarE();

                // Abre a nova tela em um diálogo
                novaTela.ShowDialog();
            }

            // Verifica se o nó clicado é "Adicionar" e o pai é "Estoque"
            else if (e.Node.Text == "Adicionar" && e.Node.Parent.Text == "Estoque")
            {
                // Esconde a tela atual
                this.Hide();

                // Cria uma nova instância da tela AdicionarE
                AdicionarE novaTela = new AdicionarE();

                // Abre a nova tela em um diálogo
                novaTela.ShowDialog();
            }

            // Verifica se o nó clicado é "Cadastrar" e o pai é "Fornecedor"
            else if (e.Node.Text == "Cadastrar" && e.Node.Parent.Text == "Fornecedor")
            {
                // Esconde a tela atual
                this.Hide();

                // Cria uma nova instância da tela CadastrarF
                CadastrarF novaTela = new CadastrarF();

                // Abre a nova tela em um diálogo
                novaTela.ShowDialog();
            }

            // Verifica se o nó clicado é "Legista", o pai não é nulo e o pai é "Dados"
            if (e.Node.Text == "Legista" && e.Node.Parent != null && e.Node.Parent.Text == "Dados")
            {
                // Esconde a tela atual
                this.Hide();

                // Cria uma nova instância da tela DadosL
                DadosL novaTela = new DadosL();

                // Abre a nova tela em um diálogo
                novaTela.ShowDialog();
            }

            // Verifica se o nó clicado é "Assistente", o pai não é nulo e o pai é "Dados"
            if (e.Node.Text == "Assistente" && e.Node.Parent != null && e.Node.Parent.Text == "Dados")
            {
                // Esconde a tela atual
                this.Hide();

                // Cria uma nova instância da tela DadosA
                DadosA novaTela = new DadosA();

                // Abre a nova tela em um diálogo
                novaTela.ShowDialog();
            }
            // Verifica se o nó clicado é "Estoque", o pai não é nulo e o pai é "Dados"

            if (e.Node.Text == "Estoque" && e.Node.Parent != null && e.Node.Parent.Text == "Dados")
            {                // Esconde a tela atual

                this.Hide();
                // Cria uma nova instância da tela DadosE

                DadosE novaTela = new DadosE();
                // Abre a nova tela em um diálogo

                novaTela.ShowDialog();
            }
            // Verifica se o nó clicado é "Fornecedor", o pai não é nulo e o pai é "Dados"

            if (e.Node.Text == "Fornecedor" && e.Node.Parent != null && e.Node.Parent.Text == "Dados")
            {                // Esconde a tela atual

                this.Hide();
                // Cria uma nova instância da tela DadosF

                DadosF novaTela = new DadosF();    
                // Abre a nova tela em um diálogo

                novaTela.ShowDialog();
            }
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {                // Esconde a tela atual

            this.Hide();
            // Cria uma nova instância da tela Login

            Login novaTela = new Login();
            // Abre a nova tela em um diálogo

            novaTela.ShowDialog();
        }
    }
}
