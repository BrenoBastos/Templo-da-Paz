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
    public partial class CadastrarL : Form
    {
        public CadastrarL()
        {
            InitializeComponent();
            // Inicializa o combobox do estado civil
            comboBoxiniciar1();
                                // Inicializa o combobox do sexo
            comboBoxiniciar2();
            // Inicializa o combobox do status
            comboBoxiniciar3(); 
            // Inicializa o combobox do tipo de contato
            comboBoxiniciar4(); 
            // Formata o campo do telefone/celular
            FormatarContato(); 
            // Formata o campo da senha
            formatarCampoSenha();
            textID.Enabled = false;

        }
        // Declaração de uma variável pública "value"
        public int value; 

        private void FormatarContato()
        {
            // Define a localização dos componentes de telefone/celular na tela
            Celular.Location = new Point(261, 215);
            mCelular.Location = new Point(335, 208);
            // Torna o componente do telefone visível
            Celular.Visible = true; 
                                    // Torna o componente do celular invisível
            Telefone.Visible = false;
            // Habilita o campo de telefone/celular
            mCelular.Enabled = true; 
                                     // Torna o campo de telefone/celular visível
            mCelular.Visible = true;
                                     // Define o texto do campo de telefone/celular como vazio
            mCelular.Text = "";
        }

        private void comboBoxiniciar1()
        { // Verifica se o combobox está vazio
            if (cEstadoCivil.Items.Count == 0)
            {
                // Adiciona os itens de estado civil ao combobox
                cEstadoCivil.Items.Add("Solteiro(a)");
                cEstadoCivil.Items.Add("Casado(a)");
                cEstadoCivil.Items.Add("União Estável");
                cEstadoCivil.Items.Add("Viúvo(a)");
                // Seleciona o primeiro item do combobox
                cEstadoCivil.SelectedIndex = 0; 
                                                // Define o estilo do combobox como DropDownList
                cEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void comboBoxiniciar2()
        { // Verifica se o combobox está vazio
            if (cSexo.Items.Count == 0)
            {
                // Adiciona os itens de sexo ao combobox
                cSexo.Items.Add("Masculino");
                cSexo.Items.Add("Feminino");
                cSexo.Items.Add("Não definido");
                // Seleciona o primeiro item do combobox
                cSexo.SelectedIndex = 0; 
                // Define o estilo do combobox como DropDownList
                cSexo.DropDownStyle = ComboBoxStyle.DropDownList; 
            }
        }

        private void comboBoxiniciar3()
        {// Verifica se o combobox está vazio
            if (cStatus.Items.Count == 0) 
            {
                // Adiciona o item "Ativo" ao combobox
                cStatus.Items.Add("Ativo");
                cStatus.Items.Add("Inativo");

                // Seleciona o primeiro item do combobox
                cStatus.SelectedIndex = 0;
                // Define o estilo do combobox como DropDownList
                cStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void comboBoxiniciar4()
        { // Verifica se o combobox está vazio
            if (cContato.Items.Count == 0)
            {
                // Adiciona os itens "Celular" e "Telefone" ao combobox
                cContato.Items.Add("Celular");
                cContato.Items.Add("Telefone");
                // Seleciona o primeiro item do combobox
                cContato.SelectedIndex = 0;
                // Define o estilo do combobox
                cContato.DropDownStyle = ComboBoxStyle.DropDownList; 

            }
        }
        private void formatarCampoSenha()
        { // Define que o campo senha deve ser exibido como asteriscos
            textSenha.UseSystemPasswordChar = true;
                                                    // Define o caractere usado para representar a senha como asterisco
            textSenha.PasswordChar = '*'; 


        }
        private void lSenha_Click(object sender, EventArgs e)
        {
            if (textSenha.UseSystemPasswordChar)
            {// Mostra a senha real
                textSenha.UseSystemPasswordChar = false;
                // Define que não deve haver caractere ocultador para a senha
                textSenha.PasswordChar = '\0';
                // Altera o texto do link para "OcultarSenha"
                lSenha.Text = "OcultarSenha";
            }
            else
            {// Altera o texto do link para "MostrarSenha"
                lSenha.Text = "MostrarSenha";
                // Oculta a senha com asteriscos
                textSenha.UseSystemPasswordChar = true;
                ; // Define o caractere a ser usado para representar a senha como asterisco
                textSenha.PasswordChar = '*';
            }
        }

        private void textCpf_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            textCpf.SelectionStart = 0;
            // Define o comprimento da seleção para 0

            textCpf.SelectionLength = 0;
        }

        private void textRG_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            textRG.SelectionStart = 0;
            // Define o comprimento da seleção para 0

            textRG.SelectionLength = 0;
        }

        private void mDataNascimento_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            mDataNascimento.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mDataNascimento.SelectionLength = 0;
        }

        private void lSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textSenha.UseSystemPasswordChar)
            { // Mostra a senha real
                textSenha.UseSystemPasswordChar = false;
                // Define que não deve haver caractere ocultador para a senha
                textSenha.PasswordChar = '\0'; 
                                               // Altera o texto do link para "OcultarSenha"
                lSenha.Text = "OcultarSenha"; 
            }
            else
            { // Altera o texto do link para "MostrarSenha"
                lSenha.Text = "MostrarSenha";
                textSenha.UseSystemPasswordChar = true;
                // Oculta a senha com asteriscos
                textSenha.PasswordChar = '*'; 
            }
        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {    // Verifica se todos os campos obrigatórios foram preenchidos corretamente

            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted || !textRG.MaskCompleted ||
                      string.IsNullOrWhiteSpace(textEndereco.Text) || !mCRM.MaskCompleted || !mDataNascimento.MaskCompleted || string.IsNullOrWhiteSpace(mCelular.Text))
            {        // Se algum campo estiver vazio ou não preenchido corretamente, exibe uma mensagem de erro e interrompe a execução do método

                MessageBox.Show("Preencha todos os campos!");
                return;
            }    // Verifica se o campo "ID" contém apenas caracteres numéricos

            else if (!textID.Text.All(char.IsDigit))
            {        // Se houver algum caractere que não seja um número, exibe uma mensagem de erro e limpa o campo "ID"

                MessageBox.Show("Por favor, insira apenas carecteres numéricos  no campo 'ID'.");
                textID.Text = "";
                    return;
                }

            // Verifica se o campo "Contato" foi preenchido corretamente (com um número de celular válido)

            else if (cContato.SelectedItem.ToString() == "Celular" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{5}-\d{4}$"))
            {        // Se o campo "Contato" for "Celular" e o número de celular não for válido, exibe uma mensagem de erro e limpa o campo "Celular"

                MessageBox.Show("Por favor, insira apenas carecteres numéricos  no  campo 'Contato' inválido, preencha-o com um número de contato válido ");
                mCelular.Text = "";
                return;
            }
            // Verifica se o campo "Contato" foi preenchido corretamente (com um número de  telefone válido)

            else if (cContato.SelectedItem.ToString() == "Telefone" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{4}-\d{4}$"))
            {        // Se o campo "Contato" for "Telefone" e o número de telefone não for válido, exibe uma mensagem de erro e limpa o campo "Telefone"

                MessageBox.Show("Por favor, insira apenas carecteres numéricos  no  campo 'Contato' inválido, preencha-o com um número de contato válido ");
                mCelular.Text = "";
                return;
            }



            // Verifica se o campo "Nome" contém apenas caracteres de texto

            else if (textNome.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                textNome.Text = "";
                return;
                }
                else
            {// Se todas as verificações passarem, os dados são cadastrados com sucesso

                MessageBox.Show("Cadastrado com sucesso");
                //limpa todos os campos e faz combobox voltar pra padrão
                    textNome.Text = "";
                    textCpf.Text = "";
                    textRG.Text = "";
                    textEndereco.Text = "";
                    mDataNascimento.Text = "";
                  mCelular.Text = "";
                    textSenha.Text = "";
                    cEstadoCivil.SelectedIndex = 0;
                    cSexo.SelectedIndex = 0;
                    mCRM.Text = "";
                    cStatus.SelectedIndex = 0;
                cContato.SelectedIndex = 0;
                    textID.Text = "";
                
            }
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {// Esconde a janela atual
            this.Hide();
            // Cria uma nova instância da classe Admin1

            Admin1 novaTela = new Admin1();
            // Mostra a nova instância da janela Admin1

            novaTela.ShowDialog();
        }

        private void mCRM_Click(object sender, EventArgs e)
        {
            // Define o início da seleção para 0
            mCRM.SelectionStart = 0;
            // Define o comprimento da seleção para 0

            mCRM.SelectionLength = 0;
        }

        private void cContato_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Verifica se o item selecionado é "Celular"
            if (cContato.SelectedItem.ToString() == "Celular")
            {
                // Define a visibilidade dos controles
                Celular.Visible = true;
                Telefone.Visible = false;

                // Habilita a caixa de texto para digitar o número do celular
                mCelular.Enabled = true;

                // Define a posição dos controles na tela
                Celular.Location = new Point(261, 215);
                mCelular.Location = new Point(335, 208);

                // Limpa o conteúdo da caixa de texto
                mCelular.Text = "";
            }
            // Caso contrário, se o item selecionado for "Telefone"
            else if (cContato.SelectedItem.ToString() == "Telefone")
            {
                // Define a visibilidade dos controles
                Celular.Visible = false;
                Telefone.Visible = true;

                // Define a posição da caixa de texto na tela
                mCelular.Location = new Point(335, 208);

                // Limpa o conteúdo da caixa de texto
                mCelular.Text = "";

                // Define a posição dos controles na tela
                Telefone.Location = new Point(261, 215);
            }
        }
        private void mContato_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

       
    }
}
