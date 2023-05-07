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
    public partial class DadosCadaverA : Form
    {
        public DadosCadaverA()
        {
            InitializeComponent();
            // Define o modo de seleção do DataGridView como seleção de linha completa
            dDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void bLocalizar_Click(object sender, EventArgs e)
        {// Verifica se o campo de nome está vazio
            if (string.IsNullOrWhiteSpace(textNome.Text))
            { // Mostra uma mensagem de erro e interrompe o processamento da função
                MessageBox.Show("Campo 'Nome' vazio, preencha-o!");
                return;

            }

            else
            {  // Verifica se o campo de nome contém apenas caracteres alfabéticos
                if (textNome.Text.All(char.IsDigit))
                {// Mostra uma mensagem de erro e interrompe o processamento da função
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                    return;
                }
                else
                {// Mostra uma mensagem de sucesso e limpa o campo de nome

                    MessageBox.Show("Localizado com sucesso");
                    textNome.Text = "";
                }
            }
        }

        private void dDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        { // Oculta a tela atual

            this.Hide();
            // Cria uma nova instância da classe AlterarCadaverA
            AlterarCadaverA novaTela = new AlterarCadaverA();
            // Mostra a nova instância da janela  AlterarCadaverA
            novaTela.ShowDialog();
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {// Oculta a tela atual

            this.Hide();
            // Cria uma nova instância da classe Assistente
            Assistente novaTela = new Assistente();
            // Mostra a nova instância da janela   Assistente

            novaTela.ShowDialog();
        }

        private void DadosCadaverA_DoubleClick(object sender, EventArgs e)
        {
            // Oculta a tela atual

            this.Hide();
            // Cria uma nova instância da classe AlterarCadaverA
            AlterarCadaverA novaTela = new AlterarCadaverA();
            // Mostra a nova instância da janela  AlterarCadaverA
            novaTela.ShowDialog();
        }

        private void dDados_DoubleClick(object sender, EventArgs e)
        {// Oculta a tela atual

            this.Hide();
            // Cria uma nova instância da classe AlterarCadaverA
            AlterarCadaverA novaTela = new AlterarCadaverA();
            // Mostra a nova instância da janela  AlterarCadaverA
            novaTela.ShowDialog();
        }
    }
}
