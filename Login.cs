using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            formatarCampoSenha();
        }
        private void formatarCampoSenha()
        {
            textSenha.UseSystemPasswordChar = true;
            textSenha.PasswordChar = '*';


        }
        private void BotaoLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(textSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else
            {

                // Verifica cada campo individualmente
                if (string.IsNullOrWhiteSpace(textNome.Text))
                {
                    MessageBox.Show("Campo 'Nome' vazio, preencha-o!");
                    return;
                }




                if (string.IsNullOrWhiteSpace(textSenha.Text))
                {
                    MessageBox.Show("Campo 'Senha' vazio, preencha-o!");
                    return;
                }








                else if (textNome.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                    return;
                }
                else
                {
                    Conexao conexao = new Conexao();
                    conexao.Abrir();

                    string nome = textNome.Text;
                    string senha = textSenha.Text;
                    string senhaCriptografada;

                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] bytesSenha = Encoding.UTF8.GetBytes(senha);
                        byte[] hashSenha = sha256.ComputeHash(bytesSenha);
                        senhaCriptografada = Convert.ToBase64String(hashSenha);
                    }


                    // Consulta SQL para verificar as credenciais e o status na tabela correspondente ao tipo de usuário
                    string query = $"SELECT * FROM admin WHERE Nome = @nome AND Senha = @senha";

                    MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@senha", senhaCriptografada);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Entrar com sucesso");
                        textNome.Text = "";
                        textSenha.Text = "";
                        this.Hide();

                        // Abrir a tela específica para o tipo de usuário Admin
                        Admin1 novaTela = new Admin1();
                        novaTela.ShowDialog();
                    }
                    else
                    {
                        reader.Close();

                        query = $"SELECT * FROM legista WHERE Nome = @nome AND Senha = @senha AND Status = 'Ativo'";

                        cmd = new MySqlCommand(query, Conexao.con);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@senha", senhaCriptografada);

                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Entrar com sucesso");
                            textNome.Text = "";
                            textSenha.Text = "";
                            this.Hide();

                            // Abrir a tela específica para o tipo de usuário Legista
                            Legista novaTela = new Legista();
                            novaTela.ShowDialog();
                        }
                        else
                        {
                            reader.Close();

                            query = $"SELECT * FROM assistente WHERE Nome = @nome AND Senha = @senha AND Status = 'Ativo'";

                            cmd = new MySqlCommand(query, Conexao.con);
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@senha", senhaCriptografada);

                            reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                MessageBox.Show("Entrar com sucesso");
                                textNome.Text = "";
                                textSenha.Text = "";
                                this.Hide();

                                // Abrir a tela específica para o tipo de usuário Assistente
                                Assistente novaTela = new Assistente();
                                novaTela.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Credenciais inválidas ou usuário não ativo");
                            }
                        }
                    }

                    reader.Close();
                    conexao.Fechar();

                }
            }
        }

        private void lSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textSenha.UseSystemPasswordChar)
            {
                textSenha.UseSystemPasswordChar = false;
                textSenha.PasswordChar = '\0';
                lSenha.Text = "OcultarSenha";
            }
            else
            {
                lSenha.Text = "MostrarSenha";
                textSenha.UseSystemPasswordChar = true;
                textSenha.PasswordChar = '*';
            }
        }
    }
}
