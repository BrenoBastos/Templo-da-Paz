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
    public partial class AdicionarE : Form
    {
        public AdicionarE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textMaterial.Text) || string.IsNullOrWhiteSpace(textQuantidade.Text) || string.IsNullOrWhiteSpace(textFornecedor.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }



         else   if (!textQuantidade.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Quantidade'.");
                textQuantidade.Text = "";
                return;
            }
            else if (textFornecedor.Text.All(char.IsDigit))
            {
                MessageBox.Show( "Por favor, insira apenas caracteres  no campo 'Fornecedor'.");
                textFornecedor.Text = "";

            }
            else
            {
                MessageBox.Show("Adicionado com sucesso");
                textMaterial.Text = "";
                textFornecedor.Text = "";

                textQuantidade.Text = "";

            }
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Admin1 novaTela = new Admin1();
            novaTela.ShowDialog();
        }
    }
}
