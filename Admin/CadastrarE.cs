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
    public partial class CadastrarE : Form
    {
        public CadastrarE()
        {
            InitializeComponent();
        }

        private void bCadastrar_Click(object sender, EventArgs e)
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


                if (!textQuantidade.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Quantidade'.");
                    return;
                }
            }
            MessageBox.Show("Cadastrado com sucesso");
            textMaterial.Text = "";
            textFornecedor.Text = "";

            textQuantidade.Text = "";

        }

        private void textMaterial_TextChanged(object sender, EventArgs e)
        {

        }

        private void Material_Click(object sender, EventArgs e)
        {

        }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Admin1 novaTela = new Admin1();
            novaTela.ShowDialog();
        }
    }
    }

