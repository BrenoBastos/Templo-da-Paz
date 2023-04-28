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
    public partial class AtualizarCadaverL : Form
    {
        public AtualizarCadaverL()
        {
            InitializeComponent();

            comboBoxiniciar();
        }
        private void comboBoxiniciar()
        {
            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Items.Add("Espera");
                comboBox2.Items.Add("IML");
                comboBox2.Items.Add("Funerária");
                comboBox2.SelectedIndex = 0;
                comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
