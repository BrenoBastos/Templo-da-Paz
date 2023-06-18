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
    public partial class AlterarL : Form
    {
        public AlterarL()
        {
            InitializeComponent();
            // Chama a função comboBoxiniciar1(), que provavelmente preenche um combobox com opções.
            comboBoxiniciar1();
            textSenha.PasswordChar = '*';
            CenterToScreen();
            // Chama a função comboBoxiniciar2(), que provavelmente preenche outro combobox com opções.
            comboBoxiniciar2();

            // Chama a função comboBoxiniciar3(), que provavelmente preenche um terceiro combobox com opções.
            comboBoxiniciar3();

            // Chama a função comboBoxiniciar5(), que provavelmente preenche um quarto combobox com opções.
            comboBoxiniciar5();

            // Chama a função FormatarContato(), que provavelmente aplica alguma formatação a um campo de contato.
            FormatarContato();

            // Chama a função formatarCampoSenha(), que provavelmente formata um campo de senha para que ele seja exibido como asteriscos ou pontos.
            formatarCampoSenha();
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
          mCRM.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            mCRM.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            mCRM.Height = 30;






        }
        // Declaração de uma variável do tipo inteiro chamada "value".
        public int value;
        private void comboBoxiniciar5()
        { // Verifica se a lista de itens do controle "cContato" está vazia.
           bAlterar.FlatAppearance.MouseOverBackColor = bAlterar.BackColor;
            bAlterar.FlatAppearance.MouseDownBackColor = bAlterar.BackColor;
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
            mCRM.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
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
                path.AddArc(textID.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textID.Width - borderRadius, textID.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textID.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textID.Region = new Region(path);
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
                path.AddArc(mCRM.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(mCRM.Width - borderRadius, mCRM.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, mCRM.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                mCRM.Region = new Region(path);
            }
            if (cContato.Items.Count == 0)
            {
                // Adiciona os itens "Contato", "Celular" e "Telefone" à lista de itens.
                cContato.Items.Add("Contato");
                cContato.Items.Add("Celular");
                cContato.Items.Add("Telefone");

                // Define o item selecionado como o primeiro item da lista.
                cContato.SelectedIndex = 0;

                // Define o estilo do controle como um ComboBox com lista suspensa.
                cContato.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void FormatarContato()
        {
            // Define a visibilidade do controle "Contato1" como verdadeira.

            // Define a visibilidade do controle "Telefone" como falsa.

            // Habilita o controle "mCelular".
            mCelular.Enabled = true;

            // Define a visibilidade do controle "mCelular" como verdadeira.
            mCelular.Visible = true;

            // Define a visibilidade do controle "Celular" como falsa.

            // Define a posição do controle "Contato1".

            // Define o valor do controle "mCelular" como uma string vazia.
            mCelular.Text = "";
        }
        public void CarregarDetalhes(string Id, string nome, string cpf, string rg, string endereco, string dataNascimento, string senha, string crm,string estadoCivil, string sexo, string contato, string status)
        {
            textNome.Text = nome;
            textCpf.Text = cpf;
            textRG.Text = rg;
            textEndereco.Text = endereco;
            mDataNascimento.Text = dataNascimento;
            mCelular.Text = contato;
            textSenha.Text = senha;
            mCRM.Text = crm;
            cEstadoCivil.SelectedIndex = cEstadoCivil.FindStringExact(estadoCivil);
            cSexo.SelectedIndex = cSexo.FindStringExact(sexo);
            cContato.SelectedItem = contato;
            cStatus.SelectedIndex = cStatus.FindStringExact(status);
            textID.Text = Id.ToString();

            Conexao conexao = new Conexao();
            conexao.Abrir();
          

            conexao.Fechar();

        }


      


        private void comboBoxiniciar1()
        {
            // Verifica se a lista de itens do controle "cEstadoCivil" está vazia.
            if (cEstadoCivil.Items.Count == 0)
            {
                // Adiciona os itens "Solteiro(a)", "Casado(a)", "União Estável" e "Viúvo(a)" à lista de itens.
                cEstadoCivil.Items.Add("Solteiro(a)");
                cEstadoCivil.Items.Add("Casado(a)");
                cEstadoCivil.Items.Add("União Estável");
                cEstadoCivil.Items.Add("Viúvo(a)");

                // Define o item selecionado como o primeiro item da lista.
                cEstadoCivil.SelectedIndex = 0;

                // Define o estilo do controle como um ComboBox com lista suspensa.
                cEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void comboBoxiniciar2()
        {
            // Verifica se a lista de itens do controle "cSexo" está vazia.
            if (cSexo.Items.Count == 0)
            {
                // Adiciona os itens "Masculino", "Feminino" e "Outro" à lista de itens.
                cSexo.Items.Add("Masculino");
                cSexo.Items.Add("Feminino");
                cSexo.Items.Add("Não definido");

                // Define o item selecionado como o primeiro item da lista.
                cSexo.SelectedIndex = 0;

                // Define o estilo do controle como um ComboBox com lista suspensa.
                cSexo.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
        private void comboBoxiniciar3()
        {
            // Verifica se o ComboBox de status está vazio.
            if (cStatus.Items.Count == 0)
            {
                // Adiciona duas opções ao ComboBox.
                cStatus.Items.Add("Ativo");
                cStatus.Items.Add("Inativo");

                // Seleciona a primeira opção como padrão.
                cStatus.SelectedIndex = 0;

                // Define o estilo do ComboBox como DropDownList, que impede que o usuário digite valores diferentes dos fornecidos.
                cStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
        private void formatarCampoSenha()
        {
            // Define que o campo de texto de senha deve usar um caractere oculto padrão do sistema.
            textSenha.UseSystemPasswordChar = true;

            // Define o caractere a ser exibido no lugar dos caracteres digitados pelo usuário.
            // Nesse caso, o caractere "*" será exibido.
            textSenha.PasswordChar = '*';
        }


        private void lSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void textCpf_Click(object sender, EventArgs e)
        { // Define a posição do cursor de seleção do texto como 0 (início da caixa de texto).
            textCpf.SelectionStart = 0;
            // Define o tamanho da seleção como 0 (nenhum caractere selecionado).
            textCpf.SelectionLength = 0;
        }

        private void textRG_Click(object sender, EventArgs e)
        {// Define a posição do cursor de seleção do texto como 0 (início da caixa de texto).
            textRG.SelectionStart = 0;
            // Define o tamanho da seleção como 0 (nenhum caractere selecionado).
            textRG.SelectionLength = 0;
        }

        private void mDataNascimento_Click(object sender, EventArgs e)
        {// Define a posição do cursor de seleção do texto como 0 (início da caixa de texto).
            mDataNascimento.SelectionStart = 0;
            // Define o tamanho da seleção como 0 (nenhum caractere selecionado).
            mDataNascimento.SelectionLength = 0;
        }

        private void mContato_Click(object sender, EventArgs e)
        {

        }

        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {




        }

        private void bAlterar_Click(object sender, EventArgs e)
        {//. Ele realiza validações nos campos preenchidos pelo usuário antes de permitir a atualização dos dados.
            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted || !textRG.MaskCompleted ||
                       string.IsNullOrWhiteSpace(textEndereco.Text) || !mCRM.MaskCompleted || !mDataNascimento.MaskCompleted|| string.IsNullOrWhiteSpace(mCelular.Text))
            {// Exibe uma mensagem de erro caso algum campo esteja vazio ou não tenha sido preenchido corretamente.
                MessageBox.Show("Preencha todos os campos!");
                // Interrompe a execução do método.
                return;
            }



            // verifica se o campo 'ID' contém apenas caracteres numéricos. Se não, uma mensagem de erro é exibida e o campo 'ID' é limpo
            else if (!textID.Text.All(char.IsDigit))
                {
                MessageBox.Show("Por favor, insira apenas carecteres numéricos  no campo 'ID'.");
                // Limpa o campo 'Nome'.
                textID.Text = "";
                // Interrompe a execução do método.
                return;
                }



           //  verifica se o campo 'Nome' contém apenas caracteres não numéricos
                else if (textNome.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                // Limpa o campo 'Nome'.
                textNome.Text = "";
                // Interrompe a execução do método.
                return;
            }
            // Verifica se o tipo de contato selecionado é "Celular" e se o número inserido está no formato correto.
            // Se o formato estiver incorreto, exibe uma mensagem de erro e limpa o campo de entrada.
            if (cContato.SelectedItem != null&& cContato.SelectedItem.ToString() == "Celular" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{5}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Contato' inválido, preencha-o com um número de contato válido.");
                mCelular.Text = "";
                return;
            }

            // Verifica se o tipo de contato selecionado é "Telefone" e se o número inserido está no formato correto.
            // Se o formato estiver incorreto, exibe uma mensagem de erro e limpa o campo de entrada.
            if (cContato.SelectedItem != null && cContato.SelectedItem.ToString() == "Telefone" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{4}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Contato' inválido, preencha-o com um número de contato válido.");
                mCelular.Text = "";
                return;
            }

            // Se todas as validações passarem, exibe uma mensagem de sucesso e limpa todos os campos.
            else
            {
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
                    string crm = mCRM.Text;
                    string id = textID.Text;

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

                    // Consultar o número atual de legistas ativos
                    string countQuery = "SELECT COUNT(*) FROM legista WHERE Status = 'Ativo'";
                    MySqlCommand countCmd = new MySqlCommand(countQuery, Conexao.con);
                    int legistasAtivos = Convert.ToInt32(countCmd.ExecuteScalar());

                    // Verificar se já existem 5 legistas ativos
                    if (legistasAtivos >= 5 && status == "Ativo")
                    {
                        // Exibir uma mensagem informando que o limite foi atingido
                        MessageBox.Show("Limite de legistas ativos atingido. Não é possível cadastrar mais legistas ativos.");
                    }
                    else
                    {
                        string query = $"UPDATE legista SET Nome = @nome, Rg = @rg, Endereco = @endereco, DataNasc = @dataNascimento, " +
                                      $"Contato = @celular, Id=@id, Crm = @crm, EstadoCivil = @estadoCivil, Sexo = @sexo, Senha = @senha, Status = @status " +
                                      $"WHERE Id = @id";

                        MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@rg", rg);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                        cmd.Parameters.AddWithValue("@celular", celular);
                        cmd.Parameters.AddWithValue("@crm", crm);

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

                        // Atualizar a contagem de legistas ativos se necessário
                        if (rowsAffected > 0)
                        {
                            if (status == "Ativo")
                            {
                                legistasAtivos++; // Incrementar a contagem de legistas ativos
                            }
                            else if (status == "Inativo")
                            {
                                legistasAtivos--; // Decrementar a contagem de legistas ativos
                            }

                            MessageBox.Show("Alterado com sucesso");
                            textNome.Text = "";
                            textCpf.Text = "";
                            textRG.Text = "";
                            textEndereco.Text = "";
                            mDataNascimento.Text = "";
                            mCelular.Text = "";
                            mCRM.Text = "";
                            textSenha.Text = "";
                            textID.Text = "";
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



            }
            }

            private void lSenha_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

       

        private void bVoltar_Click(object sender, EventArgs e)
        {// Esconde a janela atual
            this.Hide();
            // Cria uma nova instância da classe DadosL
            DadosL novaTela = new DadosL();
            // Mostra a nova instância da janela DadosL
            novaTela.ShowDialog();
        }

        private void mCRM_Click(object sender, EventArgs e)
        { // Define o início da seleção como o caractere 0
            mCRM.SelectionStart = 0;
            // Define o comprimento da seleção como 0
            mCRM.SelectionLength = 0;
        }

        private void cContato_SelectedIndexChanged(object sender, EventArgs e)
        {
          
          
        }

    
        private void textCpf_Click_1(object sender, EventArgs e)
        { // Define o início da seleção como o caractere 0
            textCpf.SelectionStart = 0;
            // Define o comprimento da seleção como 0
            textCpf.SelectionLength = 0;
        }

        private void textRG_Click_1(object sender, EventArgs e)
        {
            // Define o início da seleção como o caractere 0
                textRG.SelectionStart = 0;
                // Define o comprimento da seleção como 0
                textRG.SelectionLength = 0;
        }

        private void mDataNascimento_Click_1(object sender, EventArgs e)
        {// Define o início da seleção como o caractere 0
            mDataNascimento.SelectionStart = 0;
            // Define o comprimento da seleção como 0
            mDataNascimento.SelectionLength = 0;
        }

        private void cContato_SelectedIndexChanged_1(object sender, EventArgs e)
        { // Se o item selecionado em cContato for "Celular"
            if (cContato.SelectedItem != null && cContato.SelectedItem.ToString() == "Celular")
            {            // Esconde o controle Contato1

                // Mostra o controle Celular
                // Esconde o controle Telefone
                // Habilita o controle mCelular
                mCelular.Enabled = true;
                // Mostra o controle mCelular
                mCelular.Visible = true;
                // Define o texto do controle mCelular como vazio
                mCelular.Text = "";
                // Define a posição do controle Celular como (192, 125)


            }
            // Se o item selecionado em cContato for "Telefone"
            if (cContato.SelectedItem != null && cContato.SelectedItem.ToString() == "Telefone")
            { // Esconde o controle Contato1
                mCelular.Text = "";
                // Esconde o controle Celular
                // Mostra o controle Telefone

                // Define o texto do controle mCelular como vazio

                
                // Define a posição do controle Telefone como (192, 125)



            }
        }

      
        private void mCelular_Click(object sender, EventArgs e)
        {// Define o início da seleção como o caractere 0
            mCelular.SelectionStart = 0;
            // Define o comprimento da seleção como 0
            mCelular.SelectionLength = 0;
        }

        private void AlterarL_Load(object sender, EventArgs e)
        {

        }
    }
}
