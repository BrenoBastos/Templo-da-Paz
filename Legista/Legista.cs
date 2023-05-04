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
            TreeNode parentNode = treeView1.Nodes.Add("Cadáver");
            TreeNode childNode = parentNode.Nodes.Add("Atualizar");
            TreeNode childNode1 = parentNode.Nodes.Add("Dados");
            TreeNode childNode2 = parentNode.Nodes.Add("Certificado");


        }





        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

      

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
      

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "Atualizar")
            {
                this.Hide();

                AtualizarCadaverL novaTela = new AtualizarCadaverL();
                novaTela.ShowDialog();
            }
            else if (e.Node.Text == "Dados")
            {
                this.Hide();

                DadosCadaverL novaTela = new DadosCadaverL();
                novaTela.ShowDialog();
            }
            else if (e.Node.Text == "Certificado")
            {
                this.Hide();

                CertificadoObito novaTela = new CertificadoObito();
                novaTela.ShowDialog();
            }
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

           Login novaTela = new Login();
            novaTela.ShowDialog();
        }
    }
}
