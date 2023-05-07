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
    public partial class AlterarL : Form
    {
        public AlterarL()
        {
            InitializeComponent();
            // Chama a função comboBoxiniciar1(), que provavelmente preenche um combobox com opções.
            comboBoxiniciar1();

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


        }
        // Declaração de uma variável do tipo inteiro chamada "value".
        public int value;
        private void comboBoxiniciar5()
        { // Verifica se a lista de itens do controle "cContato" está vazia.
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
            Contato1.Visible = true;

            // Define a visibilidade do controle "Telefone" como falsa.
            Telefone.Visible = false;

            // Habilita o controle "mCelular".
            mCelular.Enabled = true;

            // Define a visibilidade do controle "mCelular" como verdadeira.
            mCelular.Visible = true;

            // Define a visibilidade do controle "Celular" como falsa.
            Celular.Visible = false;

            // Define a posição do controle "Contato1".
            Contato1.Location = new Point(192, 125);

            // Define o valor do controle "mCelular" como uma string vazia.
            mCelular.Text = "";
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
        {// Se a propriedade UseSystemPasswordChar da caixa de texto textSenha estiver definida como true,
         // isso significa que o caractere de senha do sistema está sendo usado para ocultar a senha.
            if (textSenha.UseSystemPasswordChar)
            {// Desabilita o uso do caractere de senha do sistema.
                textSenha.UseSystemPasswordChar = false;
                // Define o caractere de senha como vazio para mostrar a senha sem ocultá-la.
                textSenha.PasswordChar = '\0';
                // Altera o texto do controle de rótulo lSenha para indicar que a senha agora está sendo exibida.
                lSenha.Text = "OcultarSenha";
            }
            // Se a propriedade UseSystemPasswordChar da caixa de texto textSenha estiver definida como false,
            // isso significa que o caractere de senha personalizado está sendo usado para ocultar a senha.
            else
            {// Altera o texto do controle de rótulo lSenha para indicar que a senha agora será ocultada.
                lSenha.Text = "MostrarSenha";
                // Habilita o uso do caractere de senha do sistema para ocultar a senha.
                textSenha.UseSystemPasswordChar = true;
                // Define o caractere de senha como '*' para ocultar a senha.
                textSenha.PasswordChar = '*';
            }
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
            else if (cContato.SelectedItem.ToString() == "Celular" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{5}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Contato' inválido, preencha-o com um número de contato válido.");
                mCelular.Text = "";
                return;
            }

            // Verifica se o tipo de contato selecionado é "Telefone" e se o número inserido está no formato correto.
            // Se o formato estiver incorreto, exibe uma mensagem de erro e limpa o campo de entrada.
            else if (cContato.SelectedItem.ToString() == "Telefone" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{4}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Contato' inválido, preencha-o com um número de contato válido.");
                mCelular.Text = "";
                return;
            }

            // Se todas as validações passarem, exibe uma mensagem de sucesso e limpa todos os campos.
            else
            {
                MessageBox.Show("Alterado com sucesso.");
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
                cStatus.SelectedIndex = 0;
                textID.Text = "";
                Celular.Visible = false;
                Telefone.Visible = false;
                mCelular.Enabled = true;
                mCelular.Visible = true;
                Contato1.Visible = true;
                cContato.SelectedIndex = 0;
                mCelular.Text = "";
            }



        }

        private void lSenha_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Se a propriedade UseSystemPasswordChar da caixa de texto textSenha estiver definida como true,
            // isso significa que o caractere de senha do sistema está sendo usado para ocultar a senha.
            if (textSenha.UseSystemPasswordChar)
            {// Desabilita o uso do caractere de senha do sistema.
                textSenha.UseSystemPasswordChar = false;
                // Define o caractere de senha como vazio para mostrar a senha sem ocultá-la.
                textSenha.PasswordChar = '\0';
                // Altera o texto do controle de rótulo lSenha para indicar que a senha agora está sendo exibida.
                lSenha.Text = "OcultarSenha";
            }
            // Se a propriedade UseSystemPasswordChar da caixa de texto textSenha estiver definida como false,
            // isso significa que o caractere de senha personalizado está sendo usado para ocultar a senha.
            else
            {// Altera o texto do controle de rótulo lSenha para indicar que a senha agora será ocultada.
                lSenha.Text = "MostrarSenha";
                // Habilita o uso do caractere de senha do sistema para ocultar a senha.
                textSenha.UseSystemPasswordChar = true;
                // Define o caractere de senha como '*' para ocultar a senha.
                textSenha.PasswordChar = '*';
            }
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
            if (cContato.SelectedItem.ToString() == "Celular")
            {            // Esconde o controle Contato1

                Contato1.Visible = false;
                // Mostra o controle Celular
                Celular.Visible = true;
                // Esconde o controle Telefone
                Telefone.Visible = false;
                // Habilita o controle mCelular
                mCelular.Enabled = true;
                // Mostra o controle mCelular
                mCelular.Visible = true;
                // Define o texto do controle mCelular como vazio
                mCelular.Text = "";
                // Define a posição do controle Celular como (192, 125)
                Celular.Location = new Point(192, 125);


            }
            // Se o item selecionado em cContato for "Telefone"
            else if (cContato.SelectedItem.ToString() == "Telefone")
            { // Esconde o controle Contato1
                Contato1.Visible = false;
                // Esconde o controle Celular
                Celular.Visible = false;
                // Mostra o controle Telefone
                Telefone.Visible = true;

                // Define o texto do controle mCelular como vazio

                mCelular.Text = "";
                // Define a posição do controle Telefone como (192, 125)

                Telefone.Location = new Point(192,125);


            }
        }

      
        private void mCelular_Click(object sender, EventArgs e)
        {// Define o início da seleção como o caractere 0
            mCelular.SelectionStart = 0;
            // Define o comprimento da seleção como 0
            mCelular.SelectionLength = 0;
        }

       
    }
}
