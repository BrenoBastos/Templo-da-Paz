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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CadastrarA : Form
    {
        public CadastrarA()
        {
            InitializeComponent();

            // Define o caractere a ser exibido no lugar dos caracteres digitados pelo usuário.
            // Nesse caso, o caractere "*" será exibido.
            textSenha.PasswordChar = '*';

            comboBoxiniciar1();
            comboBoxiniciar2();
            comboBoxiniciar3();
            comboBoxiniciar4();
            FormatarContato();

            cStatus.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            cStatus.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            cStatus.Height = 30;

            cContato.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            cContato.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            cContato.Height = 30;
            cEstadoCivil.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            cEstadoCivil.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            cEstadoCivil.Height = 30;

            cSexo.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            cSexo.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            cSexo.Height = 30;
            BackColor = Color.FromArgb(64, 49, 49);

            mCelular.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            mCelular.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            mCelular.Height = 30;

           mDataNascimento.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            mDataNascimento.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            mDataNascimento.Height = 30;

            textRG.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textRG.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
           textRG.Height = 30;
           textCpf.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textCpf.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textCpf.Height = 30;


        }
      
        // Método para iniciar o primeiro combo box de Estado Civil
        private void comboBoxiniciar1()
        {
         
            bCadastrar.FlatAppearance.MouseOverBackColor = bCadastrar.BackColor;
            bCadastrar.FlatAppearance.MouseDownBackColor = bCadastrar.BackColor;
            bVoltar.FlatAppearance.MouseOverBackColor = bVoltar.BackColor;
            bVoltar.FlatAppearance.MouseDownBackColor = bVoltar.BackColor;

      mDataNascimento.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
           mCelular.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
         textCpf.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
           textEndereco.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
         textNome.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
           textRG.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
         cSexo.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
           cStatus.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            cEstadoCivil.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            cContato.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            textSenha.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura

            mDataNascimento.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            mCelular.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textCpf.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textEndereco.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textNome.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textRG.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textSenha.BackColor = Color.FromArgb(0x81, 0x66, 0x66);

            mDataNascimento.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            mCelular.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textCpf.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textEndereco.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textNome.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textRG.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textSenha.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);

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
                path.AddArc(mDataNascimento.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(mDataNascimento.Width - borderRadius, mDataNascimento.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, mDataNascimento.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                mDataNascimento.Region = new Region(path);
            }
            using (GraphicsPath path = new GraphicsPath())

            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(mCelular.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(mCelular.Width - borderRadius, mCelular.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, mCelular.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                mCelular.Region = new Region(path);
            }
            using (GraphicsPath path = new GraphicsPath())

            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(textCpf.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc (textCpf.Width - borderRadius,    textCpf.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textCpf.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textCpf.Region = new Region(path);
            }
            using (GraphicsPath path = new GraphicsPath())

            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(textEndereco.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textEndereco.Width - borderRadius, textEndereco.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textEndereco.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textEndereco.Region = new Region(path);
            }
            using (GraphicsPath path = new GraphicsPath())

            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(textRG.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textRG.Width - borderRadius, textRG.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textRG.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textRG.Region = new Region(path);
            }
            using (GraphicsPath path = new GraphicsPath())

            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(textSenha.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textSenha.Width - borderRadius, textSenha.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textSenha.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textSenha.Region = new Region(path);
            }
            // Verifica se o combo box está vazio
            if (cEstadoCivil.Items.Count == 0)
            {
                // Adiciona os valores no combo box
                cEstadoCivil.Items.Add("Solteiro(a)");
                cEstadoCivil.Items.Add("Casado(a)");
                cEstadoCivil.Items.Add("União Estável");
                cEstadoCivil.Items.Add("Viúvo(a)");

                // Seleciona o primeiro valor do combo box
                cEstadoCivil.SelectedIndex = 0;

                // Define que o usuário não pode digitar no combo box
                cEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        // Método para iniciar o segundo combo box de Sexo
        private void comboBoxiniciar2()
        {
            // Verifica se o combo box está vazio
            if (cSexo.Items.Count == 0)
            {
                // Adiciona os valores no combo box
                cSexo.Items.Add("Masculino");
                cSexo.Items.Add("Feminino");
                cSexo.Items.Add("Não definido");

                // Seleciona o primeiro valor do combo box
                cSexo.SelectedIndex = 0;

                // Define que o usuário não pode digitar no combo box
                cSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        // Método para iniciar o terceiro combo box de Status
        private void comboBoxiniciar3()
        {
            // Verifica se o combo box está vazio
            if (cStatus.Items.Count == 0)
            {
                // Adiciona os valores no combo box
                cStatus.Items.Add("Ativo");
                cStatus.Items.Add("Inativo");

                // Seleciona o primeiro valor do combo box
                cStatus.SelectedIndex = 0;

                // Define que o usuário não pode digitar no combo box
                cStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        // Método para iniciar o quarto combo box de Contato
        private void comboBoxiniciar4()
        {
            // Verifica se o combo box está vazio
            if (cContato.Items.Count == 0)
            {
                // Adiciona os valores no combo box
                cContato.Items.Add("Celular");
                cContato.Items.Add("Telefone");

                // Seleciona o primeiro valor do combo box
                cContato.SelectedIndex = 0;

                // Define que o usuário não pode digitar no combo box
                cContato.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        // Método para formatar o campo de senha
      

        // Método para formatar o campo de contato
        private void FormatarContato()
        {
            // Define a posição dos campos de celular e telefone
            

            // Define que o campo de celular está habilitado e deve ser exibido como uma máscara de telefone
            mCelular.Enabled = true;
            mCelular.Visible = true;

            // Limpa o valor do campo de celular
            mCelular.Text = "";
        }
    
    






        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {




        }


        private void bCadastrar_Click(object sender, EventArgs e)
        {// verifica se algum dos campos obrigatórios do formulário está vazio ou incompleto
            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted || !textRG.MaskCompleted ||
                                  string.IsNullOrWhiteSpace(textEndereco.Text) || !mDataNascimento.MaskCompleted || string.IsNullOrWhiteSpace(mCelular.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }


            // Verifica se o campo 'ID' contém apenas caracteres numéricos


            // Verifica se o campo 'Contato' contém um número de celular válido

            else if (cContato.SelectedItem.ToString() == "Celular" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{5}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas carecteres numéricos  no  campo 'Contato' inválido, preencha-o com um número de contato válido ");
                mCelular.Text = "";
                return;
            }
            // Verifica se o campo 'Contato' contém um número de telefone válido

            else if (cContato.SelectedItem.ToString() == "Telefone" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{4}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas carecteres numéricos  no  campo 'Contato' inválido, preencha-o com um número de contato válido ");
                mCelular.Text = "";
                return;
            }


            // Verifica se o campo 'Nome' contém apenas caracteres não numéricos

            else if (textNome.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                textNome.Text = "";
                return;
            }
            else
            {// Realiza o cadastro na tabela 'assistente'
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.Abrir();
                    string nome = textNome.Text;
                    string cpf = textCpf.Text;
                    string rg = textRG.Text;
                    string endereco = textEndereco.Text;
                    string dataNascimento = mDataNascimento.Text;
                    string celular = mCelular.Text;
                    string senha = textSenha.Text;
                    string senhaCriptografada = textSenha.Text;
                    string estadoCivil = string.Empty;
                    switch (cEstadoCivil.SelectedIndex)
                    {
                        case 0:
                            estadoCivil = "Solteiro(a)";
                            break;
                        case 1:
                            estadoCivil = "Casado(a)";
                            break;
                        case 2:
                            estadoCivil = "União Estável";
                            break;
                        case 3:
                            estadoCivil = "Viúvo(a)";
                            break;
                    }

                    string sexo = string.Empty;
                    switch (cSexo.SelectedIndex)
                    {
                        case 0:
                            sexo = "Masculino";
                            break;
                        case 1:
                            sexo = "Feminino";
                            break;
                        case 2:
                            sexo = "Não definido";
                            break;
                            // Adicione os casos para os outros valores do ComboBox cSexo, se houver
                    }

                    string status = string.Empty;
                    switch (cStatus.SelectedIndex)
                    {
                        case 0:
                            status = "Ativo";
                            break;
                        case 1:
                            status = "Inativo";
                            break;
                            // Adicione os casos para os outros valores do ComboBox cStatus, se houver
                    }
                    // Consultar o número atual de registros ativos
                    string countQuery = "SELECT COUNT(*) FROM assistente WHERE Status = 'Ativo'";
                    MySqlCommand countCmd = new MySqlCommand(countQuery, Conexao.con);
                    int registrosAtivos = Convert.ToInt32(countCmd.ExecuteScalar());

                    // Verificar se já existem 10 registros ativos
                    if (registrosAtivos >= 10)
                    {
                        // Exibir uma mensagem informando que o limite foi atingido
                        Console.WriteLine("Limite de registros ativos atingido. Não é possível cadastrar mais como ativo.");
                    }
                    else
                    {
                        // Agora você pode usar as variáveis estadoCivil, sexo e status em sua consulta SQL:

                        string query = $"INSERT INTO assistente (Nome, Cpf, Rg, Endereco, DataNasc, Contato, EstadoCivil, Sexo,Senha, Status) " +
                                   $"VALUES (@nome, @cpf, @rg, @endereco, @dataNascimento, @celular, @estadoCivil, @sexo,@senha, @status)";

                        MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@rg", rg);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                        cmd.Parameters.AddWithValue("@celular", celular);
                        cmd.Parameters.AddWithValue("@estadoCivil", estadoCivil);
                        cmd.Parameters.AddWithValue("@sexo", sexo);

                        cmd.Parameters.AddWithValue("@status", status);
                        using (SHA256 sha256 = SHA256.Create())
                        {
                            byte[] bytesSenha = Encoding.UTF8.GetBytes(senha);
                            byte[] hashSenha = sha256.ComputeHash(bytesSenha);
                            senhaCriptografada = Convert.ToBase64String(hashSenha);
                        }

                        cmd.Parameters.AddWithValue("@senha", senhaCriptografada);


                       
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cadastrado com sucesso");
                            textNome.Text = "";
                            textCpf.Text = "";
                            textRG.Text = "";
                            textEndereco.Text = "";
                            mDataNascimento.Text = "";
                            mCelular.Text = "";
                            textSenha.Text = "";
                            cEstadoCivil.SelectedIndex = 0;
                            cSexo.SelectedIndex = 0;
                            cContato.SelectedIndex = 0;
                            cStatus.SelectedIndex = 0;
                            conexao.Fechar();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
                }
               
                   
                
            } }

        private void mDataNascimento_Click(object sender, EventArgs e)
        {// Define o início da seleção como o caractere 0
            mDataNascimento.SelectionStart = 0;
            // Define o comprimento da seleção como 0
            mDataNascimento.SelectionLength = 0;
        }

        private void textRG_Click_1(object sender, EventArgs e)
        {// Define o início da seleção como o caractere 0
            textRG.SelectionStart = 0;
            // Define o comprimento da seleção como 0

            textRG.SelectionLength = 0;
        }

        private void textCpf_Click(object sender, EventArgs e)
        {// Define o início da seleção como o caractere 0
            textCpf.SelectionStart = 0;
            // Define o comprimento da seleção como 0
            textCpf.SelectionLength = 0;
        }

     

        private void bVoltar_Click(object sender, EventArgs e)
        {
            // Esconde a janela atual
            this.Hide();

            // Cria uma nova instância da janela "Admin1" e exibe-a como uma janela de diálogo modal
            Admin1 novaTela = new Admin1();
            novaTela.ShowDialog();
        }

       

        private void cContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se o item selecionado é "Celular"
            if (cContato.SelectedItem.ToString() == "Celular")
            {
                // Se for "Celular", exibe o campo de celular, oculta o campo de telefone e habilita o campo de número de celular
                mCelular.Enabled = true;
                mCelular.Visible = true;
                mCelular.Text = "";
       
            }
            // Caso contrário, verifica se o item selecionado é "Telefone"
            else if (cContato.SelectedItem.ToString() == "Telefone")
            {
                mCelular.Text = "";
                // Se for "Telefone", oculta o campo de celular, exibe o campo de telefone e limpa o campo de número de celular
               
            }
        }

        

        private void lSenha_Click(object sender, EventArgs e)
        {

           
        }

        private void lSenha_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

       
    }
    }

