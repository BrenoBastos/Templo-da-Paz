﻿using MySql.Data.MySqlClient;
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
    public partial class CadastrarE : Form
    {
        public CadastrarE()
        {
            InitializeComponent();
            listar();
            cFornecedor.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            cFornecedor.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            cFornecedor.Height = 30;
           textMaterial.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textMaterial.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textMaterial.Height = 30;
            CenterToScreen();
            BackColor = Color.FromArgb(64, 49, 49);
        }
        private void listar()
        {
            bCadastrar.FlatAppearance.MouseOverBackColor = bCadastrar.BackColor;
            bCadastrar.FlatAppearance.MouseDownBackColor = bCadastrar.BackColor;
            bVoltar.FlatAppearance.MouseOverBackColor = bVoltar.BackColor;
            bVoltar.FlatAppearance.MouseDownBackColor = bVoltar.BackColor;
            cFornecedor.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            textMaterial.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            textQuantidade.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            cFornecedor.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
          textMaterial.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textQuantidade.BackColor = Color.FromArgb(0x81, 0x66, 0x66);




            textQuantidade.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            cFornecedor.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
           textMaterial.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);



            int borderRadius = 10; // Define o raio da borda arredondada

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(textQuantidade.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textQuantidade.Width - borderRadius, textQuantidade.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textQuantidade.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textQuantidade.Region = new Region(path);

            }
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(textMaterial.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textMaterial.Width - borderRadius, textMaterial.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textMaterial.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textQuantidade.Region = new Region(path);

            }
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

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textMaterial.Text) || string.IsNullOrWhiteSpace(textQuantidade.Text) )
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
       
            else
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.Abrir();

                    string material = textMaterial.Text;
                    string fornecedor = cFornecedor.SelectedItem.ToString(); // Obtém o fornecedor selecionado do ComboBox
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
                                MessageBox.Show("Cadastrado com sucesso");
                                textMaterial.Text = "";
                                cFornecedor.SelectedIndex = 0;
                                textQuantidade.Text = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não encontrado na tabela 'fornecedor'. Cadastre o fornecedor antes de adicionar um item ao estoque.");
                    }
                    conexao.Fechar();
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

        private void CadastrarE_Load(object sender, EventArgs e)
        {

        }
    }
}

