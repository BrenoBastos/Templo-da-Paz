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
    public partial class DadosA : Form
    {
        public DadosA()
        {
            InitializeComponent();
            dDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void bLocalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNome1.Text))
            {
                MessageBox.Show("Campo 'Nome' vazio, preencha-o!");
                return;

            }

            else
            {
                if (textNome1.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                    return;
                }
                else
                {
                    MessageBox.Show("Localizado com sucesso");
                    textNome1.Text = "";
                }
            }
            }

        private void dDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();

            AlterarA novaTela = new AlterarA();
            novaTela.ShowDialog();
        }

        private void dDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();

            AlterarA novaTela = new AlterarA();
            novaTela.ShowDialog();
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Admin1 novaTela = new Admin1();
            novaTela.ShowDialog();
        }

        private void DadosA_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();

            AlterarA novaTela = new AlterarA();
            novaTela.ShowDialog();
        }
    }
}
