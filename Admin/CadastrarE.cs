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
    public partial class CadastrarE : Form
    {
        public CadastrarE()
        {
            InitializeComponent();
        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textMaterial.Text) || string.IsNullOrWhiteSpace(textQuantidade.Text) || string.IsNullOrWhiteSpace(textFornecedor.Text))
            {
                // Verifica se algum dos campos está vazio ou contém apenas espaços em branco
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            else if (!textQuantidade.Text.All(char.IsDigit))
            {
                // Verifica se o campo 'Quantidade' contém apenas caracteres numéricos
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Quantidade'.");
                textQuantidade.Text = "";
                return;
            }
            else if (textFornecedor.Text.All(char.IsDigit))
            {
                // Verifica se o campo 'Fornecedor' contém apenas caracteres não-numéricos
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Fornecedor'.");
                textFornecedor.Text = "";
                return;
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

                    // Verifica se o fornecedor existe na tabela "fornecedor"
                    string verificaFornecedorQuery = $"SELECT COUNT(*) FROM fornecedor WHERE Nome = @fornecedor AND Status = 'ativo'";
                    MySqlCommand verificaFornecedorCmd = new MySqlCommand(verificaFornecedorQuery, Conexao.con);
                    verificaFornecedorCmd.Parameters.AddWithValue("@fornecedor", fornecedor);

                    int fornecedorCount = Convert.ToInt32(verificaFornecedorCmd.ExecuteScalar());

                    if (fornecedorCount > 0)
                    {
                        // O fornecedor existe, pode prosseguir com a verificação do material

                        // Verifica se o material existe na tabela "estoque"
                        string verificaMaterialQuery = $"SELECT COUNT(*) FROM estoque WHERE Material = @material";
                        MySqlCommand verificaMaterialCmd = new MySqlCommand(verificaMaterialQuery, Conexao.con);
                        verificaMaterialCmd.Parameters.AddWithValue("@material", material);

                        int materialCount = Convert.ToInt32(verificaMaterialCmd.ExecuteScalar());

                        if (materialCount > 0)
                        {
                            MessageBox.Show("O material já existe na tabela 'estoque'.");
                        }
                        else
                        {
                            // O material não existe, pode prosseguir com o cadastro no estoque

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
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não encontrado na tabela 'fornecedor'. Cadastre o fornecedor antes de adicionar um item ao estoque.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
                }

            }
        }

        private void textMaterial_TextChanged(object sender, EventArgs e)
        {

        }

        private void Material_Click(object sender, EventArgs e)
        {

        }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            // Oculta a janela atual
            this.Hide();

            // Cria uma nova instância da janela Admin1
            Admin1 novaTela = new Admin1();

            // Mostra a nova janela em um modo de diálogo
            novaTela.ShowDialog();

        }
    }
}

