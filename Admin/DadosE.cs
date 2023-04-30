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
    public partial class DadosE : Form
    {
        public DadosE()
        {
            InitializeComponent();
            dDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void bLocalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textMaterial.Text))
            {
                MessageBox.Show("Por favor, preencha o campo material");

            }
            else
            {
                MessageBox.Show("Localizado com sucesso");
                textMaterial.Text = "";
            }
        }
    }
}
