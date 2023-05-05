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
            comboBoxiniciar1();
            comboBoxiniciar2();
            comboBoxiniciar3();
            comboBoxiniciar4();
            FormatarContato();

            formatarCampoSenha();
        }
        public int value;

        private void FormatarContato()
        {
            Celular.Location = new Point(261, 215);
            mCelular.Location = new Point(335, 208);

            Celular.Visible = true;
            Telefone.Visible = false;
            mCelular.Enabled = true;
            mCelular.Visible = true;

            mCelular.Text = "";
        }
        private void comboBoxiniciar1()
        {
            if (cEstadoCivil.Items.Count == 0)
            {
                cEstadoCivil.Items.Add("Solteiro(a)");
                cEstadoCivil.Items.Add("Casado(a)");
                cEstadoCivil.Items.Add("União Estável");
                cEstadoCivil.Items.Add("Viúvo(a)");

                cEstadoCivil.SelectedIndex = 0;
                cEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
        private void comboBoxiniciar2()
        {
            if (cSexo.Items.Count == 0)
            {
                cSexo.Items.Add("Masculino");
                cSexo.Items.Add("Feminino");
                cSexo.Items.Add("Outro");
                cSexo.SelectedIndex = 0;
                cSexo.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
        private void comboBoxiniciar3()
        {
            if (cStatus.Items.Count == 0)
            {
                cStatus.Items.Add("Ativo");

                cStatus.SelectedIndex = 0;
                cStatus.DropDownStyle = ComboBoxStyle.DropDownList;
               
            }
        }
        private void comboBoxiniciar4()
        {
            if (cContato.Items.Count == 0)
            {
                cContato.Items.Add("Celular");
                cContato.Items.Add("Telefone");

                cContato.SelectedIndex = 0;
                cContato.DropDownStyle = ComboBoxStyle.DropDownList;
            
            }
        }
        private void formatarCampoSenha()
        {
            textSenha.UseSystemPasswordChar = true;
            textSenha.PasswordChar = '*';


        }
        private void lSenha_Click(object sender, EventArgs e)
        {
            if (textSenha.UseSystemPasswordChar)
            {
                textSenha.UseSystemPasswordChar = false;
                textSenha.PasswordChar = '\0';
                lSenha.Text = "OcultarSenha";
            }
            else
            {
                lSenha.Text = "MostrarSenha";
                textSenha.UseSystemPasswordChar = true;
                textSenha.PasswordChar = '*';
            }
        }

        private void textCpf_Click(object sender, EventArgs e)
        {
            textCpf.SelectionStart = 0;
            textCpf.SelectionLength = 0;
        }

        private void textRG_Click(object sender, EventArgs e)
        {
            textRG.SelectionStart = 0;
            textRG.SelectionLength = 0;
        }

        private void mDataNascimento_Click(object sender, EventArgs e)
        {
            mDataNascimento.SelectionStart = 0;
            mDataNascimento.SelectionLength = 0;
        }

        private void lSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textSenha.UseSystemPasswordChar)
            {
                textSenha.UseSystemPasswordChar = false;
                textSenha.PasswordChar = '\0';
                lSenha.Text = "OcultarSenha";
            }
            else
            {
                lSenha.Text = "MostrarSenha";
                textSenha.UseSystemPasswordChar = true;
                textSenha.PasswordChar = '*';
            }
        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted || !textRG.MaskCompleted ||
                      string.IsNullOrWhiteSpace(textEndereco.Text) || !mCRM.MaskCompleted || !mDataNascimento.MaskCompleted || string.IsNullOrWhiteSpace(mCelular.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else if (!textID.Text.All(char.IsDigit))
                {
                MessageBox.Show("Por favor, insira apenas carecteres numéricos  no campo 'ID'.");
                textID.Text = "";
                    return;
                }


            else if (cContato.SelectedItem.ToString() == "Celular" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{5}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas carecteres numéricos  no  campo 'Contato' inválido, preencha-o com um número de contato válido ");
                mCelular.Text = "";
                return;
            }

            else if (cContato.SelectedItem.ToString() == "Telefone" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{4}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas carecteres numéricos  no  campo 'Contato' inválido, preencha-o com um número de contato válido ");
                mCelular.Text = "";
                return;
            }




            else if (textNome.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                textNome.Text = "";
                return;
                }
                else
                {
                    MessageBox.Show("Cadastrado com sucesso");
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
        {
            this.Hide();

            Admin1 novaTela = new Admin1();
            novaTela.ShowDialog();
        }

        private void mCRM_Click(object sender, EventArgs e)
        {

            mCRM.SelectionStart = 0;
            mCRM.SelectionLength = 0;
        }

        private void cContato_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cContato.SelectedItem.ToString() == "Celular")
            {

                Celular.Visible = true;
                Telefone.Visible = false;
                mCelular.Enabled = true;
                mCelular.Visible = true;
                mCelular.Text = "";
                Celular.Location = new Point(261, 215);
                mCelular.Location = new Point(335, 208);


            }
            else if (cContato.SelectedItem.ToString() == "Telefone")
            {
                Celular.Visible = false;
                Telefone.Visible = true;
                mCelular.Location = new Point(335, 208);

                mCelular.Text = "";
                Telefone.Location = new Point(261, 215);


            }
        }
        private void mContato_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

       
    }
}
