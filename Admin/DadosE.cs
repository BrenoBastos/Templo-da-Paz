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
            // Define o modo de seleção do DataGridView como seleção de linha completa

            dDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void bLocalizar_Click(object sender, EventArgs e)
        { // Verifica se o campo de material está vazio

            if (string.IsNullOrWhiteSpace(textMaterial.Text))
            {  // Mostra uma mensagem de erro e interrompe o processamento da função
                MessageBox.Show("Por favor, preencha o campo material");

            }
            else // Mostra uma mensagem de sucesso e limpa o campo de material
            {
                MessageBox.Show("Localizado com sucesso");
                textMaterial.Text = "";
            }
        }

        private void bVoltar_Click(object sender, EventArgs e)
        {   // Oculta a tela atual
            this.Hide();
            // Cria uma nova instância da classe Admin1
            Admin1 novaTela = new Admin1();
            // Mostra a nova instância da janela Admin1
            novaTela.ShowDialog();
        }
    }
}
