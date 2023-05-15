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
    public partial class DadosE : Form
    {
        public DadosE()
        {
            InitializeComponent();
            // Define o modo de seleção do DataGridView como seleção de linha completa

            dDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarregarDados();
            this.Shown += DadosE_Shown;
        }
        private void DadosE_Shown(object sender, EventArgs e)
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
                string query = "SELECT Id, Fornecedor, Material, Quantidade, SUM(Quantidade) OVER (PARTITION BY Material) AS Total FROM estoque ORDER BY Id";

                MySqlCommand cmd = new MySqlCommand(query, Conexao.con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    // Vincula os resultados à DataGridView
                    dDados.DataSource = dataTable;

                    // Define a propriedade DataPropertyName das colunas correspondentes
                    dDados.Columns["Id"].DataPropertyName = "Id";
                    dDados.Columns["Fornecedor"].DataPropertyName = "Fornecedor";
                    dDados.Columns["Material"].DataPropertyName = "Material";
                    dDados.Columns["Quantidade"].DataPropertyName = "Quantidade";
                    dDados.Columns["Total"].DataPropertyName = "Total";
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
        { // Verifica se o campo de material está vazio

            if (string.IsNullOrWhiteSpace(textMaterial.Text))
            {  // Mostra uma mensagem de erro e interrompe o processamento da função
                MessageBox.Show("Por favor, preencha o campo material");

            }
            else // Mostra uma mensagem de sucesso e limpa o campo de material
            {
                try
                {
                    string material = textMaterial.Text;

                    Conexao conexao = new Conexao();
                    conexao.Abrir();

                    // Consulta na tabela estoque para obter o valor da coluna "Total"
                    string queryEstoque = "SELECT Total FROM estoque WHERE Material = @material";
                    MySqlCommand cmdEstoque = new MySqlCommand(queryEstoque, Conexao.con);
                    cmdEstoque.Parameters.AddWithValue("@material", material);
                    object resultEstoque = cmdEstoque.ExecuteScalar();
                    int totalEstoque = resultEstoque != DBNull.Value ? Convert.ToInt32(resultEstoque) : 0;

                    // Consulta na tabela cadaver para obter o valor da coluna "Quantidade"
                    string queryCadaver = "SELECT Quantidade FROM cadaver WHERE Material = @material";
                    MySqlCommand cmdCadaver = new MySqlCommand(queryCadaver, Conexao.con);
                    cmdCadaver.Parameters.AddWithValue("@material", material);
                    object resultCadaver = cmdCadaver.ExecuteScalar();
                    int quantidadeCadaver = resultCadaver != DBNull.Value ? Convert.ToInt32(resultCadaver) : 0;
                    if (totalEstoque > 0)
                    {
                        int resultado = totalEstoque-quantidadeCadaver  ;

                     
                        // Resto do código...

                        string query = "SELECT Id, Fornecedor, Material, Quantidade, SUM(Quantidade) OVER (PARTITION BY Material) AS Total FROM estoque WHERE Material = @material";
                        MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                        cmd.Parameters.AddWithValue("@material", material);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            // Vincula os resultados à DataGridView
                            dDados.DataSource = dataTable;

                            // Define a propriedade DataPropertyName das colunas correspondentes
                            dDados.Columns["Id"].DataPropertyName = "Id";
                            dDados.Columns["Fornecedor"].DataPropertyName = "Fornecedor";
                            dDados.Columns["Material"].DataPropertyName = "Material";
                            dDados.Columns["Quantidade"].DataPropertyName = "Quantidade";
                            dDados.Columns["Total"].DataPropertyName = "Total";

                            MessageBox.Show("Localizado com sucesso");
                            textMaterial.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Nenhum resultado encontrado.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Material não encontrado na tabela estoque.");
                    }

                    conexao.Fechar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
                }



            }
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {   // Oculta a tela atual
            this.Hide();
            // Cria uma nova instância da classe Admin1
            Admin1 novaTela = new Admin1();
            // Mostra a nova instância da janela Admin1
            novaTela.ShowDialog();
        }
    }
}
