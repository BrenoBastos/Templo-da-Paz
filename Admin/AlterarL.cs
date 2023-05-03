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
            comboBoxiniciar1();
            comboBoxiniciar2();
            comboBoxiniciar3();

            formatarCampoSenha();

        }
        public int value;


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
            if (cEstado.Items.Count == 0)
            {
                cEstado.Items.Add("Ativo");
                cEstado.Items.Add("Inativo");
               
                cEstado.SelectedIndex = 0;
                cEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
        private void formatarCampoSenha()
        {
            textSenha.UseSystemPasswordChar = true;
            textSenha.PasswordChar = '*';


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

        private void mContato_Click(object sender, EventArgs e)
        {

        }

        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {




        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted || !textRG.MaskCompleted ||
                       string.IsNullOrWhiteSpace(textEndereco.Text) || !mNum.MaskCompleted || !mDataNascimento.MaskCompleted || !mContato.MaskCompleted)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else
            {

                // Verifica cada campo individualmente
                if (string.IsNullOrWhiteSpace(textNome.Text))
                {
                    MessageBox.Show("Campo 'Nome' vazio, preencha-o!");
                    return;
                }


                if (!textCpf.MaskCompleted)
                {
                    MessageBox.Show("Campo 'CPF' vazio, preencha-o!");
                    return;
                }
                if (!textRG.MaskCompleted)
                {
                    MessageBox.Show("Campo 'RG' vazio, preencha-o!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textEndereco.Text))
                {
                    MessageBox.Show("Campo 'Endereço' vazio, preencha-o!");
                    return;
                }

                if (!mDataNascimento.MaskCompleted)
                {
                    MessageBox.Show("Campo 'Data de Nascimento' vazio, preencha-o!");
                    return;
                }
                if (!mNum.MaskCompleted)
                {
                    MessageBox.Show("Campo 'Data de Nascimento' vazio, preencha-o!");
                    return;
                }

                // verifica se o valor do campo Contato está no formato correto
                if (!Regex.IsMatch(mContato.Text, @"^^(\(\d{2}\))?\s?\d{4,5}-\d{4}$"))
                {
                    MessageBox.Show("Campo 'Contato' vazio ou inválido, preencha-o com um número de contato válido no formato (99) 9999-9999 ou (99) 99999-9999.");
                    return;
                }



                else if (string.IsNullOrWhiteSpace(textSenha.Text))
                {
                    MessageBox.Show("Campo 'Senha' vazio, preencha-o!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textID.Text))
                {
                    MessageBox.Show("Campo 'ID' vazio, preencha-o!");
                    return;
                }

                if (!int.TryParse(textID.Text, out int idValue))
                {
                    MessageBox.Show("ID inválido! Insira apenas números.");
                    textID.Text = "";
                    return;
                }




                else if (textNome.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                    return;
                }
                else
                {
                    MessageBox.Show("alterado com sucesso");
                    textNome.Text = "";
                    textCpf.Text = "";
                    textRG.Text = "";
                    textEndereco.Text = "";
                    mDataNascimento.Text = "";
                    mContato.Text = "";
                    textSenha.Text = "";
                    cEstadoCivil.SelectedIndex = 0;
                    cSexo.SelectedIndex = 0;
                    mNum.Text = "";
                    cEstado.SelectedIndex = 0;

                    textID.Text = "";
                }
            }
        
    }

        private void lSenha_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void mNum_Click(object sender, EventArgs e)
        {
            mNum.SelectionStart = 0;
            mNum.SelectionLength = 0;
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            DadosL novaTela = new DadosL();
            novaTela.ShowDialog();
        }
    }
}
