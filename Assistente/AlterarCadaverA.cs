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
    public partial class AlterarCadaverA : Form
    {
        public AlterarCadaverA()
        {
            InitializeComponent();
            listarassistente();
            cAssistente.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            cAssistente.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            cAssistente.Height =30;
        }
        private void listarassistente()
        {
            bAlterar.FlatAppearance.MouseOverBackColor = bAlterar.BackColor;
            bAlterar.FlatAppearance.MouseDownBackColor = bAlterar.BackColor;
            bVoltar.FlatAppearance.MouseOverBackColor = bVoltar.BackColor;
            bVoltar.FlatAppearance.MouseDownBackColor = bVoltar.BackColor;
            mHorarioChegada.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            mDataChegada.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            cAssistente.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            textGaveta.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            textID.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            textNome.Font = new Font("Poppins", 15); // Ajuste a fonte para determinar a altura
            textGaveta.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textNome.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            textID.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            mDataChegada.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            mHorarioChegada.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
            mHorarioChegada.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            mDataChegada.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
            textGaveta.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
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
                path.AddArc(textID.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textID.Width - borderRadius, textID.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textID.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textID.Region = new Region(path);
            }
            using (GraphicsPath path = new GraphicsPath())

            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(textGaveta.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textGaveta.Width - borderRadius, textGaveta.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, textGaveta.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                textGaveta.Region = new Region(path);
            }
            using (GraphicsPath path = new GraphicsPath())

            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(mDataChegada.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(mDataChegada.Width - borderRadius, mDataChegada.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, mDataChegada.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                mDataChegada.Region = new Region(path);
            }
            using (GraphicsPath path = new GraphicsPath())

            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(mHorarioChegada.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(mHorarioChegada.Width - borderRadius, mHorarioChegada.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, mHorarioChegada.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                mHorarioChegada.Region = new Region(path);
            }
            using (GraphicsPath path = new GraphicsPath())
            { 
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(cAssistente.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(cAssistente.Width - borderRadius, cAssistente.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, cAssistente.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            cAssistente.Region = new Region(path);
        }

        Conexao conexao = new Conexao();
            conexao.Abrir();
            try
            {
                string query = "SELECT Nome FROM assistente WHERE Status = 'Ativo'";

                MySqlCommand command = new MySqlCommand(query, Conexao.con);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nome = reader.GetString("Nome");

                    if (!cAssistente.Items.Contains(nome))
                    {
                        cAssistente.Items.Add(nome);
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
            cAssistente.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void mDataChegada_Click(object sender, EventArgs e)
        {
            mDataChegada.SelectionStart = 0;
            mDataChegada.SelectionLength = 0;
        }
        public void CarregarDetalhes(string Id, string nome, string assistente, string gaveta, string dataChegada, string horarioChegada)
        {
            textID.Text = Id.ToString();
            textNome.Text = nome;
            cAssistente.SelectedItem = assistente;
            textGaveta.Text = gaveta;
            mDataChegada.Text = dataChegada;
            mHorarioChegada.Text = horarioChegada;
           
        }
        private void mHorarioChegada_Click(object sender, EventArgs e)
        {
            // Define o início da seleção para 0
                mHorarioChegada.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mHorarioChegada.SelectionLength = 0;
        }
      
        private void bAlterar_Click(object sender, EventArgs e)
        {
            // Verifica se algum campo obrigatório está vazio ou incompleto
            if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(textGaveta.Text) ||
                string.IsNullOrWhiteSpace(textID.Text) || !mDataChegada.MaskCompleted || !mHorarioChegada.MaskCompleted)
            {
                MessageBox.Show("Preencha todos os campos!");
                // encerra a execução do método se algum campo estiver incompleto
                return;
            }
            // Verifica se o campo ID contém apenas dígitos numéricos
            else if (!textID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'ID'.");
                // Limpa o campo ID se o usuário inseriu caracteres inválidos
                textID.Text = ""; 
                return;
            }
            else if (!Regex.IsMatch(textGaveta.Text, "^[A-Z]{1}$")) // Verifica se o campo Gaveta contém apenas um caractere em maiúscula
            {
                // Exibe uma mensagem de erro informando que o campo Gaveta deve conter apenas um caractere em maiúscula
                MessageBox.Show("Por favor, insira apenas um caractere em maiúscula no campo 'Gaveta'.");
                textGaveta.Text = ""; // Limpa o campo Gaveta
                return; // Retorna sem cadastrar
            }

          
            // Verifica se o campo Nome contém apenas caracteres de texto
            else if (textNome.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Nome'.");
                // Limpa o campo Nome se o usuário inseriu caracteres inválidos
               
                textNome.Text = "";
                return;
            }
            // Verifica se o campo Gaveta contém apenas caracteres de texto
            else if (textGaveta.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Gaveta'.");
                // Limpa o campo Gaveta se o usuário inseriu caracteres inválidos
              
                textGaveta.Text = "";
                return;
            }
            else if (!textGaveta.Text.All(char.IsUpper)) // Verifica se o campo Gaveta contém apenas letras maiúsculas
            {
                // Exibe uma mensagem de erro informando que o campo Gaveta deve conter apenas letras maiúsculas
                MessageBox.Show("Por favor, insira apenas letras maiúsculas no campo 'Gaveta'.");
                textGaveta.Text = ""; // Limpa o campo Gaveta
                return; // Retorna sem cadastrar
            }
            else
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.Abrir();

                    string id = textID.Text;
                    string nome = textNome.Text;
                    string gaveta = textGaveta.Text;
                    string dataChegada = mDataChegada.Text;
                    string horarioChegada = mHorarioChegada.Text;
                    string assistente = cAssistente.SelectedItem.ToString();

                    // Verifica se o assistente existe na tabela "assistente"
                    string verificaAssistenteQuery = $"SELECT COUNT(*) FROM assistente WHERE Nome = @assistente AND Status = 'ativo'";
                    MySqlCommand verificaAssistenteCmd = new MySqlCommand(verificaAssistenteQuery, Conexao.con);
                    verificaAssistenteCmd.Parameters.AddWithValue("@assistente", assistente);

                    int assistenteCount = Convert.ToInt32(verificaAssistenteCmd.ExecuteScalar());

                    if (assistenteCount > 0)
                    {
                        // Verifica se a nova gaveta já está ocupada por outro cadáver (exceto se for o mesmo cadáver)
                        string verificaGavetaQuery = "SELECT COUNT(*) FROM cadaver WHERE Gaveta = @gaveta AND Id <> @id";
                        MySqlCommand verificaGavetaCmd = new MySqlCommand(verificaGavetaQuery, Conexao.con);
                        verificaGavetaCmd.Parameters.AddWithValue("@gaveta", gaveta);
                        verificaGavetaCmd.Parameters.AddWithValue("@id", id);

                        int gavetaCount = Convert.ToInt32(verificaGavetaCmd.ExecuteScalar());

                        if (gavetaCount > 0)
                        {
                            // Verifica se a gaveta pertence ao cadáver que está sendo atualizado
                            string verificaGavetaCadaverQuery = "SELECT COUNT(*) FROM cadaver WHERE Gaveta = @gaveta AND Id = @id";
                            MySqlCommand verificaGavetaCadaverCmd = new MySqlCommand(verificaGavetaCadaverQuery, Conexao.con);
                            verificaGavetaCadaverCmd.Parameters.AddWithValue("@gaveta", gaveta);
                            verificaGavetaCadaverCmd.Parameters.AddWithValue("@id", id);

                            int gavetaCadaverCount = Convert.ToInt32(verificaGavetaCadaverCmd.ExecuteScalar());

                            if (gavetaCadaverCount == 0)
                            {
                                MessageBox.Show("A gaveta informada já está ocupada. Por favor, escolha outra gaveta.");
                                return;
                            }
                        }

                        // Atualiza os dados do cadáver no banco de dados
                        string queryUpdateCadaver = "UPDATE cadaver SET Nome = @nome, Gaveta = @gaveta, DataChegada = @dataChegada, HorarioChegada = @horarioChegada, Assistente = @assistente WHERE Id = @id";
                        MySqlCommand cmdUpdateCadaver = new MySqlCommand(queryUpdateCadaver, Conexao.con);
                        cmdUpdateCadaver.Parameters.AddWithValue("@nome", nome);
                        cmdUpdateCadaver.Parameters.AddWithValue("@gaveta", gaveta);
                        cmdUpdateCadaver.Parameters.AddWithValue("@dataChegada", dataChegada);
                        cmdUpdateCadaver.Parameters.AddWithValue("@horarioChegada", horarioChegada);
                        cmdUpdateCadaver.Parameters.AddWithValue("@assistente", assistente);
                        cmdUpdateCadaver.Parameters.AddWithValue("@id", id);

                        cmdUpdateCadaver.ExecuteNonQuery();

                        // Exibe uma mensagem de sucesso informando que a alteração foi realizada com sucesso
                        MessageBox.Show("Dados alterados com sucesso");

                        // Limpa todos os campos
                        textNome.Text = "";
                        textGaveta.Text = "";
                        mDataChegada.Text = "";
                        mHorarioChegada.Text = "";
                        textID.Text = "";

                    }

                    else
                    {
                        MessageBox.Show("Assistente não encontrado na tabela 'assistente'. Cadastre o assistente antes de realizar a alteração ou assistente inativo.");
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
        {// Esconde a janela atual
            this.Hide();
            // Cria uma nova instância da classe  DadosCadaverA

            DadosCadaverA novaTela = new DadosCadaverA();
            // Mostra a nova instância da janela  DadosCadaverA
            novaTela.ShowDialog();
        }
    }
}
