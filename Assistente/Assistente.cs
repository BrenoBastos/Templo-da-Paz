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
            BackColor = Color.FromArgb(64, 49, 49);
            treeView2.Font = new Font("Poppins", 20, FontStyle.Regular);
            treeView2.BackColor = Color.FromArgb(90, 72, 72);
            bVoltar.FlatAppearance.MouseOverBackColor = bVoltar.BackColor;
            bVoltar.FlatAppearance.MouseDownBackColor = bVoltar.BackColor;
            treeView2.BackColor = Color.FromArgb(90, 72, 72);
            treeView2.HideSelection = false;
            CenterToScreen();
            //Cria um nó raiz no TreeView com o texto "Cadáver" e o armazena na variável parentNode.

            TreeNode parentNode = treeView2.Nodes.Add("Laudo");
            //Cria um nó filho com o texto "Cadastrar" e o adiciona ao nó raiz parentNode.

            TreeNode childNode = parentNode.Nodes.Add("Cadastrar");
            //Cria um segundo nó filho com o texto "Dados" e o adiciona ao nó raiz parentNode.

            TreeNode childNode1 = parentNode.Nodes.Add("Dados");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
       

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
        

        private void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {    // Verifica se o texto do nó clicado é igual a "Cadastrar"

            if (e.Node.Text == "Cadastrar")
            {// Esconde a janela atual
                this.Hide();
                // Cria uma nova instância da classe       CadastrarCadaverA
                CadastrarCadaverA novaTela = new CadastrarCadaverA();
                // Mostra a nova instância da janela   CadastrarCadaverA

                novaTela.ShowDialog();
            }    // Se o texto do nó clicado for igual a "Dados"

            else if (e.Node.Text == "Dados")
            {// Esconde a janela atual
                this.Hide();
                // Cria uma nova instância da classe       DadosCadaverA
                DadosCadaverA novaTela = new DadosCadaverA();
                // Mostra a nova instância da janela   DadosCadaverA

                novaTela.ShowDialog();
            }
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {// Esconde a janela atual
            this.Hide();
            // Cria uma nova instância da classe  Login
            Login novaTela = new Login();
            // Mostra a nova instância da janela  Login

            novaTela.ShowDialog();
        }

        private void bVoltar_Click_1(object sender, EventArgs e)
        {
            // Esconde a janela atual
            this.Hide();
            // Cria uma nova instância da classe  Login
            Login novaTela = new Login();
            // Mostra a nova instância da janela  Login

            novaTela.ShowDialog();
        }

        private void Assistente_Load(object sender, EventArgs e)
        {

        }
    }
}
