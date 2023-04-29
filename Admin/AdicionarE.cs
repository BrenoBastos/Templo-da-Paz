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
            else if (string.IsNullOrWhiteSpace(textMaterial.Text))
            {
                MessageBox.Show("Por favor, preencha o campo material");

            }
            else if (string.IsNullOrWhiteSpace(textQuantidade.Text))
            {
                MessageBox.Show("Por favor, preencha o campo quantidade");

            }
            else if (string.IsNullOrWhiteSpace(textFornecedor.Text))
            {
                MessageBox.Show("Por favor, preencha o campo fornecedor");

            }
            else
            {
                

                if ( !textQuantidade.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Quantidade'.");
                    return;
                }
            }
            MessageBox.Show("Adicionado com sucesso");
            textMaterial.Text = "";
            textFornecedor.Text = "";

            textQuantidade.Text = "";

        }
    }
}
