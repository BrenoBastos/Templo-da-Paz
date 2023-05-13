using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        //Função para inicializar o ComboBox de Status
        private void comboBoxiniciar1()
        {
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
            Celular.Location = new Point(313, 330);
            mCelular.Location = new Point(387, 323);

            //Torna visível o controle de celular e invisível o controle de telefone
            Celular.Visible = true;
            Telefone.Visible = false;

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
                MessageBox.Show("Cadastrado com sucesso");
                textNome.Text = "";
                textCpf.Text = "";
                textEndereco.Text = "";
                mCelular.Text = "";
                cContato.SelectedIndex = 0;
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
                Celular.Visible = true;

                // Esconder o painel "Telefone"
                Telefone.Visible = false;

                // Habilitar a máscara de entrada para número de celular
                mCelular.Enabled = true;

                // Mostrar a máscara de entrada para número de celular
                mCelular.Visible = true;

                // Limpar o valor atual da máscara de entrada para número de celular
                mCelular.Text = "";

                // Mover o painel "Celular" para a posição correta na tela
                Celular.Location = new Point(313, 330);

                // Mover a máscara de entrada para número de celular para a posição correta na tela
                mCelular.Location = new Point(387, 323);
            }
            // Se o item selecionado não for "Celular", verificar se é "Telefone"
            else if (cContato.SelectedItem.ToString() == "Telefone")
            {
                // Esconder o painel "Celular"
                Celular.Visible = false;

                // Mostrar o painel "Telefone"
                Telefone.Visible = true;

                // Limpar o valor atual da máscara de entrada para número de celular
                mCelular.Text = "";

                // Mover o painel "Telefone" para a posição correta na tela
                Telefone.Location = new Point(313, 330);
            

        }
        }

       

       
    }
}
