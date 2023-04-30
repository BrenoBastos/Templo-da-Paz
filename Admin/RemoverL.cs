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
    public partial class RemoverL : Form
    {
        public RemoverL()
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
    }
}
