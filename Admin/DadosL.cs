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
    public partial class DadosL : Form
    {
        public DadosL()
        {
            InitializeComponent();
            // Define o modo de seleção do DataGridView como seleção de linha completa

            dDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void bLocalizar_Click(object sender, EventArgs e)
        { // Verifica se o campo de nome está vazio

            if (string.IsNullOrWhiteSpace(textNome1.Text))
            { // Mostra uma mensagem de erro e interrompe o processamento da função
                MessageBox.Show("Campo 'Nome' vazio, preencha-o!");
                return;

            }

            else
            { // Verifica se o campo de nome contém apenas caracteres alfabéticos
                if (textNome1.Text.All(char.IsDigit))
                { // Mostra uma mensagem de erro e interrompe o processamento da função
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                    return;
                }
                else
                { // Mostra uma mensagem de sucesso e limpa o campo de nome
                    MessageBox.Show("Localizado com sucesso");
                    textNome1.Text = "";
                }
            }
        }

        private void DadosL_Click(object sender, EventArgs e)
        {
  
        }

        private void dDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { // Oculta a tela atual
            this.Hide();
            // Cria uma nova instância da classe            AlterarL
            AlterarL novaTela = new AlterarL();
            // Mostra a nova instância da janela            AlterarL
            novaTela.ShowDialog();
        }

        private void dDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Oculta a tela atual
            this.Hide();
            // Cria uma nova instância da classe            AlterarL
            AlterarL novaTela = new AlterarL();
            // Mostra a nova instância da janela            AlterarL
            novaTela.ShowDialog();
        }

        private void bVoltar_Click(object sender, EventArgs e)
        { // Oculta a tela atual
            this.Hide();
            // Cria uma nova instância da classe            Admin1

            Admin1 novaTela = new Admin1();
            // Mostra a nova instância da janela              Admin1

            novaTela.ShowDialog();
        }
    }
    }

