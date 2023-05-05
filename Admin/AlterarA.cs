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
        private void FormatarContato()
        {
            Celular.Location = new Point(285, 153);
            mCelular.Location = new Point(350, 150);

            Celular.Visible = true;
            Telefone.Visible = false;
            mCelular.Enabled = true;
            mCelular.Visible = true;
            
            mCelular.Text = "";
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
                        string.IsNullOrWhiteSpace(textEndereco.Text)|| string.IsNullOrWhiteSpace(mCelular.Text) || !mDataNascimento.MaskCompleted )
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
           else if (!textID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas carecteres numéricos no campo 'ID'.");
                textID.Text = "";
                return;
            }
            else if (textNome.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                textNome.Text = "";
                return;

            }
            else if (cContato.SelectedItem.ToString() == "Celular" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{5}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas carecteres numéricos no campo 'Contato', preencha -o com um número de contato válido ");
                mCelular.Text = "";
                return;
            }

            else if (cContato.SelectedItem.ToString() == "Telefone" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{4}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas carecteres numéricos no campo 'Contato', preencha -o com um número de contato válido ");
                mCelular.Text = "";
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
                    mCelular.Text = "";
                    textSenha.Text = "";
                    cEstadoCivil.SelectedIndex = 0;
                    cSexo.SelectedIndex = 0;
                    mCelular.Text = "";
                    cContato.SelectedIndex = 0;
                    textID.Text = "";
                
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

                Celular.Visible = true;
                Telefone.Visible = false;
                mCelular.Enabled = true;
                mCelular.Visible = true;
                mCelular.Text = "";
                Celular.Location = new Point(285, 153);
                mCelular.Location = new Point(350,150);


            }
            else if (cContato.SelectedItem.ToString() == "Telefone")
            {
                Celular.Visible = false;
               Telefone.Visible = true;

                mCelular.Text = "";
                Telefone.Location = new Point(285, 153);


            }
        }

        private void MContato_Click_1(object sender, EventArgs e)
        {
            mCelular.SelectionStart = 0;
            mCelular.SelectionLength = 0;
        }

       
    }
}

