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
    public partial class AlterarF : Form
    {
        public AlterarF()
        {
            InitializeComponent();
            cStatus.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            cStatus.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            cStatus.Height = 30;

            cContato.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            cContato.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            cContato.Height = 30;
            BackColor = Color.FromArgb(64, 49, 49);
            comboBoxiniciar4();

            // Inicializa o primeiro ComboBox
            comboBoxiniciar1();
            // Formata o campo de contato
            FormatarContato();
            // Inicializa o segundo ComboBox

        }
        // Variável global para armazenar um valor
        public int value;
        public void CarregarDetalhes(string Id, string nome, string cpf, string endereco, string contato, string status)
        {
            textID.Text = Id.ToString();
            textNome.Text = nome;
            textCpf.Text = cpf;
            textEndereco.Text = endereco;

            mCelular.Text = contato;

            cContato.SelectedIndex = cContato.FindStringExact(contato);
            cStatus.SelectedIndex = cStatus.FindStringExact(status);
        }
        private void comboBoxiniciar1()

        {
            bAlterar.FlatAppearance.MouseOverBackColor = bAlterar.BackColor;
            bAlterar.FlatAppearance.MouseDownBackColor = bAlterar.BackColor;
            bVoltar.FlatAppearance.MouseOverBackColor = bVoltar.BackColor;
            bVoltar.FlatAppearance.MouseDownBackColor = bVoltar.BackColor;
            textCpf.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
          textEndereco.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
           cContato.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
           mCelular.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
           cStatus.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura

            textID.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            textNome.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            textCpf.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textNome.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textID.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textEndereco.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            cContato.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            mCelular.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            cStatus.BackColor = Color.FromArgb(0x81, 0x66, 0x66);




            textCpf.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textEndereco.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
             cContato.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            mCelular.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            cStatus.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);



            textID.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
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
                path.AddArc(textCpf.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textCpf.Width - borderRadius, textCpf.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textNome.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textCpf.Region = new Region(path);

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
                path.AddArc(textEndereco.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textEndereco.Width - borderRadius, textEndereco.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textEndereco.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textEndereco.Region = new Region(path);

            }
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(mCelular.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(mCelular.Width - borderRadius, mCelular.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, mCelular.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                mCelular.Region = new Region(path);

            }

            // Se o ComboBox estiver vazio
            if (cStatus.Items.Count == 0)
            {// Adiciona "Ativo"
                cStatus.Items.Add("Ativo");
                // Adiciona "Inativo"
                cStatus.Items.Add("Inativo");
                // Define o índice selecionado como 0 (Ativo)
                cStatus.SelectedIndex = 0;
                // Define o estilo do ComboBox como DropDownList (não pode ser editado pelo usuário)
                cStatus.DropDownStyle = ComboBoxStyle.DropDownList; 

            }


        }
        private void comboBoxiniciar4()
        {// Se o ComboBox estiver vazio
            if (cContato.Items.Count == 0)
            {// Adiciona "Contato"
                cContato.Items.Add("Contato");
                // Adiciona "Celular"
                cContato.Items.Add("Celular");
                // Adiciona "Telefone"
                cContato.Items.Add("Telefone");
                // Define o índice selecionado como 0 (Contato)
                cContato.SelectedIndex = 0;
                // Define o estilo do ComboBox como DropDownList (não pode ser editado pelo usuário)
                cContato.DropDownStyle = ComboBoxStyle.DropDownList;


            }
        }
       
        private void FormatarContato()
        { // Define a posição do Contato1
            // Torna o campo Celular invisível
      
            // Habilita o campo de digitação do celular
            mCelular.Enabled = true;
            // Torna o campo de digitação do celular visível
            mCelular.Visible = true;
            // Define o texto do campo de digitação do celular como vazio
            mCelular.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // verifica se algum dos campos obrigatórios está vazio ou incompleto
            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted ||
                      string.IsNullOrWhiteSpace(textEndereco.Text) || string.IsNullOrWhiteSpace(mCelular.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                // retorna o controle para o chamador
                return;
            }



            // verifica se o campo Contato é "Celular" e se o número de celular é válido
            if (cContato.SelectedItem != null && cContato.SelectedItem.ToString() == "Celular" && mCelular != null && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{5}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos  no campo 'Contato', preencha -o com um número de contato válido .");
                // limpa o campo de entrada do celular

                mCelular.Text = "";
                // retorna o controle para o chamador
                return;
            }
            // verifica se o campo Contato é "Telefone" e se o número de telefone é válido
            if (cContato.SelectedItem != null && cContato.SelectedItem.ToString() == "Telefone" && mCelular != null && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{4}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos  no campo 'Contato', preencha -o com um número de contato válido .");
                // limpa o campo de entrada do celular
                mCelular.Text = "";
                // retorna o controle para o chamador
                return;
            }

            // verifica se o campo Nome contém apenas dígitos
            else if (textNome.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                // limpa o campo de entrada do Nome
                textNome.Text = "";
                // limpa o campo de entrada do Nome
                return;

            }// verifica se o campo ID contém apenas dígitos
            else if (!textID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas carecteres numéricos no campo 'ID'.");
                // limpa o campo de entrada do ID
                textID.Text = "";
                // retorna o controle para o chamador
                return;
            }
            else
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.Abrir();
                    string id = textID.Text; // Obtém o ID do cliente a ser atualizado

                    string nome = textNome.Text;
                    string cpf = textCpf.Text;
                    string endereco = textEndereco.Text;
                    string celular = mCelular.Text;
                  
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

                    // Agora você pode usar as variáveis estadoCivil, sexo e status em sua consulta SQL:

                    string query = $"UPDATE fornecedor SET Nome = @nome, Cpf = @cpf, Endereco = @endereco, Contato = @celular, Status = @status WHERE ID = @id";

                    MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@celular", celular);


                    cmd.Parameters.AddWithValue("@status", status);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Alterado com sucesso");
                        textNome.Text = "";
                        textCpf.Text = "";
                        textEndereco.Text = "";
                        mCelular.Text = "";
                        textID.Text = "";

                        cContato.SelectedIndex = 0;
                        cStatus.SelectedIndex = 0;
                        // torna o rótulo "Celular" invisível
                       
                        // habilita o campo de entrada do celular
                        mCelular.Enabled = true;
                        // torna o campo de entrada do celular visível
                        mCelular.Visible = true;
                        // torna o rótulo "Contato" visível
                        
                        // seleciona a primeira opção do campo de seleção de Contato
                        cContato.SelectedIndex = 0;
                        // limpa o campo de entrada do celular novamente
                        mCelular.Text = "";
                        conexao.Fechar();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
                }
               
            }
            

        }

        

        private void textCpf_Click(object sender, EventArgs e)
        {    // Define o início da seleção da caixa de texto do Cpf como 0 e a duração da seleção como 0

            textCpf.SelectionStart = 0;
            textCpf.SelectionLength = 0;
        }

        

        private void bVoltar_Click(object sender, EventArgs e)
        {    // Esconde a janela atual

            this.Hide();    
            // Cria uma nova instância da classe DadosF


            DadosF1 novaTela = new DadosF1();
            // Exibe a nova instância como uma janela de diálogo

            novaTela.ShowDialog();
        }

        private void cContato_SelectedIndexChanged(object sender, EventArgs e)
        {    // Verifica se o item selecionado é "Celular"

            if (cContato.SelectedItem != null && cContato.SelectedItem.ToString() == "Celular")
            {
                // Esconde o painel Contato1

                
                // Exibe o painel Celular e esconde o painel Telefone

             
                // Habilita a caixa de texto do celular e limpa o seu conteúdo

                mCelular.Enabled = true;
                mCelular.Visible = true;
                mCelular.Text = "";
                // Define as novas posições do painel Celular e da caixa de texto do celular


            }
            // Verifica se o item selecionado é "Telefone"

            if (cContato.SelectedItem != null && cContato.SelectedItem.ToString() == "Telefone")
            {        // Define as novas posições do painel Telefone e da caixa de texto do celular

                // Esconde o painel Contato1

             

                // Exibe o painel Telefone e esconde o painel Celular

               
                // Habilita a caixa de texto do celular e limpa o seu conteúdo

                mCelular.Enabled = true;
                mCelular.Visible = true;
                mCelular.Text = "";
            }
        }

     
        
        private void mCelular_Click(object sender, EventArgs e)
        {    // Define o início da seleção da caixa de texto do celular como 0 e a duração da seleção como 0

            mCelular.SelectionStart = 0;
            mCelular.SelectionLength = 0;
        }
    }
}
