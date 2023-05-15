using MySql.Data.MySqlClient;
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

        }
       
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se algum dos campos obrigatórios está vazio ou se as máscaras de data e hora não foram preenchidas
            if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(textGaveta.Text) ||
                    !mDataChegada.MaskCompleted || !mHorarioChegada.MaskCompleted)
            {
                // Exibe uma mensagem de erro informando que todos os campos obrigatórios devem ser preenchidos
                MessageBox.Show("Preencha todos os campos!");
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
            else if (!textGaveta.Text.All(char.IsUpper)) // Verifica se o campo Gaveta contém apenas letras maiúsculas
            {
                // Exibe uma mensagem de erro informando que o campo Gaveta deve conter apenas letras maiúsculas
                MessageBox.Show("Por favor, insira apenas letras maiúsculas no campo 'Gaveta'.");
                textGaveta.Text = ""; // Limpa o campo Gaveta
                return; // Retorna sem cadastrar
            }
            else // Se todas as validações passarem
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.Abrir();

                    string nome = textNome.Text;
                    string gaveta = textGaveta.Text;
                    string dataChegada = mDataChegada.Text;
                    string horarioChegada = mHorarioChegada.Text;
                    string assistente = textAssistente.Text;

                    // Verifica se o fornecedor existe na tabela "fornecedor"
                    string verificaAssistenteQuery = $"SELECT COUNT(*) FROM assistente WHERE Nome = @assistente AND Status = 'ativo'";
                    MySqlCommand verificaAssistenteCmd = new MySqlCommand(verificaAssistenteQuery, Conexao.con);
                    verificaAssistenteCmd.Parameters.AddWithValue("@assistente", assistente);

                    int AssistenteCount = Convert.ToInt32(verificaAssistenteCmd.ExecuteScalar());

                    if (AssistenteCount > 0)
                    {
                        string verificaGavetaQuery = "SELECT COUNT(*) FROM cadaver WHERE Gaveta = @gaveta";
                        MySqlCommand verificaGavetaCmd = new MySqlCommand(verificaGavetaQuery, Conexao.con);
                        verificaGavetaCmd.Parameters.AddWithValue("@gaveta", gaveta);

                        int gavetaCount = Convert.ToInt32(verificaGavetaCmd.ExecuteScalar());

                        if (gavetaCount > 0)
                        {
                            MessageBox.Show("A gaveta informada já está ocupada. Por favor, escolha outra gaveta.");
                        }
                        else
                        {
                            // Insira o cadáver no banco de dados
                            string queryCadaver = "INSERT INTO cadaver (Nome, Gaveta, DataChegada, HorarioChegada, Assistente) VALUES (@nome, @gaveta, @dataChegada, @horarioChegada, @assistente)";
                            MySqlCommand cmdCadaver = new MySqlCommand(queryCadaver, Conexao.con);
                            cmdCadaver.Parameters.AddWithValue("@nome", nome);
                            cmdCadaver.Parameters.AddWithValue("@gaveta", gaveta);
                            cmdCadaver.Parameters.AddWithValue("@dataChegada", dataChegada);
                            cmdCadaver.Parameters.AddWithValue("@horarioChegada", horarioChegada);
                            cmdCadaver.Parameters.AddWithValue("@assistente", assistente);
                            cmdCadaver.ExecuteNonQuery();

                            // Exibe uma mensagem de sucesso informando que o cadastro foi realizado com sucesso
                            MessageBox.Show("Cadastrado com sucesso");

                            // Limpa todos os campos para um novo cadastro
                            textNome.Text = "";
                            textGaveta.Text = "";
                            mDataChegada.Text = "";
                            mHorarioChegada.Text = "";
                            textAssistente.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não encontrado na tabela 'assistente'. Cadastre o assistente antes de adicionar um cadaver,ou assistente inativo.");
                    }
                    conexao.Fechar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
                }
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
