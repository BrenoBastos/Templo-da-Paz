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
                {
                    try
                    {
                        string nome = textNome.Text;

                        Conexao conexao = new Conexao();
                        conexao.Abrir();

                        string query = "SELECT Id,  Nome,Gaveta,Assistente,Legista,DataCheg,HorarioCheg,DataReti,Retirada FROM cadaver WHERE Nome = @nome";
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
                            dDados.Columns["Status"].DataPropertyName = "Status";
                            dDados.Columns["Gaveta"].DataPropertyName = "Gaveta";
                            dDados.Columns["Assistente"].DataPropertyName = "Assistente";
                            dDados.Columns["Legista"].DataPropertyName = "Legista";
                            dDados.Columns["DataCheg"].DataPropertyName = "DataCheg";
                            dDados.Columns["HorarioCheg"].DataPropertyName = "HorarioCheg";
                            dDados.Columns["DataReti"].DataPropertyName = "DataReti";
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

        private void dDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

                    string query = "SELECT Id,  Nome,Gaveta,Assistente,DataCheg,HorarioCheg, FROM cadaver WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtém os valores do leitor de dados
                            string Id = reader.GetString("Id");
                            string nome = reader.GetString("Nome");
                            string gaveta = reader.GetString("Gaveta");
                            string assistente = reader.GetString("Assistente");
                            string dataCheg = reader.GetString("DataCheg");
                            string horarioCheg = reader.GetString("HorarioCheg");
                           
                            // Cria uma nova instância da classe DetalhesPessoaForm
                            AlterarCadaverA detalhesForm = new AlterarCadaverA();

                            // Chama o método CarregarDetalhes e passa os valores obtidos
                            detalhesForm.CarregarDetalhes(Id, nome, assistente, gaveta, dataCheg, horarioCheg );

                            // Mostra a nova instância da janela DetalhesPessoaForm
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
