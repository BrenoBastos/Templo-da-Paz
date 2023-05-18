﻿using MySql.Data.MySqlClient;
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
            listarfornecedor();
            listarmaterial();

        }
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
            cMaterial.SelectedIndex = 0;
            cMaterial.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void listarfornecedor()
        {
            Conexao conexao = new Conexao();
            conexao.Abrir();
            try
            {
                string query = "SELECT Nome FROM fornecedor WHERE Status = 'Ativo'";

                MySqlCommand command = new MySqlCommand(query, Conexao.con);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nome = reader.GetString("Nome");
                    cFornecedor.Items.Add(nome);
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
            cFornecedor.SelectedIndex = 0;
            cFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void button1_Click(object sender, EventArgs e)
        {    // Verifica se os campos obrigatórios foram preenchidos

            if ( string.IsNullOrWhiteSpace(textQuantidade.Text))
            {
                // Verifica se algum dos campos está vazio ou contém apenas espaços em branco
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }


          else  if (!textQuantidade.Text.All(char.IsDigit))
            {    // Verifica se o campo quantidade contém somente dígitos

                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Quantidade'.");
                textQuantidade.Text = "";
                return;
            }    // Verifica se o campo fornecedor não contém somente dígitos

         
            else
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.Abrir();

                    string material = cMaterial.SelectedItem.ToString();
                    string fornecedor = cFornecedor.SelectedItem.ToString();
                    string quantidade = textQuantidade.Text;

                    // Verifica se o material existe na tabela "material"
                    string verificaMaterialQuery = $"SELECT COUNT(*) FROM estoque WHERE Material = @material";
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
                                cMaterial.SelectedIndex = 0;

                                cFornecedor.SelectedIndex = 0;
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
                    conexao.Fechar();

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
