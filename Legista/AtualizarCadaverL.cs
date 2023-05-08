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
    public partial class AtualizarCadaverL : Form
    {
        public AtualizarCadaverL()
        {
            InitializeComponent();
            // Inicializa o ComboBox
            comboBoxiniciar();

            // Define o modo de seleção do DataGridView

            dDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void comboBoxiniciar()
        {// Verifica se o ComboBox está vazio
            if (cRetirada.Items.Count == 0)
            {// Adiciona o item itens no ComboBox
                cRetirada.Items.Add("Espera");
                cRetirada.Items.Add("Velório Municipal");
                cRetirada.Items.Add("Funerária");
                // Define o primeiro item como selecionado
                cRetirada.SelectedIndex = 0;
                // Define o ComboBox como somente leitura
                cRetirada.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bAtualizar_Click(object sender, EventArgs e)
        {
            // Verifica se algum campo obrigatório está vazio ou não preenchido corretamente
            if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(textID.Text) || string.IsNullOrWhiteSpace(textGaveta.Text) || string.IsNullOrWhiteSpace(textLaudo.Text) || string.IsNullOrWhiteSpace(textMaterial.Text)
                || string.IsNullOrWhiteSpace(textQuantidade.Text) || !mHorarioChegada.MaskCompleted || !mDataRetirada.MaskCompleted || !mDataChegada.MaskCompleted)
            {
                // Exibe uma mensagem de erro e encerra a função
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // Verifica se o campo 'ID' contém apenas caracteres numéricos
            if (!textID.Text.All(char.IsDigit))
            {
                // Exibe uma mensagem de erro e limpa o campo 'ID'
                MessageBox.Show("Por favor, insira apenas carecteres numéricos  no campo 'ID'.");
                textID.Text = "";
                return;
            }
            // Verifica se o campo 'Assistente' contém apenas caracteres alfanuméricos
            else if (textAssistente.Text.All(char.IsDigit))
            {
                // Exibe uma mensagem de erro e limpa o campo 'Assistente'
                MessageBox.Show("Por favor, insira apenas carecteres no campo 'Assistente'.");
                textAssistente.Text = "";
                return;
            }
            // Verifica se o campo 'Legista' contém apenas caracteres alfanuméricos
            else if (textLegista.Text.All(char.IsDigit))
            {
                // Exibe uma mensagem de erro e limpa o campo 'Legista'
                MessageBox.Show("Por favor, insira apenas carecteres no campo 'Legista'.");
                textLegista.Text = "";
                return;
            }
            // Verifica se o campo 'Nome' contém apenas caracteres alfanuméricos
            else if (textNome.Text.All(char.IsDigit))
            {
                // Exibe uma mensagem de erro e limpa o campo 'Nome'
                MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                textNome.Text = "";
                return;
            }
            // Verifica se o campo 'Gaveta' contém apenas caracteres alfanuméricos
            else if (textGaveta.Text.All(char.IsDigit))
            {
                // Exibe uma mensagem de erro e limpa o campo 'Gaveta'
                MessageBox.Show("Por favor, insira apenas carecteres no campo 'Gaveta'.");
                textGaveta.Text = "";
                return;
            }
            // Verifica se o campo 'Quantidade' contém apenas caracteres numéricos
            else if (!textQuantidade.Text.All(char.IsDigit))
            {
                // Exibe uma mensagem de erro e limpa o campo 'Quantidade'
                MessageBox.Show("Por favor, insira apenas carecteres numéricos no campo 'Quantidade'.");
                textQuantidade.Text = "";
                return;
            }
            // Se todos os campos estiverem preenchidos corretamente
            else
            {
                // Exibe uma mensagem de sucesso e limpa todos os campos e faz combobox voltar padrão
                MessageBox.Show("Atualizado com sucesso");
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
                mHorarioRetirada.Text = "";
                mDataObito.Text = "";
                mHorárioÓbito.Text = "";
                cRetirada.SelectedIndex = 0;
            }
        }

        private void mDataChegada_Click(object sender, EventArgs e)
        {  // Define o início da seleção para 0
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

        private void mDataRetirada_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            mDataRetirada.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mDataRetirada.SelectionLength = 0;
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {// Esconde a janela atual
            this.Hide();
            // Cria uma nova instância da classe   Legista 


            Legista novaTela = new Legista();
            // Mostra a nova instância da janela Legista

            novaTela.ShowDialog();
        }

        private void mHorárioÓbito_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            mHorárioÓbito.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mHorárioÓbito.SelectionLength = 0;
        }

        private void mDataObito_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            mDataObito.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mDataObito.SelectionLength = 0;
        }

        private void mHorarioRetirada_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            mHorarioRetirada.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mHorarioRetirada.SelectionLength = 0;
        }

        private void dDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
