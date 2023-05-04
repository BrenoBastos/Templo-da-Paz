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
        {
            InitializeComponent();
            comboBoxiniciar1();
            comboBoxiniciar2();
        }
        private void comboBoxiniciar1()
        {
            if (cEstado.Items.Count == 0)
            {
                cEstado.Items.Add("Ativo");

                cEstado.SelectedIndex = 0;
                cEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            }
           
        }
        private void comboBoxiniciar2()
        {
            if (cContato.Items.Count == 0)
            {
                cContato.Items.Add("Celular");
                cContato.Items.Add("Telefone");

                cContato.DropDownStyle = ComboBoxStyle.DropDownList;

                tContato.Text = "Celular";
                mContato.Mask = "(99) 99999-9999";
                mContato.Text = "";
                tContato.Visible = true;
                mContato.Visible = true;
                cContato.SelectedIndex = 0;

            }
        }
        
            private void textCpf_Click(object sender, EventArgs e)
        {
            textCpf.SelectionStart = 0;
            textCpf.SelectionLength = 0;
        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted 
    || string.IsNullOrWhiteSpace(textID.Text) || string.IsNullOrWhiteSpace(textEndereco.Text) 
    || string.IsNullOrWhiteSpace(mContato.Text))
{
    MessageBox.Show("Preencha todos os campos!");
    return;
}





            else if (!int.TryParse(textID.Text, out int idValue))
                {
                    MessageBox.Show("ID inválido! Insira apenas números.");
                    textID.Text = "";
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
                    textEndereco.Text = "";
                    mContato.Text = "";
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

        private void cContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cContato.SelectedItem.ToString() == "Celular")
            {
                
                    tContato.Text = "Celular";
                    mContato.Mask = "(99) 99999-9999";
                    mContato.Text = "";
                    tContato.Visible = true;
                    mContato.Visible = true;

                
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

       

        private void mContato_Click_1(object sender, EventArgs e)
        {
            mContato.SelectionStart = 0;
            mContato.SelectionLength = 0;
        }
    }
}
