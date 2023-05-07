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
                // Verifica se algum dos campos está vazio ou contém apenas espaços em branco
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            else if (!textQuantidade.Text.All(char.IsDigit))
            {
                // Verifica se o campo 'Quantidade' contém apenas caracteres numéricos
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Quantidade'.");
                textQuantidade.Text = "";
                return;
            }
            else if (textFornecedor.Text.All(char.IsDigit))
            {
                // Verifica se o campo 'Fornecedor' contém apenas caracteres não-numéricos
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Fornecedor'.");
                textFornecedor.Text = "";
                return;
            }
            else
            {
                // Caso todos os campos estejam preenchidos corretamente, realiza o cadastro
                MessageBox.Show("Cadastrado com sucesso");
                textMaterial.Text = "";
                textFornecedor.Text = "";
                textQuantidade.Text = "";
            }
        }

        private void textMaterial_TextChanged(object sender, EventArgs e)
        {

        }

        private void Material_Click(object sender, EventArgs e)
        {

        }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            // Oculta a janela atual
            this.Hide();

            // Cria uma nova instância da janela Admin1
            Admin1 novaTela = new Admin1();

            // Mostra a nova janela em um modo de diálogo
            novaTela.ShowDialog();

        }
    }
}

