using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CadastrarF : Form
    {
        public CadastrarF()
        {//Chama as funções que inicializam os ComboBoxes e formatam o formulário

            InitializeComponent();
            comboBoxiniciar1();
            comboBoxiniciar2();
            FormatarContato();

            cStatus.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            cStatus.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            cStatus.Height = 30;
            CenterToScreen();
            cContato.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            cContato.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            cContato.Height = 30;
         
            BackColor = Color.FromArgb(64, 49, 49);

            mCelular.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            mCelular.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            mCelular.Height = 30;

        
            textCpf.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textCpf.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textCpf.Height = 30;
        }

        //Função para inicializar o ComboBox de Status
        private void comboBoxiniciar1()
        {
            bCadastrar.FlatAppearance.MouseOverBackColor = bCadastrar.BackColor;
            bCadastrar.FlatAppearance.MouseDownBackColor = bCadastrar.BackColor;
            bVoltar.FlatAppearance.MouseOverBackColor = bVoltar.BackColor;
            bVoltar.FlatAppearance.MouseDownBackColor = bVoltar.BackColor;

            mCelular.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            textCpf.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            textEndereco.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            textNome.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            cStatus.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            cContato.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura

            mCelular.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textCpf.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textEndereco.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textNome.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            
            mCelular.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textCpf.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textEndereco.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textNome.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
        
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
         
            //Verifica se o ComboBox de Status está vazio
            if (cStatus.Items.Count == 0)
            {
                //Adiciona a opção "Ativo" no ComboBox de Status
                cStatus.Items.Add("Ativo");
                cStatus.Items.Add("Inativo");

                //Seleciona a primeira opção do ComboBox de Status
                cStatus.SelectedIndex = 0;
                //Define que o ComboBox de Status não pode ser editado pelo usuário
                cStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        //Função para inicializar o ComboBox de Contato
        private void comboBoxiniciar2()
        {
            //Verifica se o ComboBox de Contato está vazio
            if (cContato.Items.Count == 0)
            {
                //Adiciona as opções "Celular" e "Telefone" no ComboBox de Contato
                cContato.Items.Add("Celular");
                cContato.Items.Add("Telefone");

                //Define que o ComboBox de Contato não pode ser editado pelo usuário
                cContato.DropDownStyle = ComboBoxStyle.DropDownList;

                //Seleciona a primeira opção do ComboBox de Contato
                cContato.SelectedIndex = 0;
            }
        }

        //Função para formatar o formulário para exibir informações de contato de celular
        private void FormatarContato()
        {
            //Define a posição dos controles de celular e mascara de celular
           

            //Torna visível o controle de celular e invisível o controle de telefone

            //Habilita o controle de mascara de celular
            mCelular.Enabled = true;
            //Torna visível o controle de mascara de celular
            mCelular.Visible = true;

            //Limpa o valor do controle de mascara de celular
            mCelular.Text = "";
        }
        private void textCpf_Click(object sender, EventArgs e)
        {// Define o início da seleção como o caractere 0
            mCelular.SelectionStart = 0;
            // Define o início da seleção como o caractere 0
            textCpf.SelectionStart = 0;
            // Define o comprimento da seleção como 0

            textCpf.SelectionLength = 0;
        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se algum dos campos obrigatórios está vazio ou incompleto
            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted
                ||  string.IsNullOrWhiteSpace(textEndereco.Text)
                || string.IsNullOrWhiteSpace(mCelular.Text))
            {
                // Se algum campo estiver vazio, exibe uma mensagem de erro
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // Verifica se o campo ID contém apenas caracteres numéricos
           

            // Verifica se o campo de contato é um celular e se o número de celular é válido
            else if (cContato.SelectedItem.ToString() == "Celular" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{5}-\d{4}$"))
            {
                // Se o número de celular não for válido, exibe uma mensagem de erro e limpa o campo
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Contato' inválido, preencha-o com um número de contato válido ");
                mCelular.Text = "";
                return;
            }

            // Verifica se o campo de contato é um telefone e se o número de telefone é válido
            else if (cContato.SelectedItem.ToString() == "Telefone" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{4}-\d{4}$"))
            {
                // Se o número de telefone não for válido, exibe uma mensagem de erro e limpa o campo
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Contato' inválido, preencha-o com um número de contato válido ");
                mCelular.Text = "";
                return;
            }

            // Verifica se o campo Nome contém apenas caracteres alfabéticos
            else if (textNome.Text.All(char.IsDigit))
            {
                // Se o campo contém caracteres não alfabéticos, exibe uma mensagem de erro e limpa o campo
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Nome'.");
                textNome.Text = "";
                return;
            }

            // Se todos os campos estiverem preenchidos corretamente, exibe uma mensagem de sucesso e limpa os campos
            else
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.Abrir();

                    string nome = textNome.Text;
                    string cpf = textCpf.Text;
                    string endereco = textEndereco.Text;
                    string contato = mCelular.Text;
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
                    string query = $"INSERT INTO fornecedor (Nome, CPF, Endereco, Contato,Status) " +
                                   $"VALUES (@nome, @cpf, @endereco, @contato, @status)";

                    MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@contato", contato);
                    cmd.Parameters.AddWithValue("@status", status);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cadastrado com sucesso");
                        textNome.Text = "";
                        textCpf.Text = "";
                        textEndereco.Text = "";
                        mCelular.Text = "";
                        cContato.SelectedIndex = 0;
                        cStatus.SelectedIndex = 0;
                        conexao.Fechar();

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
                }
            }
        }

            private void bVoltar_Click(object sender, EventArgs e)
        {    // Esconder a tela atual
            this.Hide();

            // Criar uma nova instância da tela Admin1
            Admin1 novaTela = new Admin1();

            // Mostrar a nova tela como uma janela de diálogo (modal)
            novaTela.ShowDialog();
        }

        private void cContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se o item selecionado é "Celular"
            if (cContato.SelectedItem.ToString() == "Celular")
            {
                // Mostrar o painel "Celular"

                // Esconder o painel "Telefone"

                // Habilitar a máscara de entrada para número de celular
                mCelular.Enabled = true;

                // Mostrar a máscara de entrada para número de celular
                mCelular.Visible = true;

                // Limpar o valor atual da máscara de entrada para número de celular
                mCelular.Text = "";

             
            }
            // Se o item selecionado não for "Celular", verificar se é "Telefone"
            else if (cContato.SelectedItem.ToString() == "Telefone")
            {
                // Esconder o painel "Celular"

                // Mostrar o painel "Telefone"

                // Limpar o valor atual da máscara de entrada para número de celular
                mCelular.Text = "";

                // Mover o painel "Telefone" para a posição correta na tela
            

        }
        }

        private void CadastrarF_Load(object sender, EventArgs e)
        {

        }
    }
}
