using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            BackColor = Color.FromArgb(64, 49, 49);
            textNome.Width = 706;

            dDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarregarDados();
            this.Shown += DadosCadaverA_Shown;
        }
        private void DadosCadaverA_Shown(object sender, EventArgs e)
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

                // Consulta na tabela estoque para obter os dados ordenados por Id
                string query = "SELECT Id,  Nome,Gaveta,Assistente,Legista,DataRetirada,Retirada FROM cadaver ";
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
                  
                    dDados.Columns["DataRetirada"].DataPropertyName = "DataRetirada";
                    dDados.Columns["Retirada"].DataPropertyName = "Retirada";

                    bLocalizar.FlatAppearance.MouseOverBackColor = bLocalizar.BackColor;
                    bLocalizar.FlatAppearance.MouseDownBackColor = bLocalizar.BackColor;
                    bVoltar.FlatAppearance.MouseOverBackColor = bVoltar.BackColor;
                    bVoltar.FlatAppearance.MouseDownBackColor = bVoltar.BackColor;
                    textNome.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
                    textNome.Font = new Font("Poppins", 15, FontStyle.Regular);
                    textNome.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
                    dDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                    dDados.Columns["ID"].DefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Regular);
                    dDados.Columns["Nome"].DefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Regular);
                    dDados.Columns["Gaveta"].DefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Regular);
                    dDados.Columns["Assistente"].DefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Regular);
                    dDados.Columns["Legista"].DefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Regular);
                    dDados.Columns["DataRetirada"].DefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Regular);
                    dDados.Columns["Retirada"].DefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Regular);




                  
                    dDados.Columns["ID"].HeaderCell.Style.Font = new Font("Poppins", 10, FontStyle.Regular);
                    dDados.Columns["Nome"].HeaderCell.Style.Font = new Font("Poppins", 10, FontStyle.Regular);
                    dDados.Columns["Gaveta"].HeaderCell.Style.Font = new Font("Poppins", 10, FontStyle.Regular);
                    dDados.Columns["Assistente"].HeaderCell.Style.Font = new Font("Poppins", 10, FontStyle.Regular);
                    dDados.Columns["Legista"].HeaderCell.Style.Font = new Font("Poppins", 10, FontStyle.Regular);
                    dDados.Columns["DataRetirada"].HeaderCell.Style.Font = new Font("Poppins", 10, FontStyle.Regular);
                    dDados.Columns["Retirada"].HeaderCell.Style.Font = new Font("Poppins", 10, FontStyle.Regular);






                    dDados.BackgroundColor = System.Drawing.Color.FromArgb(151, 128, 128);
                    dDados.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(151, 128, 128);
                    dDados.EnableHeadersVisualStyles = false; // Desabilita o estilo visual padrão dos cabeçalhos
                 
                    
                    dDados.Columns["ID"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128);
                    dDados.Columns["Nome"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128);
                    dDados.Columns["Gaveta"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128);
                    dDados.Columns["Assistente"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128);
                    dDados.Columns["Legista"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128);
                    dDados.Columns["DataRetirada"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128);
                    dDados.Columns["Retirada"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128);











                    dDados.DefaultCellStyle.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF); // Define a cor do texto do cabeçalho           
                    dDados.RowHeadersVisible = false;
                    dDados.RowTemplate.Height = 25; // Define a altura das células
                    dDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                    dDados.Columns["Nome"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128); // Define a cor de fundo do cabeçalho
                    dDados.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF); // Define a cor do texto do cabeçalho        
                    int borderRadius = 10; // Define o raio da borda arredondada

                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                        path.AddArc(textNome.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                        path.AddArc(textNome.Width - borderRadius, textNome.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                        path.AddArc(0, textNome.Height - borderRadius, borderRadius, borderRadius, 90, 90);

                        textNome.Region = new Region(path);
                    }


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

                        string query = "SELECT Id,  Nome,Gaveta,Assistente,Legista,DataRetirada,Retirada FROM cadaver WHERE Nome = @nome";
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

                    string query = "SELECT Id, Nome, Gaveta, Assistente, DataChegada, HorarioChegada FROM cadaver WHERE Id = @id";
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
                            string dataChegada = reader.GetString("DataChegada");
                            string horarioChegada = reader.GetString("HorarioChegada");

                            // Cria uma nova instância da classe AlterarCadaverA
                            AlterarCadaverA detalhesForm = new AlterarCadaverA();

                            // Chama o método CarregarDetalhes e passa os valores obtidos
                            detalhesForm.CarregarDetalhes(Id, nome, assistente, gaveta, dataChegada, horarioChegada);

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
