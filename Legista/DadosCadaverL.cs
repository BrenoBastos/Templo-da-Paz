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
    public partial class DadosCadaverL : Form
    {
        public DadosCadaverL()
        {
            InitializeComponent();
            // Define o modo de seleção do DataGridView como seleção de linha completa

            dDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarregarDados();
            this.Shown += DadosCadaverL_Shown;
        }
        private void DadosCadaverL_Shown(object sender, EventArgs e)
        {
            CarregarDados(); // Chama o método para carregar os dados no DataGridView
            MessageBox.Show("Dados carregados com sucesso");

        }

        private void CarregarDados()
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Abrir();

                string query = "SELECT Id, Nome, Gaveta, Assistente, Legista, DataChegada, HorarioChegada, DataRetirada, Retirada FROM cadaver WHERE Retirada IS NOT NULL";
                MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    // Vincula os resultados à DataGridView
                    dDados.DataSource = dataTable;

                    // Define a propriedade DataPropertyName das colunas correspondentes
                    dDados.Columns["ID"].DataPropertyName = "ID";
                    dDados.Columns["Nome"].DataPropertyName = "Nome";
                    dDados.Columns["Gaveta"].DataPropertyName = "Gaveta";
                    dDados.Columns["Assistente"].DataPropertyName = "Assistente";
                    dDados.Columns["Legista"].DataPropertyName = "Legista";
                    dDados.Columns["DataChegada"].DataPropertyName = "DataChegada";
                    dDados.Columns["HorarioChegada"].DataPropertyName = "HorarioChegada";
                    dDados.Columns["DataRetirada"].DataPropertyName = "DataRetirada";
                    dDados.Columns["Retirada"].DataPropertyName = "Retirada";



                }
                else
                {
                    MessageBox.Show("Nenhum resultado encontrado.");
                }

                conexao.Fechar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
            }
        }

        private void bLocalizar_Click(object sender, EventArgs e)
        { // Verifica se o campo de nome está vazio
            if (string.IsNullOrWhiteSpace(textNome.Text))
            {  // Mostra uma mensagem de erro e interrompe o processamento da função
                MessageBox.Show("Campo 'Nome' vazio, preencha-o!");
                return;

            }

            else
            { // Verifica se o campo de nome contém apenas caracteres alfabéticos
                if (textNome.Text.All(char.IsDigit))
                {// Mostra uma mensagem de erro e interrompe o processamento da função
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                    return;
                }
                else
                {


                    try
                    {
                        string nome = textNome.Text;

                        Conexao conexao = new Conexao();
                        conexao.Abrir();

                        string query = "SELECT Id,  Nome,Gaveta,Assistente,Legista,DataChegada,HorarioChegada,DataRetirada,Retirada FROM cadaver WHERE Nome = @nome";
                        MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                        cmd.Parameters.AddWithValue("@nome", nome);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            // Vincula os resultados à DataGridView
                            dDados.DataSource = dataTable;

                            // Define a propriedade DataPropertyName das colunas correspondentes
                            dDados.Columns["ID"].DataPropertyName = "ID";
                            dDados.Columns["Nome"].DataPropertyName = "Nome";
                            dDados.Columns["Gaveta"].DataPropertyName = "Gaveta";
                            dDados.Columns["Assistente"].DataPropertyName = "Assistente";
                            dDados.Columns["Legista"].DataPropertyName = "Legista";
                            dDados.Columns["DataChegada"].DataPropertyName = "DataChegada";
                            dDados.Columns["HorarioChegada"].DataPropertyName = "HorarioChegada";
                            dDados.Columns["DataRetirada"].DataPropertyName = "DataRetirada";
                            dDados.Columns["Retirada"].DataPropertyName = "Retirada";





                            MessageBox.Show("Localizado com sucesso");
                            textNome.Text = "";
                            conexao.Fechar();

                        }
                        else
                        {
                            MessageBox.Show("Nenhum resultado encontrado.");
                            conexao.Fechar();

                        }








                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
                    }
                }
            }
        }

        private void dDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
        }


        private void bVoltar_Click(object sender, EventArgs e)
        {// Oculta a tela atual
            this.Hide();
            // Cria uma nova instância da classe  Legista
            Legista novaTela = new Legista();
            // Mostra a nova instância da janela   Legista 

            novaTela.ShowDialog();
        }

        private void dDados_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se há uma célula selecionada
            if (e.RowIndex >= 0)
            {
                // Obtém o valor do ID da célula selecionada
                string id = dDados.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                try
                {
                    // Executa uma consulta para obter os dados correspondentes ao ID
                    Conexao conexao = new Conexao();
                    conexao.Abrir();

                    string query = "SELECT Id,Nome , Gaveta , Laudo , Material , Quantidade , DataChegada , DataRetirada , HorarioChegada , Assistente , Legista , HorarioRetirada , DataObito , HorarioObito , Retirada  FROM cadaver WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string Id = reader.GetString("Id");
                            string nome = reader.GetString("Nome");
                            string gaveta = reader.GetString("Gaveta");
                            string assistente = reader.GetString("Assistente");
                            string dataChegada = reader.GetString("DataChegada");
                            string horarioChegada = reader.GetString("HorarioChegada");
                            string laudo = reader.GetString("Laudo");
                            string material = reader.GetString("Material");
                            string quantidade = reader.GetString("Quantidade");
                            string dataRetirada = reader.GetString("DataRetirada");
                            string horarioRetirada = reader.GetString("HorarioRetirada");
                            string dataObito = reader.GetString("DataObito");
                            string legista = reader.GetString("Legista");

                            string horarioObito = reader.GetString("HorarioObito");
                            string retirada = reader.GetString("Retirada");
                            // Cria uma nova instância da classe AlterarCadaverA
                            DadosCadaverLM detalhesForm = new DadosCadaverLM();

                            detalhesForm.CarregarDetalhes(Id, nome, assistente, gaveta, dataChegada, horarioChegada, laudo, material, quantidade, dataRetirada, horarioRetirada, dataObito, horarioObito, retirada,legista);

                            // Chama o método CarregarDetalhes e passa os valores obtidos

                            // Oculta a tela atual e mostra a nova instância da janela AlterarCadaverA
                            this.Hide();
                            detalhesForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum dado encontrado para o ID selecionado.");
                        }
                    }

                    conexao.Fechar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
                }
            }
        }
    }
}
