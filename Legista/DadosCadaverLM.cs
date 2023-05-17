using MySql.Data.MySqlClient;
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
        public void CarregarDetalhes(string id, string nome, string assistente, string gaveta, string dataChegada, string horarioChegada, string laudo, string material, string quantidade, string dataRetirada, string horarioRetirada, string dataObito, string horarioObito, string retirada,string legista)
        {
            // Atribua os valores aos controles da janela DadosCadaverLM
            textID.Text = id;
            textNome.Text = nome;
            textAssistente.Text = assistente;
            textGaveta.Text = gaveta;
            mDataChegada.Text = dataChegada;
           mHorarioChegada.Text = horarioChegada;
            textLaudo.Text = laudo;
            textMaterial.Text = material;
            textQuantidade.Text = quantidade;
           mDataRetirada.Text = dataRetirada;
           mHorarioRetirada.Text = horarioRetirada;
            mDataObito.Text = dataObito;
            mHorárioÓbito.Text = horarioObito;
            textLegista.Text = legista;

            // Selecionar o valor correto no ComboBox de Retirada
            cRetirada.SelectedItem = retirada;
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
            else if (!textGaveta.Text.All(char.IsUpper)) // Verifica se o campo Gaveta contém apenas letras maiúsculas
            {
                // Exibe uma mensagem de erro informando que o campo Gaveta deve conter apenas letras maiúsculas
                MessageBox.Show("Por favor, insira apenas letras maiúsculas no campo 'Gaveta'.");
                textGaveta.Text = ""; // Limpa o campo Gaveta
                return; // Retorna sem cadastrar
            }

            // Caso todas as validações sejam bem-sucedidas, mostra a mensagem de sucesso e limpa os campos
            else
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.Abrir();

                    string id = textID.Text;
                    string nome = textNome.Text;
                    string gaveta = textGaveta.Text;
                    string dataChegada = mDataChegada.Text;
                    string horarioChegada = mHorarioChegada.Text;
                    string assistente = textAssistente.Text;
                    string legista = textLegista.Text;
                    string material = textMaterial.Text;
                    string dataobito = mDataObito.Text;
                    string horarioobito = mHorárioÓbito.Text;
                    string retirada = string.Empty;
                    switch (cRetirada.SelectedIndex)
                    {
                        case 0:
                            retirada = "Espera";
                            break;
                        case 1:
                            retirada = "Velório Municipal";
                            break;
                        case 2:
                            retirada = "Funerária";
                            break;

                    }
                  

                

                    int quantidade = int.Parse(textQuantidade.Text);

                    // Verifica se o assistente existe na tabela "assistente" e está ativo
                    string verificaAssistenteQuery = "SELECT COUNT(*) FROM assistente WHERE Nome = @assistente AND Status = 'ativo'";
                    MySqlCommand verificaAssistenteCmd = new MySqlCommand(verificaAssistenteQuery, Conexao.con);
                    verificaAssistenteCmd.Parameters.AddWithValue("@assistente", assistente);

                    int assistenteCount = Convert.ToInt32(verificaAssistenteCmd.ExecuteScalar());

                    if (assistenteCount == 0)
                    {
                        MessageBox.Show("O assistente informado não existe ou está inativo. Por favor, escolha um assistente válido.");
                        return;
                    }

                    // Verifica se o legista existe na tabela "legista" e está ativo
                    string verificaLegistaQuery = "SELECT COUNT(*) FROM legista WHERE Nome = @legista AND Status = 'ativo'";
                    MySqlCommand verificaLegistaCmd = new MySqlCommand(verificaLegistaQuery, Conexao.con);
                    verificaLegistaCmd.Parameters.AddWithValue("@legista", legista);

                    int legistaCount = Convert.ToInt32(verificaLegistaCmd.ExecuteScalar());

                    if (legistaCount == 0)
                    {
                        MessageBox.Show("O legista informado não existe ou está inativo. Por favor, escolha um legista válido.");
                        return;
                    }

                    // Verifica se o material existe na tabela "estoque" e há quantidade suficiente disponível
                    string verificaMaterialQuery = "SELECT Total FROM estoque WHERE Material = @material";
                    MySqlCommand verificaMaterialCmd = new MySqlCommand(verificaMaterialQuery, Conexao.con);
                    verificaMaterialCmd.Parameters.AddWithValue("@material", material);

                    int quantidadeDisponivel = Convert.ToInt32(verificaMaterialCmd.ExecuteScalar());

                    if (quantidadeDisponivel < quantidade)
                    {
                        MessageBox.Show("A quantidade solicitada do material não está disponível no estoque. Por favor, escolha uma quantidade menor ou verifique o estoque.");
                        return;
                    }
                  

                    // Atualiza os dados do cadáver no banco de dados
                    string queryUpdateCadaver = "UPDATE cadaver SET Nome = @nome, Gaveta = @gaveta, Laudo = @laudo, Material = @material, Quantidade = @quantidade, DataChegada = @dataChegada, dataRetirada = @dataRetirada, horarioChegada = @horarioChegada, Assistente = @assistente, Legista = @legista, HorarioRetirada = @horarioRetirada, DataObito = @dataObito, HorarioObito = @horarioObito, Retirada = @retirada WHERE Id = @id";
                    MySqlCommand cmdUpdateCadaver = new MySqlCommand(queryUpdateCadaver, Conexao.con);

                    cmdUpdateCadaver.Parameters.AddWithValue("@nome", textNome.Text);
                    cmdUpdateCadaver.Parameters.AddWithValue("@gaveta", textGaveta.Text);
                    cmdUpdateCadaver.Parameters.AddWithValue("@laudo", textLaudo.Text);
                    cmdUpdateCadaver.Parameters.AddWithValue("@material", textMaterial.Text);
                    cmdUpdateCadaver.Parameters.AddWithValue("@quantidade", textQuantidade.Text);
                    cmdUpdateCadaver.Parameters.AddWithValue("@dataChegada", mDataChegada.Text);
                    cmdUpdateCadaver.Parameters.AddWithValue("@dataRetirada", mDataRetirada.Text);
                    cmdUpdateCadaver.Parameters.AddWithValue("@horarioChegada", mHorarioChegada.Text);
                    cmdUpdateCadaver.Parameters.AddWithValue("@assistente", textAssistente.Text);
                    cmdUpdateCadaver.Parameters.AddWithValue("@legista", textLegista.Text);
                    cmdUpdateCadaver.Parameters.AddWithValue("@horarioRetirada", mHorarioRetirada.Text);
                    cmdUpdateCadaver.Parameters.AddWithValue("@dataObito", mDataObito.Text);
                    cmdUpdateCadaver.Parameters.AddWithValue("@horarioObito", mHorárioÓbito.Text);
                    cmdUpdateCadaver.Parameters.AddWithValue("@retirada", cRetirada.SelectedItem);
                    cmdUpdateCadaver.Parameters.AddWithValue("@id", textID.Text);

                    cmdUpdateCadaver.ExecuteNonQuery();


                    // Exibe uma mensagem de sucesso e limpa todos os campos
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
                    mHorarioRetirada.Text = "";
                    mDataObito.Text = "";
                    mHorárioÓbito.Text = "";
                    cRetirada.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao atualizar os dados do cadáver: " + ex.Message);
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
