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
    public partial class AlterarCadaverA : Form
    {
        public AlterarCadaverA()
        {
            InitializeComponent();
        }
       
        private void mDataChegada_Click(object sender, EventArgs e)
        {
            mDataChegada.SelectionStart = 0;
            mDataChegada.SelectionLength = 0;
        }
        public void CarregarDetalhes(string Id, string nome, string assistente, string gaveta, string dataCheg, string horarioCheg)
        {
            textID.Text = Id.ToString();
            textNome.Text = nome;
            textAssistente.Text= assistente;
            textGaveta.Text = gaveta;
            mDataChegada.Text = dataCheg;
            mHorarioChegada.Text = horarioCheg;
           
        }
        private void mHorarioChegada_Click(object sender, EventArgs e)
        {
            // Define o início da seleção para 0
                mHorarioChegada.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mHorarioChegada.SelectionLength = 0;
        }
      
        private void bAlterar_Click(object sender, EventArgs e)
        {
            // Verifica se algum campo obrigatório está vazio ou incompleto
            if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(textGaveta.Text) ||
                string.IsNullOrWhiteSpace(textID.Text) || !mDataChegada.MaskCompleted || !mHorarioChegada.MaskCompleted)
            {
                MessageBox.Show("Preencha todos os campos!");
                // encerra a execução do método se algum campo estiver incompleto
                return;
            }
            // Verifica se o campo ID contém apenas dígitos numéricos
            else if (!textID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'ID'.");
                // Limpa o campo ID se o usuário inseriu caracteres inválidos
                textID.Text = ""; 
                return;
            }
            // Verifica se o campo Assistente contém apenas caracteres de texto
            else if (textAssistente.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Assistente'.");
                // Limpa o campo Assistente se o usuário inseriu caracteres inválidos
                textAssistente.Text = ""; 
                return;
            }
            // Verifica se o campo Nome contém apenas caracteres de texto
            else if (textNome.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Nome'.");
                // Limpa o campo Nome se o usuário inseriu caracteres inválidos
               
                textNome.Text = "";
                return;
            }
            // Verifica se o campo Gaveta contém apenas caracteres de texto
            else if (textGaveta.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Gaveta'.");
                // Limpa o campo Gaveta se o usuário inseriu caracteres inválidos
              
                textGaveta.Text = "";
                return;
            }
            else
            {
                // Se todos os campos foram preenchidos corretamente, exibe uma mensagem de sucesso e limpa os campos
                MessageBox.Show("Alterado com sucesso");
                textNome.Text = "";
                textID.Text = "";
                textGaveta.Text = "";
                mDataChegada.Text = "";
                mHorarioChegada.Text = "";
                textAssistente.Text = "";

            }
        }
        

        private void bVoltar_Click(object sender, EventArgs e)
        {// Esconde a janela atual
            this.Hide();
            // Cria uma nova instância da classe  DadosCadaverA

            DadosCadaverA novaTela = new DadosCadaverA();
            // Mostra a nova instância da janela  DadosCadaverA
            novaTela.ShowDialog();
        }
    }
}
