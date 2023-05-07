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
    public partial class AlterarA : Form
    {
        public AlterarA()
        {
            InitializeComponent();
            comboBoxiniciar1();
            comboBoxiniciar2();
            formatarCampoSenha();
            comboBoxiniciar3();
            comboBoxiniciar4();
            FormatarContato();
        }
        // Define a variável pública "value".
        public int value;

        private void comboBoxiniciar3()
        {        // Inicia o combobox "cStatus" com duas opções e define a primeira opção como selecionada por padrão.

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

            Contato1.Location = new Point(285, 153);
            mCelular.Location = new Point(350, 150);
            // Torna o controle "Celular" invisível.

            Celular.Visible = false;
            // Torna o controle "Telefone" invisível.

            Telefone.Visible = false;
            // Habilita o controle "mCelular".

            mCelular.Enabled = true;
            // Torna o controle "mCelular" visível.

            mCelular.Visible = true;
            // Define o valor do combobox "cContato" como a primeira opção.

            cContato.SelectedIndex = 0;
            // Limpa o valor do controle "mCelular".

            mCelular.Text = "";
        }

        private void formatarCampoSenha()
        {        // Define o estilo de exibição do controle "textSenha" como PasswordChar.

            textSenha.UseSystemPasswordChar = true;
            textSenha.PasswordChar = '*';
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textSenha.UseSystemPasswordChar)
            {
                // Se a propriedade UseSystemPasswordChar for true, a senha está oculta,
                // então vamos mostrar a senha e alterar o texto do botão para "OcultarSenha".
                textSenha.UseSystemPasswordChar = false;
                textSenha.PasswordChar = '\0'; // '\0' é um caractere nulo, que não exibe nada na senha.
                lSenha.Text = "OcultarSenha";
            }
            else
            {
                // Se a propriedade UseSystemPasswordChar for false, a senha está visível,
                lSenha.Text = "MostrarSenha";
                // então vamos ocultar a senha e alterar o texto do botão para "MostrarSenha".

                textSenha.UseSystemPasswordChar = true;
                textSenha.PasswordChar = '*'; // '*' é um caractere que é exibido como substituto para a senha.
            }
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
            else if (cContato.SelectedItem.ToString() == "Celular" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{5}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Contato', preencha-o com um número de celular válido.");
                mCelular.Text = "";
                return;
            }

            // Verifica se o campo Contato foi preenchido com um número de telefone válido
            else if (cContato.SelectedItem.ToString() == "Telefone" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{4}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Contato', preencha-o com um número de telefone válido.");
                mCelular.Text = "";
                return;
            }

            // Caso nenhum erro seja encontrado, atualiza os dados do cliente
            else
            {
                MessageBox.Show("Alterado com sucesso!");

                // Limpa os campos de entrada
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
                textID.Text = "";

                // Esconde campos desnecessários
                Celular.Visible = false;
                Telefone.Visible = false;
                mCelular.Enabled = true;
                mCelular.Visible = true;
                Contato1.Visible = true;
                mCelular.Text = "";
            }


        }
    

        private void bVoltar_Click(object sender, EventArgs e)
        {// Esconde a janela atual antes de exibir uma nova
            this.Hide();
            // Cria uma nova instância do formulário DadosA
            DadosA novaTela = new DadosA();
            // Exibe o formulário DadosA como uma caixa de diálogo
            novaTela.ShowDialog(); 

        }

        private void CContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cContato.SelectedItem.ToString() == "Celular")
            {// Oculta o controle Contato1
                Contato1.Visible = false;
                // Exibe o controle Celular
                Celular.Visible = true;
                // Oculta o controle Telefone
                Telefone.Visible = false;
                // Habilita o controle de entrada de dados mCelular
                mCelular.Enabled = true;
                // Exibe o controle de entrada de dados mCelular
                mCelular.Visible = true;
                // Limpa o valor atual do controle mCelular
                mCelular.Text = "";
                // Define a posição do controle Celular na tela
                Celular.Location = new Point(285, 153);
                // Define a posição do controle de entrada de dados mCelular na tela
                mCelular.Location = new Point(350, 150);
            }
            else if (cContato.SelectedItem.ToString() == "Telefone")
            { // Oculta o controle Contato1
                Contato1.Visible = false;
                // Oculta o controle Celular
                Celular.Visible = false;
                // Exibe o controle Telefone
                Telefone.Visible = true;
                // Habilita o controle de entrada de dados mCelular
                mCelular.Enabled = true;
                // Exibe o controle de entrada de dados mCelular
                mCelular.Visible = true;
                // Limpa o valor atual do controle mCelular
                mCelular.Text = "";
                // Define a posição do controle Telefone na tela
                Telefone.Location = new Point(285, 153); 
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

