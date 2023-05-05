using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CadastrarCadaverA : Form
    {
        public CadastrarCadaverA()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNome.Text)  || string.IsNullOrWhiteSpace(textGaveta.Text) ||
                     string.IsNullOrWhiteSpace(textID.Text) || !mDataChegada.MaskCompleted || !mHorarioChegada.MaskCompleted )
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

            else if (textAssistente.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas carecteres no campo 'Assistente'.");
                textAssistente.Text = "";
                return;
            }


            else if (textNome.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                textNome.Text = "";
                return;
                }
                else if (textGaveta.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Gaveta'.");
                textGaveta.Text = "";
                return;
                }
                else
                {
                    MessageBox.Show("Cadastrado com sucesso");
                    textNome.Text = "";
                    textID.Text = "";
                    textGaveta.Text = "";
                    mDataChegada.Text = "";
                    mHorarioChegada.Text = "";
                    textAssistente.Text = "";

           
                }
            }
        

        private void mDataChegada_Click(object sender, EventArgs e)
        {
            mDataChegada.SelectionStart = 0;
            mDataChegada.SelectionLength = 0;
        }

        private void mHorarioChegada_Click(object sender, EventArgs e)
        {
            mHorarioChegada.SelectionStart = 0;
            mHorarioChegada.SelectionLength = 0;
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Assistente novaTela = new Assistente();
            novaTela.ShowDialog();
        }
    }
}
