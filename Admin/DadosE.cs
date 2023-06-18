using MySql.Data.MySqlClient;
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
    public partial class DadosE : Form
    {
        public DadosE()
        {
            InitializeComponent();
            // Define o modo de seleção do DataGridView como seleção de linha completa
            BackColor = Color.FromArgb(64, 49, 49);

            dDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarregarDados();
            this.Shown += DadosE_Shown;
            CenterToScreen();
        }
        private void DadosE_Shown(object sender, EventArgs e)
        {
            CarregarDados(); // Chama o método para carregar os dados no DataGridView
            MessageBox.Show("Dados carregados com sucesso");

        }
       
        private void CarregarDados()
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Abrir();

                // Consulta na tabela estoque para obter os dados ordenados por Id
                string query = "SELECT Id, Fornecedor, Material, Quantidade, SUM(Quantidade) OVER (PARTITION BY Material) AS Total FROM estoque ORDER BY Id";

                MySqlCommand cmd = new MySqlCommand(query, Conexao.con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    // Vincula os resultados à DataGridView
                    dDados.DataSource = dataTable;

                    // Define a propriedade DataPropertyName das colunas correspondentes
                    dDados.Columns["Id"].DataPropertyName = "Id";
                    dDados.Columns["Fornecedor"].DataPropertyName = "Fornecedor";
                    dDados.Columns["Material"].DataPropertyName = "Material";
                    dDados.Columns["Quantidade"].DataPropertyName = "Quantidade";
                    dDados.Columns["Total"].DataPropertyName = "Total";

                    bLocalizar.FlatAppearance.MouseOverBackColor = bLocalizar.BackColor;
                    bLocalizar.FlatAppearance.MouseDownBackColor = bLocalizar.BackColor;
                    bVoltar.FlatAppearance.MouseOverBackColor = bVoltar.BackColor;
                    bVoltar.FlatAppearance.MouseDownBackColor = bVoltar.BackColor;
                    textMaterial.BackColor = Color.FromArgb(0x81, 0x66, 0x66);
                    textMaterial.Font = new Font("Poppins", 15, FontStyle.Regular);
                    textMaterial.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF);
                    dDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                    dDados.Columns["ID"].DefaultCellStyle.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.Columns["Material"].DefaultCellStyle.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.Columns["Quantidade"].DefaultCellStyle.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.Columns["Fornecedor"].DefaultCellStyle.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.Columns["Total"].DefaultCellStyle.Font = new Font("Poppins", 15, FontStyle.Regular);

                    dDados.Columns["ID"].HeaderCell.Style.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.Columns["Material"].HeaderCell.Style.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.Columns["Quantidade"].HeaderCell.Style.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.Columns["Fornecedor"].HeaderCell.Style.Font = new Font("Poppins", 15, FontStyle.Regular);
                    dDados.Columns["Total"].HeaderCell.Style.Font = new Font("Poppins", 15, FontStyle.Regular);



                    dDados.BackgroundColor = System.Drawing.Color.FromArgb(151, 128, 128);
                    dDados.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(151, 128, 128);
                    dDados.EnableHeadersVisualStyles = false; // Desabilita o estilo visual padrão dos cabeçalhos
                    dDados.Columns["Material"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128); // Define a cor de fundo do cabeçalho
                    dDados.Columns["ID"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128); // Define a cor de fundo do cabeçalho
                    dDados.Columns["Quantidade"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128); // Define a cor de fundo do cabeçalho
                    dDados.Columns["Fornecedor"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128); // Define a cor de fundo do cabeçalho
                    dDados.Columns["Total"].HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(151, 128, 128); // Define a cor de fundo do cabeçalho





                    dDados.DefaultCellStyle.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF); // Define a cor do texto do cabeçalho           
                    dDados.RowHeadersVisible = false;
                    dDados.RowTemplate.Height = 29; // Define a altura das células
                    dDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                    dDados.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0xFC, 0xF3, 0xDF); // Define a cor do texto do cabeçalho        
                    int borderRadius = 10; // Define o raio da borda arredondada

                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                        path.AddArc(textMaterial.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                        path.AddArc(textMaterial.Width - borderRadius, textMaterial.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                        path.AddArc(0, textMaterial.Height - borderRadius, borderRadius, borderRadius, 90, 90);

                        textMaterial.Region = new Region(path);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum resultado encontrado.");
                }

                conexao.Fechar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
            }

        }



        private void bLocalizar_Click(object sender, EventArgs e)
        { // Verifica se o campo de material está vazio


            try
            {
                string material = textMaterial.Text;


                Conexao conexao = new Conexao();
                conexao.Abrir();


                string query = "SELECT Id, Fornecedor, Quantidade, Total, Material FROM estoque WHERE Material = @material";
                MySqlCommand cmd = new MySqlCommand(query, Conexao.con);
                cmd.Parameters.AddWithValue("@material", material);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dDados.DataSource = dataTable;

                    dDados.Columns["Id"].DataPropertyName = "Id";
                    dDados.Columns["Fornecedor"].DataPropertyName = "Fornecedor";
                    dDados.Columns["Material"].DataPropertyName = "Material";
                    dDados.Columns["Quantidade"].DataPropertyName = "Quantidade";
                    dDados.Columns["Total"].DataPropertyName = "Total";

                    MessageBox.Show("Localizado com sucesso");
                    textMaterial.Text = "";
                }




                else { 

                MessageBox.Show("Material não encontrado na tabela estoque.");


            }}
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro na conexão com o banco de dados: " + ex.Message);
            }

        }

        private void bVoltar_Click(object sender, EventArgs e)
        {   // Oculta a tela atual
            this.Hide();
            // Cria uma nova instância da classe Admin1
            Admin1 novaTela = new Admin1();
            // Mostra a nova instância da janela Admin1
            novaTela.ShowDialog();
        }

        private void DadosE_Load(object sender, EventArgs e)
        {

        }
    }
}
