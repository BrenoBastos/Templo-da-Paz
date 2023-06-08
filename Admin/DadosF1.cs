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
    public partial class DadosF1 : Form
    {
        public DadosF1()
        {
            BackColor = Color.FromArgb(64, 49, 49);

            InitializeComponent();
            dDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarregarDados();
            this.Shown += DadosF1_Shown;
        }
        private void DadosF1_Shown(object sender, EventArgs e)
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

                string query = "SELECT Id, Status, Nome FROM fornecedor";
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
                    dDados.Columns["Status"].DataPropertyName = "Status";
                    bLocalizar.FlatAppearance.MouseOverBackColor = bLocalizar.BackColor;
                    bLocalizar.FlatAppearance.MouseDownBackColor = bLocalizar.BackColor;
                    bVoltar.FlatAppearance.MouseOverBackColor = bVoltar.BackColor;
                    bVoltar.FlatAppearance.MouseDownBackColor = bVoltar.BackColor;
                    textNome1.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
                    textNome1.Font = new Font("Poppins", 15, FontStyle.Regular);
                    textNome1.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
                    dDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                    dDados.Columns["ID"].DefaultCellStyle.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.Columns["Nome"].DefaultCellStyle.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.Columns["Status"].DefaultCellStyle.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.Columns["ID"].HeaderCell.Style.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.Columns["Nome"].HeaderCell.Style.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.Columns["Status"].HeaderCell.Style.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.BackgroundColor = System.Drawing.Color.FromArgb(151, 128, 128);
                    dDados.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(151, 128, 128);
                    dDados.EnableHeadersVisualStyles = false; // Desabilita o estilo visual padrão dos cabeçalhos
                    dDados.Columns["Status"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128); // Define a cor de fundo do cabeçalho
                    dDados.Columns["ID"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128); // Define a cor de fundo do cabeçalho
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
                        path.AddArc(textNome1.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                        path.AddArc(textNome1.Width - borderRadius, textNome1.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                        path.AddArc(0, textNome1.Height - borderRadius, borderRadius, borderRadius, 90, 90);

                        textNome1.Region = new Region(path);
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

    
    private void bVoltar_Click(object sender, EventArgs e)
        {
            // Oculta a tela atual
            this.Hide();
            // Cria uma nova instância da classe Admin1
            Admin1 novaTela = new Admin1();
            // Mostra a nova instância da janela Admin1
            novaTela.ShowDialog();
        }

        private void bLocalizar_Click(object sender, EventArgs e)
        {
             // Verifica se o campo de nome está vazio
            if (string.IsNullOrWhiteSpace(textNome1.Text))
            { // Mostra uma mensagem de erro e interrompe o processamento da função
                MessageBox.Show("Campo 'Nome' vazio, preencha-o!");
                return;
            }  // Verifica se o campo de nome contém apenas caracteres alfabéticos
            else if (textNome1.Text.All(char.IsDigit))
            { // Mostra uma mensagem de erro e interrompe o processamento da função
                MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                return;
            }
            else
{
    try
    {
        string nome = textNome1.Text;

        Conexao conexao = new Conexao();
        conexao.Abrir();

        string query = "SELECT Id, Status, Nome FROM fornecedor WHERE Nome = @nome";
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


            MessageBox.Show("Localizado com sucesso");
            textNome1.Text = "";
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

        private void dDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se há uma célula selecionada
            if (e.RowIndex >= 0)
            {
                // Obtém o valor do ID da célula selecionada
                string id = dDados.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                try
                {
                    Conexao conexao = new Conexao();

                    // Executa uma consulta para obter os dados correspondentes ao ID

                    conexao.Abrir();

                    string query = "SELECT Id, Nome, CPF, Endereco, Contato, Status FROM fornecedor WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtém os valores do leitor de dados
                            string Id = reader.GetString("Id");
                            string nome = reader.GetString("Nome");
                            string cpf = reader.GetString("CPF");
                            string endereco = reader.GetString("Endereco");
                            string contato = reader.GetString("Contato");
                            string status = reader.GetString("Status");

                            // Cria uma nova instância da classe AlterarF
                            AlterarF detalhesForm = new AlterarF();

                            // Chama o método CarregarDetalhes e passa os valores obtidos
                            detalhesForm.CarregarDetalhes(Id, nome, cpf, endereco, contato, status);

                            // Mostra a nova instância da janela AlterarF
                            this.Hide();
                            detalhesForm.ShowDialog();
                         

                        }
                        else
                        {
                            MessageBox.Show("Nenhum dado encontrado para o ID selecionado.");
                        }
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
                }
            }
        }
    }
}
