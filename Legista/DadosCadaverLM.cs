using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DadosCadaverLM : Form
    {
        public DadosCadaverLM()
        {
            InitializeComponent();
            // Chama o método que inicializa a ComboBox

            comboBoxiniciar();
            comboBoxiniciar2();


        }// Método que inicializa a ComboBox

        private void comboBoxiniciar()
        {    // Verifica se o ComboBox já foi preenchido antes

            if (cRetirada.Items.Count == 0)
            {        // Adiciona as opções ao ComboBox

                cRetirada.Items.Add("Espera");
                cRetirada.Items.Add("Velório Municipal");
                cRetirada.Items.Add("Funerária");
                // Seleciona o primeiro item por padrão

                cRetirada.SelectedIndex = 0;
                // Define o estilo do ComboBox para "DropDownList", que impede que o usuário digite valores

                cRetirada.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
        private void comboBoxiniciar2()
        {
            // Verifica se o ComboBox não tem nenhum item
            if (comboCor.Items.Count == 0)
            {
                // Adiciona os itens e seleciona o primeiro item
                comboCor.Items.Add("Branco");
                comboCor.Items.Add("Preto");
                comboCor.Items.Add("Pardo");
                comboCor.Items.Add("Amarelo");
                comboCor.Items.Add("Indígena");
                comboCor.SelectedIndex = 0;
                // Define o estilo de dropdown como DropDownList, para impedir a inserção de itens
                comboCor.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void bAlterar_Click(object sender, EventArgs e)
        {
            // Verifica se algum campo obrigatório está vazio
            if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(textID.Text) || string.IsNullOrWhiteSpace(textGaveta.Text) || string.IsNullOrWhiteSpace(textLaudo.Text) || string.IsNullOrWhiteSpace(textMaterial.Text)
                || string.IsNullOrWhiteSpace(textQuantidade.Text) || !mHorarioChegada.MaskCompleted || !mDataObito.MaskCompleted || !mHorárioÓbito.MaskCompleted || !mDataRetirada.MaskCompleted || !mDataChegada.MaskCompleted)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // Verifica se o campo 'ID' contém somente caracteres numéricos
            else if (!textID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'ID'.");
                textID.Text = "";
                return;
            }

            // Verifica se o campo 'Assistente' contém somente caracteres não numéricos
            else if (textAssistente.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Assistente'.");
                textAssistente.Text = "";
                return;
            }
            else if (!Regex.IsMatch(textGaveta.Text, "^[A-Z]{1}$")) // Verifica se o campo Gaveta contém apenas um caractere em maiúscula
            {
                // Exibe uma mensagem de erro informando que o campo Gaveta deve conter apenas um caractere em maiúscula
                MessageBox.Show("Por favor, insira apenas um caractere em maiúscula no campo 'Gaveta'.");
                textGaveta.Text = ""; // Limpa o campo Gaveta
                return; // Retorna sem cadastrar
            }

            // Verifica se o campo 'Legista' contém somente caracteres não numéricos
            else if (textLegista.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Legista'.");
                textLegista.Text = "";
                return;
            }

            // Verifica se o campo 'Nome' contém somente caracteres não numéricos
            else if (textNome.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Nome'.");
                textNome.Text = "";
                return;
            }

            // Verifica se o campo 'Gaveta' contém somente caracteres não numéricos
            else if (textGaveta.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Gaveta'.");
                textGaveta.Text = "";
                return;
            }

            // Caso todas as validações sejam bem-sucedidas, mostra a mensagem de sucesso e limpa os campos
            else
            {
                MessageBox.Show("Alterado com sucesso");
                textNome.Text = "";
                textID.Text = "";
                textGaveta.Text = "";
                textLaudo.Text = "";
                textMaterial.Text = "";
                textQuantidade.Text = "";
                mDataChegada.Text = "";
                mDataRetirada.Text = "";
                mHorarioChegada.Text = "";
                textAssistente.Text = "";
                textLegista.Text = "";
                cRetirada.SelectedIndex = 0;
                comboCor.SelectedIndex = 0;


            }
        }

        private void mDataChegada_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            mDataChegada.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mDataChegada.SelectionLength = 0;
        }

        private void mHorarioChegada_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            mHorarioChegada.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mHorarioChegada.SelectionLength = 0;
        }

        private void mDataRetirada_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            mDataRetirada.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mDataRetirada.SelectionLength = 0;
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {// Esconde a janela atual
            this.Hide();
            // Cria uma nova instância da classe       DadosCadaverL
            DadosCadaverL novaTela = new DadosCadaverL();
            // Mostra a nova instância da janela  DadosCadaverL

            novaTela.ShowDialog();
        }

        private void mHorarioRetirada_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            mHorarioRetirada.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mHorarioRetirada.SelectionLength = 0;
        }

        private void DataÓbito_Click(object sender, EventArgs e)
        {

        }

        private void mDataObito_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            mDataObito.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mDataObito.SelectionLength = 0;
        }

        private void mHorárioÓbito_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            mHorárioÓbito.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mHorárioÓbito.SelectionLength = 0;
        }

        private void cRetirada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
