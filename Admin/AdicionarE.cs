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
    public partial class AdicionarE : Form
    {
        public AdicionarE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    // Verifica se os campos obrigatórios foram preenchidos

            if (string.IsNullOrWhiteSpace(textMaterial.Text) || string.IsNullOrWhiteSpace(textQuantidade.Text) || string.IsNullOrWhiteSpace(textFornecedor.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }



            else if (!textQuantidade.Text.All(char.IsDigit))
            {    // Verifica se o campo quantidade contém somente dígitos

                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Quantidade'.");
                textQuantidade.Text = "";
                return;
            }    // Verifica se o campo fornecedor não contém somente dígitos

            else if (textFornecedor.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres  no campo 'Fornecedor'.");
                textFornecedor.Text = "";

            }
            else
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.Abrir();

                    string material = textMaterial.Text;
                    string fornecedor = textFornecedor.Text;
                    string quantidade = textQuantidade.Text;

                    // Verifica se o material existe na tabela "material"
                    string verificaMaterialQuery = $"SELECT COUNT(*) FROM estoque WHERE material = @material";
                    MySqlCommand verificaMaterialCmd = new MySqlCommand(verificaMaterialQuery, Conexao.con);
                    verificaMaterialCmd.Parameters.AddWithValue("@material", material);

                    int materialCount = Convert.ToInt32(verificaMaterialCmd.ExecuteScalar());

                    if (materialCount > 0)
                    {
                        // O material existe, pode prosseguir com a adição do registro

                        // Verifica se o fornecedor existe na tabela "fornecedor"
                        string verificaFornecedorQuery = $"SELECT COUNT(*) FROM fornecedor WHERE Nome = @fornecedor AND Status = 'ativo'";
                        MySqlCommand verificaFornecedorCmd = new MySqlCommand(verificaFornecedorQuery, Conexao.con);
                        verificaFornecedorCmd.Parameters.AddWithValue("@fornecedor", fornecedor);

                        int fornecedorCount = Convert.ToInt32(verificaFornecedorCmd.ExecuteScalar());

                        if (fornecedorCount > 0)
                        {
                            // O fornecedor existe, pode prosseguir com a adição do registro

                            string query = $"INSERT INTO estoque (Material, Fornecedor, Quantidade) " +
                                           $"VALUES (@material, @fornecedor, @quantidade)";

                            MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                            cmd.Parameters.AddWithValue("@material", material);
                            cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
                            cmd.Parameters.AddWithValue("@quantidade", quantidade);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Adicionado com sucesso");
                                textMaterial.Text = "";
                                textFornecedor.Text = "";
                                textQuantidade.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Fornecedor não encontrado na tabela 'fornecedor'ou Fornecedor inativo.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Material não encontrado na tabela 'material'. Verifique o nome do material ou cadastre-o antes de adicionar um item ao estoque.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
                }

            }
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            // Esconde a tela atual
            this.Hide();

            // Cria uma nova instância da tela Admin1 e a exibe como diálogo
            Admin1 novaTela = new Admin1();
            novaTela.ShowDialog();
        }
    }
}
