using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            textSenha.PasswordChar = '*';
           BackColor = Color.FromArgb(39, 31, 31);
            textNome.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            textSenha.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            BotaoLogin.FlatAppearance.MouseOverBackColor = BotaoLogin.BackColor;
            BotaoLogin.FlatAppearance.MouseDownBackColor = BotaoLogin.BackColor;
            textSenha.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textNome.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textSenha.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textNome.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            button1.FlatAppearance.MouseOverBackColor = button1.BackColor;
            button1.FlatAppearance.MouseDownBackColor = button1.BackColor;
            button2.FlatAppearance.MouseOverBackColor = button2.BackColor;
            button2.FlatAppearance.MouseDownBackColor = button2.BackColor;
            int borderRadius = 10; // Define o raio da borda arredondada

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(textNome.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textNome.Width - borderRadius, textNome.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textNome.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textNome.Region = new Region(path);





            }
            using (GraphicsPath path = new GraphicsPath())

            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(textSenha.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textSenha.Width - borderRadius, textSenha.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textSenha.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textSenha.Region = new Region(path);
            }

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
          
        }
    }
}
