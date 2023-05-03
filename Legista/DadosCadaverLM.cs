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
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(textID.Text) || string.IsNullOrWhiteSpace(textGaveta.Text) || string.IsNullOrWhiteSpace(textLaudo.Text) || string.IsNullOrWhiteSpace(textMaterial.Text)
               || string.IsNullOrWhiteSpace(textQuantidade.Text) || !mHorarioChegada.MaskCompleted || !mDataRetirada.MaskCompleted || !mDataChegada.MaskCompleted)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textAssistente.Text))
                {
                    MessageBox.Show("Campo 'Assistente' vazio, preencha-o!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textLegista.Text))
                {
                    MessageBox.Show("Campo 'Legista' vazio, preencha-o!");
                    return;
                }
                // Verifica cada campo individualmente
                if (string.IsNullOrWhiteSpace(textNome.Text))
                {
                    MessageBox.Show("Campo 'Nome' vazio, preencha-o!");
                    return;
                }
                // Verifica cada campo individualmente
                if (string.IsNullOrWhiteSpace(textID.Text))
                {
                    MessageBox.Show("Campo 'ID' vazio, preencha-o!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textGaveta.Text))
                {
                    MessageBox.Show("Campo 'Gaveta' vazio, preencha-o!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textLaudo.Text))
                {
                    MessageBox.Show("Campo 'Laudo' vazio, preencha-o!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textMaterial.Text))
                {
                    MessageBox.Show("Campo 'Material' vazio, preencha-o!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textQuantidade.Text))
                {
                    MessageBox.Show("Campo 'Quantidade' vazio, preencha-o!");
                    return;
                }
                if (!mDataChegada.MaskCompleted)
                {
                    MessageBox.Show("Campo 'Data Chegada' vazio, preencha-o!");
                    return;
                }
                if (!mDataRetirada.MaskCompleted)
                {
                    MessageBox.Show("Campo 'Data Retirada' vazio, preencha-o!");
                    return;
                }

                if (!mHorarioChegada.MaskCompleted)
                {
                    MessageBox.Show("Campo 'Horário Chegada' vazio, preencha-o!");
                    return;
                }






                if (!int.TryParse(textID.Text, out int idValue))
                {
                    MessageBox.Show("ID inválido! Insira apenas números.");
                    textID.Text = "";
                    return;
                }



                else if (textAssistente.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Assistente'.");
                    return;
                }
                else if (textLegista.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Legista'.");
                    return;
                }

                else if (textNome.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                    return;
                }
                else if (textGaveta.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Gaveta'.");
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
    }
}
