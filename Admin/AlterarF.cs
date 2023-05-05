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
            FormatarContato();
            comboBoxiniciar4();

        }
        public int value;
        private void comboBoxiniciar1()
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
        private void FormatarContato()
        {
            Celular.Location = new Point(309, 262);
            Celular.Visible = true;
            Telefone.Visible = false;
            mCelular.Enabled = true;
            mCelular.Visible = true;

            mCelular.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted ||
                      string.IsNullOrWhiteSpace(textEndereco.Text) || string.IsNullOrWhiteSpace(mCelular.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }


        
           
            else if (cContato.SelectedItem.ToString() == "Celular" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{5}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos  no campo 'Contato', preencha -o com um número de contato válido .");
                mCelular.Text = "";
                return;
            }

            else if (cContato.SelectedItem.ToString() == "Telefone" && !Regex.IsMatch(mCelular.Text, @"^^(\(\d{2}\))?\s?\d{4}-\d{4}$"))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos  no campo 'Contato', preencha -o com um número de contato válido .");
                mCelular.Text = "";
                return;
            }
           

            else if (textNome.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");

                    textNome.Text = "";
                    return;

            }
            else if (!textID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas carecteres numéricos no campo 'ID'.");
                textID.Text = "";
                return;
            }
            else
                {
                    MessageBox.Show("alterado com sucesso");
                    textNome.Text = "";
                    textCpf.Text = "";
                    textEndereco.Text = "";
                    mCelular.Text = "";
                    textID.Text = "";
                }
            

        }

        

        private void textCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textCpf_Click(object sender, EventArgs e)
        {
            textCpf.SelectionStart = 0;
            textCpf.SelectionLength = 0;
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


                Celular.Visible = true;
                Telefone.Visible = false;
                mCelular.Enabled = true;
                mCelular.Visible = true;
                mCelular.Text = "";
                Celular.Location = new Point(309, 262);
                mCelular.Location = new Point(374, 259);


            }
            else if (cContato.SelectedItem.ToString() == "Telefone")
            {
                Telefone.Location = new Point(309, 262);
                mCelular.Location = new Point(374, 259);


                Celular.Visible = false;
                Telefone.Visible = true;
                mCelular.Enabled = true;
                mCelular.Visible = true;
                mCelular.Text = "";
            }
        }

     
        
        private void mCelular_Click(object sender, EventArgs e)
        {
            mCelular.SelectionStart = 0;
            mCelular.SelectionLength = 0;
        }
    }
}
