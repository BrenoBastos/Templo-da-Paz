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
    public partial class AlterarF : Form
    {
        public AlterarF()
        {
            InitializeComponent();
            comboBoxiniciar1();


        }
        public int value;
        private void comboBoxiniciar1()
        {
            if (cEstado.Items.Count == 0)
            {
                cEstado.Items.Add("Ativo");
                cEstado.Items.Add("Inativo");

                cEstado.SelectedIndex = 0;
                cEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            }
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
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted ||
                      string.IsNullOrWhiteSpace(textEndereco.Text) || !mContato.MaskCompleted)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else
            {

              
                if (!int.TryParse(textID.Text, out int idValue))
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
                    MessageBox.Show("alterado com sucesso");
                    textNome.Text = "";
                    textCpf.Text = "";
                    textEndereco.Text = "";
                    mContato.Text = "";

                    textID.Text = "";
                }
            }

        }

        private void mContato_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mContato.SelectionStart = 0;
            mContato.SelectionLength = 0;
        }

        private void textCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textCpf_Click(object sender, EventArgs e)
        {
            textCpf.SelectionStart = 0;
            textCpf.SelectionLength = 0;
        }

        private void mContato_Click(object sender, EventArgs e)
        {
            mContato.SelectionStart = 0;
            mContato.SelectionLength = 0;
        
    }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            DadosF novaTela = new DadosF();
            novaTela.ShowDialog();
        }

        private void cContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cContato.SelectedItem.ToString() == "Celular")
            {
                {
                    tContato.Text = "Celular";
                    mContato.Mask = "(99) 99999-9999";
                    mContato.Text = "";
                    tContato.Visible = true;
                    mContato.Visible = true;

                }
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
