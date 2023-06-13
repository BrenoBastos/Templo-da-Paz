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
    public partial class AlterarA : Form
    {
        public AlterarA()
        {
            InitializeComponent();
            textSenha.PasswordChar = '*';

            CarregarCampos();

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
        // Define a variável pública "value".
        public int value;
       

        private void comboBoxiniciar3()
        {        // Inicia o combobox "cStatus" com duas opções e define a primeira opção como selecionada por padrão.
            button1.FlatAppearance.MouseOverBackColor = button1.BackColor;
            button1.FlatAppearance.MouseDownBackColor = button1.BackColor;
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
            textID.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura

            mDataNascimento.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            mCelular.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textCpf.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textEndereco.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textNome.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textRG.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textSenha.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textID.BackColor = Color.FromArgb(0x81, 0x66, 0x66);

            mDataNascimento.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            mCelular.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textCpf.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textEndereco.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textNome.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textRG.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textSenha.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textID.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);

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
                path.AddArc(textCpf.Width - borderRadius, textCpf.Height - borderRadius, borderRadius, borderRadius, 0, 90);
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
            using (GraphicsPath path = new GraphicsPath())

            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(textID.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textID.Width - borderRadius, textID.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textID.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textID.Region = new Region(path);
            }
            if (cStatus.Items.Count == 0)
            {
                cStatus.Items.Add("Ativo");
                cStatus.Items.Add("Inativo");
                // Define o valor do combobox " cStatus" como a primeira opção.

                cStatus.SelectedIndex = 0;
                // Define o estilo de exibição do combobox como DropDownList.

                cStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void comboBoxiniciar4()
        {        // Inicia o combobox "cContato" com três opções e define a primeira opção como selecionada por padrão.

            if (cContato.Items.Count == 0)
            {
                cContato.Items.Add("Contato");
                cContato.Items.Add("Celular");
                cContato.Items.Add("Telefone");

                cContato.SelectedIndex = 0;
                // Define o estilo de exibição do combobox como DropDownList.

                cContato.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        public void CarregarDetalhes(string Id,string nome, string cpf, string rg, string endereco, string dataNascimento, string senha, string estadoCivil, string sexo, string contato, string status)
        {
            textID.Text = Id.ToString();
            textNome.Text = nome;
            textCpf.Text = cpf;
            textRG.Text = rg;
            textEndereco.Text = endereco;
            mDataNascimento.Text = dataNascimento;
            mCelular.Text = contato;
            textSenha.Text = senha;
            cEstadoCivil.SelectedIndex = cEstadoCivil.FindStringExact(estadoCivil);
            cSexo.SelectedIndex = cSexo.FindStringExact(sexo);
            cContato.SelectedIndex = cContato.FindStringExact(contato);
            cStatus.SelectedIndex = cStatus.FindStringExact(status);
        }


        private void comboBoxiniciar1()
        {        // Inicia o combobox "cEstadoCivil" com quatro opções e define a primeira opção como selecionada por padrão.

            if (cEstadoCivil.Items.Count == 0)
            {
                cEstadoCivil.Items.Add("Solteiro(a)");
                cEstadoCivil.Items.Add("Casado(a)");
                cEstadoCivil.Items.Add("União Estável");
                cEstadoCivil.Items.Add("Viúvo(a)");

                cEstadoCivil.SelectedIndex = 0;
                // Define o estilo de exibição do combobox como DropDownList.

                cEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void comboBoxiniciar2()
        {        // Inicia o combobox "cSexo" com três opções e define a primeira opção como selecionada por padrão.

            if (cSexo.Items.Count == 0)
            {
                cSexo.Items.Add("Masculino");
                cSexo.Items.Add("Feminino");
                cSexo.Items.Add("Não definido");

                cSexo.SelectedIndex = 0;
                // Define o estilo de exibição do combobox como DropDownList.

                cSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void FormatarContato()
        {        // Define a posição dos controles "Contato1" e "mCelular".

            // Torna o controle "Celular" invisível.

          

            mCelular.Enabled = true;
            // Torna o controle "mCelular" visível.

            mCelular.Visible = true;
            // Define o valor do combobox "cContato" como a primeira opção.

            cContato.SelectedIndex = 0;
            // Limpa o valor do controle "mCelular".

            mCelular.Text = "";
        }

       
        private void CarregarCampos()
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void textCpf_Click(object sender, EventArgs e)
        {    // Quando o usuário clicar no campo de texto RG, selecionamos todo o texto do campo.

            textCpf.SelectionStart = 0;
            textCpf.SelectionLength = 0;
        }

        private void textRG_Click(object sender, EventArgs e)
        {
            // Quando o usuário clicar no campo de texto RG, selecionamos todo o texto do campo.
            textRG.SelectionStart = 0;

            textRG.SelectionLength = 0;
        }

        private void mDataNascimento_Click(object sender, EventArgs e)
        {    // Quando o usuário clicar no campo de texto de data de nascimento,
            mDataNascimento.SelectionStart = 0;
            // selecionamos todo o texto do campo para facilitar a edição.

            mDataNascimento.SelectionLength = 0;
        }

        private void mContato_Click(object sender, EventArgs e)
        {
          
        }

        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {

            
            

        }
        private void button1_Click(object sender, EventArgs e)
        {

            // Verifica se todos os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted || !textRG.MaskCompleted ||
                string.IsNullOrWhiteSpace(textEndereco.Text) || string.IsNullOrWhiteSpace(mCelular.Text) || !mDataNascimento.MaskCompleted)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // Verifica se o campo ID contém apenas caracteres numéricos
            else if (!textID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'ID'.");
                textID.Text = "";
                return;
            }

            // Verifica se o campo Nome contém apenas caracteres alfabéticos
            else if (textNome.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Nome'.");
                textNome.Text = "";
                return;
            }

            // Verifica se o campo Contato foi preenchido com um número de celular válido
            if (cContato.SelectedItem != null && cContato.SelectedItem.ToString() == "Celular" && mCelular != null && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{5}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Contato', preencha-o com um número de celular válido.");
                mCelular.Text = "";
                return;
            }

            // Verifica se o campo Contato foi preenchido com um número de telefone válido
            if (cContato.SelectedItem != null && cContato.SelectedItem.ToString() == "Telefone" && mCelular != null && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{4}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Contato', preencha-o com um número de telefone válido.");
                mCelular.Text = "";
                return;
            }

            // Caso nenhum erro seja encontrado, atualiza os dados do cliente
            else
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.Abrir();
                    string id = textID.Text; // Obtém o ID do assistente a ser atualizado
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

                    // Consultar o número atual de assistentes ativos
                    string countQuery = "SELECT COUNT(*) FROM assistente WHERE Status = 'Ativo'";
                    MySqlCommand countCmd = new MySqlCommand(countQuery, Conexao.con);
                    int assistentesAtivos = Convert.ToInt32(countCmd.ExecuteScalar());

                    // Verificar se já existem 10 assistentes ativos
                    if (assistentesAtivos >= 10 && status == "Ativo")
                    {
                        // Exibir uma mensagem informando que o limite foi atingido
                        MessageBox.Show("Limite de assistentes ativos atingido. Não é possível realizar mais alterações.");
                    }
                    else
                    {
                        // Agora você pode usar as variáveis estadoCivil, sexo e status em sua consulta SQL:
                        string query = $"UPDATE assistente SET Nome = @nome, Cpf = @cpf, Rg = @rg, Endereco = @endereco, " +
                            $"DataNasc = @dataNascimento, Contato = @celular, EstadoCivil = @estadoCivil, Sexo = @sexo, " +
                            $"Senha = @senha, Status = @status WHERE ID = @id";

                        MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                        cmd.Parameters.AddWithValue("@id", id);
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

                        cmd.Parameters.AddWithValue("@senha", senhaCriptografada); int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            if (status == "Ativo")
                            {
                                assistentesAtivos++;
                            }
                            else if (status == "Inativo")
                            {
                                assistentesAtivos--;
                            }

                            MessageBox.Show("Alterado com sucesso");
                            // Limpe os campos e restaure os valores padrão, se necessário
                            textID.Text = "";
                            textNome.Text = "";
                            textCpf.Text = "";
                            textRG.Text = "";
                            textEndereco.Text = "";
                            mDataNascimento.Text = "";
                            mCelular.Text = "";
                            textSenha.Text = "";
                            cEstadoCivil.SelectedIndex = 0;
                            cSexo.SelectedIndex = 0;
                            cStatus.SelectedIndex = 0;
                            // Esconde campos desnecessários
                          
                            mCelular.Enabled = true;
                            mCelular.Visible = true;
                            mCelular.Text = "";
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
    

        private void bVoltar_Click(object sender, EventArgs e)
        {// Esconde a janela atual antes de exibir uma nova
            this.Hide();
            // Cria uma nova instância do formulário DadosA
            DadosA1 novaTela = new DadosA1();
            // Exibe o formulário DadosA como uma caixa de diálogo
            novaTela.ShowDialog(); 

        }

        private void CContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cContato.SelectedItem != null && cContato.SelectedItem.ToString() == "Celular")
            {// Oculta o controle Contato1
                // Exibe o controle Celular

                // Oculta o controle Telefone
               
                // Habilita o controle de entrada de dados mCelular
                mCelular.Enabled = true;
                // Exibe o controle de entrada de dados mCelular
                mCelular.Visible = true;
                // Limpa o valor atual do controle mCelular
                mCelular.Text = "";
                // Define a posição do controle Celular na tela
             
                // Define a posição do controle de entrada de dados mCelular na tela
            }
            else if (cContato.SelectedItem != null && cContato.SelectedItem.ToString() == "Telefone")
            { // Oculta o controle Contato1
                mCelular.Text = "";
            
                // Habilita o controle de entrada de dados mCelular
                mCelular.Enabled = true;
                // Exibe o controle de entrada de dados mCelular
                mCelular.Visible = true;
                // Limpa o valor atual do controle mCelular
        
                // Define a posição do controle Telefone na tela
            }
        }

        private void MContato_Click_1(object sender, EventArgs e)
        {// Define a posição inicial da seleção no controle de entrada de dados mCelular
            mCelular.SelectionStart = 0;
            // Define o comprimento da seleção no controle de entrada de dados mCelular
            mCelular.SelectionLength = 0; 
        }

       
    }
}

