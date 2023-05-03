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
           
        }
        public int value;
        private void comboBoxiniciar3()
        {
            if (cStatus.Items.Count == 0)
            {
                cStatus.Items.Add("Ativo");
                cStatus.Items.Add("Inativo");

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
                tContato.Text = "Celular";
                mContato.Mask = "(99) 99999-9999";
                mContato.Text = "";
                tContato.Visible = true;
                mContato.Visible = true;

            }
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
        private void formatarCampoSenha()
        {
            textSenha.UseSystemPasswordChar = true;
            textSenha.PasswordChar = '*';
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted || !textRG.MaskCompleted ||
                        string.IsNullOrWhiteSpace(textEndereco.Text) || !mDataNascimento.MaskCompleted || !mContato.MaskCompleted)
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

                if (!mContato.MaskCompleted)
                {
                    MessageBox.Show("Campo 'Contao' vazio, preencha-o!");
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

                else if (!mContato.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas números no campo 'Contato'.");
                    return;
                }



                else if   (textNome.Text.All(char.IsDigit))
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
                    mContato.Text = "";
                    cContato.SelectedIndex = 0;
                    textID.Text = "";
                }
            }
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

           DadosA novaTela = new DadosA();
            novaTela.ShowDialog();
        }

        private void CContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cContato.SelectedItem.ToString() == "Celular")
            {
             

            }
            else if (cContato.SelectedItem.ToString() == "Telefone")
            {
                tContato.Text = "Telefone";
                mContato.Mask = "(99) 9999-9999";
                mContato.Text = "";
                tContato.Visible = true;
                mContato.Visible = true;
            }
        }

        private void MContato_Click_1(object sender, EventArgs e)
        {
            mContato.SelectionStart = 0;
            mContato.SelectionLength = 0;
        }
    }
}

