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
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted  ||
                      string.IsNullOrWhiteSpace(textEndereco.Text) || !mContato.MaskCompleted)
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
                string numero = Regex.Replace(mContato.Text, @"[^\d]+", "");

                if (!Regex.IsMatch(mContato.Text, @"^^(\(\d{2}\))?\s?\d{4,5}-\d{4}$"))
                {
                    MessageBox.Show("Campo 'Contato' vazio ou inválido, preencha-o com um número de contato válido no formato (99) 9999-9999 ou (99) 99999-9999.");
                    return;
                }

                if (!textCpf.MaskCompleted)
                {
                    MessageBox.Show("Campo 'CPF' vazio, preencha-o!");
                    return;
                }
              

                if (string.IsNullOrWhiteSpace(textEndereco.Text))
                {
                    MessageBox.Show("Campo 'Endereço' vazio, preencha-o!");
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
            
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            DadosF novaTela = new DadosF();
            novaTela.ShowDialog();
        }
    }
}
