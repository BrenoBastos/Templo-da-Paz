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
            FormatarContato();
        }
        private void comboBoxiniciar1()
        {
            if (cStatus.Items.Count == 0)
            {
                cStatus.Items.Add("Ativo");

                cStatus.SelectedIndex = 0;
                cStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            }
           
        }
        private void comboBoxiniciar2()
        {
            if (cContato.Items.Count == 0)
            {
                cContato.Items.Add("Celular");
                cContato.Items.Add("Telefone");

                cContato.DropDownStyle = ComboBoxStyle.DropDownList;

                cContato.SelectedIndex = 0;

            }
        }
        private void FormatarContato()
        {
            Celular.Location = new Point(313, 330);
            mCelular.Location = new Point(387, 323);

            Celular.Visible = true;
            Telefone.Visible = false;
            mCelular.Enabled = true;
            mCelular.Visible = true;

            mCelular.Text = "";
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
    || string.IsNullOrWhiteSpace(mCelular.Text))
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
                    textEndereco.Text = "";
                   mCelular.Text = "";
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

                Celular.Visible = true;
                Telefone.Visible = false;
                mCelular.Enabled = true;
                mCelular.Visible = true;
                mCelular.Text = "";
                Celular.Location = new Point(313, 330);
                mCelular.Location = new Point(387, 323);


            }
            else if (cContato.SelectedItem.ToString() == "Telefone")
            {
                Celular.Visible = false;
                Telefone.Visible = true;

                mCelular.Text = "";
                Telefone.Location = new Point(313, 330);


            }
        }

       

       
    }
}
