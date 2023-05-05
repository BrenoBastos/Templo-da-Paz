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
    public partial class DadosCadaverLM : Form
    {
        public DadosCadaverLM()
        {
            InitializeComponent(); 
            comboBoxiniciar();

        }
        private void comboBoxiniciar()
        {
            if (cRetirada.Items.Count == 0)
            {
                cRetirada.Items.Add("Espera");
                cRetirada.Items.Add("IML");
                cRetirada.Items.Add("Funerária");
                cRetirada.SelectedIndex = 0;
                cRetirada.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(textID.Text) || string.IsNullOrWhiteSpace(textGaveta.Text) || string.IsNullOrWhiteSpace(textLaudo.Text) || string.IsNullOrWhiteSpace(textMaterial.Text)
               || string.IsNullOrWhiteSpace(textQuantidade.Text) || !mHorarioChegada.MaskCompleted || !mDataObito.MaskCompleted || !mHorárioÓbito.MaskCompleted || !mDataRetirada.MaskCompleted || !mDataChegada.MaskCompleted)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
           
               




             else   if (!textID.Text.All(char.IsDigit))
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
                else if (textLegista.Text.All(char.IsDigit))
                {
                MessageBox.Show("Por favor, insira apenas carecteres no campo 'Legista'.");
                textLegista.Text = "";
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
                    MessageBox.Show("ALterado com sucesso");
                    textNome.Text = "";
                    textID.Text = "";
                    textGaveta.Text = "";
                    textLaudo.Text = "";
                    textMaterial.Text = "";
                    textQuantidade.Text = "";
                    mDataChegada.Text = "";
                    mDataRetirada.Text = "";
                    mHorarioChegada.Text = "";
                    textAssistente.Text = "";
                    textLegista.Text = "";

                
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

        private void mDataRetirada_Click(object sender, EventArgs e)
        {
            mDataRetirada.SelectionStart = 0;
            mDataRetirada.SelectionLength = 0;
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            DadosCadaverL novaTela = new DadosCadaverL();
            novaTela.ShowDialog();
        }

        private void mHorarioRetirada_Click(object sender, EventArgs e)
        {
            mHorarioRetirada.SelectionStart = 0;
            mHorarioRetirada.SelectionLength = 0;
        }

        private void DataÓbito_Click(object sender, EventArgs e)
        {

        }

        private void mDataObito_Click(object sender, EventArgs e)
        {
            mDataObito.SelectionStart = 0;
            mDataObito.SelectionLength = 0;
        }

        private void mHorárioÓbito_Click(object sender, EventArgs e)
        {
            mHorárioÓbito.SelectionStart = 0;
            mHorárioÓbito.SelectionLength = 0;
        }

        private void cRetirada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
