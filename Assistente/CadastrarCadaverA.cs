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
    public partial class CadastrarCadaverA : Form
    {
        public CadastrarCadaverA()
        {
            InitializeComponent();
            textID.Enabled = false;

        }
       
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se algum dos campos obrigatórios está vazio ou se as máscaras de data e hora não foram preenchidas
            if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(textGaveta.Text) ||
                    string.IsNullOrWhiteSpace(textID.Text) || !mDataChegada.MaskCompleted || !mHorarioChegada.MaskCompleted)
            {
                // Exibe uma mensagem de erro informando que todos os campos obrigatórios devem ser preenchidos
                MessageBox.Show("Preencha todos os campos!");
                return; // Retorna sem cadastrar
            }
            else if (!textID.Text.All(char.IsDigit)) // Verifica se o campo ID contém apenas caracteres numéricos
            {
                // Exibe uma mensagem de erro informando que o campo ID deve conter apenas caracteres numéricos
                MessageBox.Show("Por favor, insira apenas carecteres numéricos no campo 'ID'.");
                textID.Text = ""; // Limpa o campo ID
                return; // Retorna sem cadastrar
            }
            else if (textAssistente.Text.All(char.IsDigit)) // Verifica se o campo Assistente contém apenas caracteres numéricos
            {
                // Exibe uma mensagem de erro informando que o campo Assistente deve conter apenas caracteres
                MessageBox.Show("Por favor, insira apenas carecteres no campo 'Assistente'.");
                textAssistente.Text = ""; // Limpa o campo Assistente
                return; // Retorna sem cadastrar
            }
            else if (textNome.Text.All(char.IsDigit)) // Verifica se o campo Nome contém apenas caracteres
            {
                // Exibe uma mensagem de erro informando que o campo Nome deve conter apenas caracteres
                MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                textNome.Text = ""; // Limpa o campo Nome
                return; // Retorna sem cadastrar
            }
            else if (textGaveta.Text.All(char.IsDigit)) // Verifica se o campo Gaveta contém apenas caracteres numéricos
            {
                // Exibe uma mensagem de erro informando que o campo Gaveta deve conter apenas caracteres
                MessageBox.Show("Por favor, insira apenas carecteres no campo 'Gaveta'.");
                textGaveta.Text = ""; // Limpa o campo Gaveta
                return; // Retorna sem cadastrar
            }
            else // Se todas as validações passarem
            {
                // Exibe uma mensagem de sucesso informando que o cadastro foi realizado com sucesso
                MessageBox.Show("Cadastrado com sucesso");
                // Limpa todos os campos para um novo cadastro
                textNome.Text = "";
                textID.Text = "";
                textGaveta.Text = "";
                mDataChegada.Text = "";
                mHorarioChegada.Text = "";
                textAssistente.Text = "";
            }
        }
        

        private void mDataChegada_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            mDataChegada.SelectionStart = 0;
            // Define o comprimento da seleção para 0

            mDataChegada.SelectionLength = 0;
        }

        private void mHorarioChegada_Click(object sender, EventArgs e)
        { // Define o início da seleção para 0
            mHorarioChegada.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mHorarioChegada.SelectionLength = 0;
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {// Esconde a janela atual
            this.Hide();
            // Cria uma nova instância da classe  Assistente

            Assistente novaTela = new Assistente();
            // Mostra a nova instância da janela  Assistente
            novaTela.ShowDialog();
        }
    }
}
