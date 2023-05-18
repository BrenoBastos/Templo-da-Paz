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
            listarmaterial();
            listarassistente();
            listarlegista();

        }// Método que inicializa a ComboBox
        private void listarmaterial()
        {
            Conexao conexao = new Conexao();
            conexao.Abrir();
            try
            {
                string query = "SELECT Material FROM estoque";

                MySqlCommand command = new MySqlCommand(query, Conexao.con);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nome = reader.GetString("Material");

                    if (!cMaterial.Items.Contains(nome))
                    {
                        cMaterial.Items.Add(nome);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Trate exceções ou exiba mensagens de erro conforme necessário
            }
            finally
            {
                conexao.Fechar();
            }
            cMaterial.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void listarassistente()
        {
            Conexao conexao = new Conexao();
            conexao.Abrir();
            try
            {
                string query = "SELECT Nome FROM assistente WHERE Status = 'Ativo'";

                MySqlCommand command = new MySqlCommand(query, Conexao.con);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nome = reader.GetString("Nome");

                    if (!cAssistente.Items.Contains(nome))
                    {
                        cAssistente.Items.Add(nome);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Trate exceções ou exiba mensagens de erro conforme necessário
            }
            finally
            {
                conexao.Fechar();
            }
            cAssistente.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void listarlegista()
        {
            Conexao conexao = new Conexao();
            conexao.Abrir();
            try
            {
                string query = "SELECT Nome FROM legista WHERE Status = 'Ativo' ";

                MySqlCommand command = new MySqlCommand(query, Conexao.con);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nome = reader.GetString("Nome");

                    if (!cLegista.Items.Contains(nome))
                    {
                        cLegista.Items.Add(nome);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Trate exceções ou exiba mensagens de erro conforme necessário
            }
            finally
            {
                conexao.Fechar();
            }
            cLegista.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void comboBoxiniciar()
        {    // Verifica se o ComboBox já foi preenchido antes

            if (cRetirada.Items.Count == 0)
            {        // Adiciona as opções ao ComboBox

                cRetirada.Items.Add("Espera");
                cRetirada.Items.Add("Velório Municipal");
                cRetirada.Items.Add("Funerária");
                // Seleciona o primeiro item por padrão

                // Define o estilo do ComboBox para "DropDownList", que impede que o usuário digite valores

                cRetirada.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
        public void CarregarDetalhes(string id, string nome, string assistente, string gaveta, string dataChegada, string horarioChegada, string laudo, string material, string quantidade, string dataRetirada, string horarioRetirada, string dataObito, string horarioObito, string retirada,string legista)
        {
            // Atribua os valores aos controles da janela DadosCadaverLM
            textID.Text = id;
            textNome.Text = nome;
            cAssistente.SelectedItem = assistente;
            textGaveta.Text = gaveta;
            mDataChegada.Text = dataChegada;
           mHorarioChegada.Text = horarioChegada;
            textLaudo.Text = laudo;
            cMaterial.SelectedIndex = cMaterial.FindStringExact(material);
            textQuantidade.Text = quantidade;
           mDataRetirada.Text = dataRetirada;
           mHorarioRetirada.Text = horarioRetirada;
            mDataObito.Text = dataObito;
            mHorárioÓbito.Text = horarioObito;
            cLegista.SelectedItem = legista;

            // Selecionar o valor correto no ComboBox de Retirada
            cRetirada.SelectedItem = retirada;
        }


        private void bAlterar_Click(object sender, EventArgs e)
        {
            // Verifica se algum campo obrigatório está vazio ou não preenchido corretamente
            if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(textID.Text) || string.IsNullOrWhiteSpace(textGaveta.Text) || string.IsNullOrWhiteSpace(textLaudo.Text)
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
            else if (!Regex.IsMatch(textGaveta.Text, "^[A-Z]{1}$")) // Verifica se o campo Gaveta contém apenas um caractere em maiúscula
            {
                // Exibe uma mensagem de erro informando que o campo Gaveta deve conter apenas um caractere em maiúscula
                MessageBox.Show("Por favor, insira apenas um caractere em maiúscula no campo 'Gaveta'.");
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
            // Se todos os campos estiverem preenchidos corretamente
            else
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.Abrir();

                    string id = textID.Text;
                    string nome = textNome.Text;
                    string gaveta = textGaveta.Text;
                    string material = cMaterial.SelectedItem.ToString();

                    string laudo = textLaudo.Text;
                    string dataChegada = mDataChegada.Text;
                    string dataRetirada = mDataRetirada.Text;
                    string horarioChegada = mHorarioChegada.Text;
                    string assistente = cAssistente.SelectedItem.ToString();
                    string legista = cLegista.SelectedItem.ToString();


                    string horarioRetirada = mHorarioRetirada.Text;
                    string dataObito = mDataObito.Text;
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




                    // Atualiza os dados do cadáver no banco de dados
                    string queryUpdateCadaver = "UPDATE cadaver SET Nome = @nome, Gaveta = @gaveta, Laudo = @laudo, Material = @material, Quantidade = @quantidade, DataChegada = @dataChegada, dataRetirada = @dataRetirada, horarioChegada = @horarioChegada, Assistente = @assistente, Legista = @legista, HorarioRetirada = @horarioRetirada, DataObito = @dataObito, HorarioObito = @horarioObito, Retirada = @retirada WHERE Id = @id";
                    MySqlCommand cmdUpdateCadaver = new MySqlCommand(queryUpdateCadaver, Conexao.con);

                    cmdUpdateCadaver.Parameters.AddWithValue("@nome", nome);
                    cmdUpdateCadaver.Parameters.AddWithValue("@gaveta", gaveta);
                    cmdUpdateCadaver.Parameters.AddWithValue("@laudo", laudo);
                    cmdUpdateCadaver.Parameters.AddWithValue("@material", material);
                    cmdUpdateCadaver.Parameters.AddWithValue("@quantidade", quantidade);
                    cmdUpdateCadaver.Parameters.AddWithValue("@dataChegada", dataChegada);
                    cmdUpdateCadaver.Parameters.AddWithValue("@dataRetirada", dataRetirada);
                    cmdUpdateCadaver.Parameters.AddWithValue("@horarioChegada", horarioChegada);
                    cmdUpdateCadaver.Parameters.AddWithValue("@assistente", assistente);
                    cmdUpdateCadaver.Parameters.AddWithValue("@legista", legista);
                    cmdUpdateCadaver.Parameters.AddWithValue("@horarioRetirada", horarioRetirada);
                    cmdUpdateCadaver.Parameters.AddWithValue("@dataObito", dataObito);
                    cmdUpdateCadaver.Parameters.AddWithValue("@horarioObito", horarioobito);
                    cmdUpdateCadaver.Parameters.AddWithValue("@retirada", retirada);
                    cmdUpdateCadaver.Parameters.AddWithValue("@id", id);

                    cmdUpdateCadaver.ExecuteNonQuery();


                    // Exibe uma mensagem de sucesso e limpa todos os campos
                    MessageBox.Show("Alterado com sucesso");
                    textNome.Text = "";
                    textID.Text = "";
                    textGaveta.Text = "";
                    textLaudo.Text = "";
                    cMaterial.SelectedIndex = 0;
                    textQuantidade.Text = "";
                    mDataChegada.Text = "";
                    mDataRetirada.Text = "";
                    mHorarioChegada.Text = "";
                    cAssistente.SelectedIndex = 0;
                    cLegista.SelectedIndex = 0;
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
