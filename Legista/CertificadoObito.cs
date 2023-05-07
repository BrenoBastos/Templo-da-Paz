using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Printing;
using System.Reflection.Metadata;
using Document = iTextSharp.text.Document;

namespace WindowsFormsApp1
{
    public partial class CertificadoObito : Form
    {
        public CertificadoObito()
        {
            InitializeComponent();
            // Chama os métodos para inicializar os ComboBox

            comboBoxiniciar2();
            comboBoxiniciar3();

    }

        // Método para inicializar o ComboBox da cor
        private void comboBoxiniciar2()
        {
            // Verifica se o ComboBox não tem nenhum item
            if (comboCor.Items.Count == 0)
            {
                // Adiciona os itens e seleciona o primeiro item
                comboCor.Items.Add("Branco");
                comboCor.Items.Add("Preto");
                comboCor.Items.Add("Pardo");
                comboCor.Items.Add("Amarelo");
                comboCor.Items.Add("Indígena");
                comboCor.SelectedIndex = 0;
                // Define o estilo de dropdown como DropDownList, para impedir a inserção de itens
                comboCor.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        // Método para inicializar o ComboBox do sexo
        private void comboBoxiniciar3()
        {
            // Verifica se o ComboBox não tem nenhum item
            if (cSexo.Items.Count == 0)
            {
                // Adiciona os itens e seleciona o primeiro item
                cSexo.Items.Add("Masculino");
                cSexo.Items.Add("Feminino");
                cSexo.Items.Add("Outro");
                cSexo.SelectedIndex = 0;
                // Define o estilo de dropdown como DropDownList, para impedir a inserção de itens
                cSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            // Verifica se algum campo obrigatório está vazio ou incompleto
            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted || string.IsNullOrWhiteSpace(textMatricula.Text) || string.IsNullOrWhiteSpace(textMês.Text) || string.IsNullOrWhiteSpace(textAno.Text) || string.IsNullOrWhiteSpace(textDia.Text) || string.IsNullOrWhiteSpace(textAverbacoes.Text) || string.IsNullOrWhiteSpace(textAnotacoes.Text) || string.IsNullOrWhiteSpace(textNaturalidade.Text) || string.IsNullOrWhiteSpace(textLocal.Text) || !textDocumentoIdentificação.MaskCompleted
                || string.IsNullOrWhiteSpace(textCausadaMorte.Text) || string.IsNullOrWhiteSpace(textEstadoCivil.Text) || string.IsNullOrWhiteSpace(textFiliação.Text) || !mEleitor.MaskCompleted || string.IsNullOrWhiteSpace(textDeclarante.Text) || !mDataFalecimento.MaskCompleted ||
                string.IsNullOrWhiteSpace(textSepultamento.Text) || string.IsNullOrWhiteSpace(textAnotacoes.Text) || string.IsNullOrWhiteSpace(textNomeMedico.Text))
            {
                // Mostra uma mensagem de erro e retorna
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // Verifica se o valor no campo 'Dia' é válido
            int dia;
            if (!int.TryParse(textDia.Text, out dia) || dia < 1 || dia > 31)
            {
                MessageBox.Show("O campo 'Dia' deve estar entre 1 e 31.");
                return;
            }

            // Verifica se o valor no campo 'Mês' é válido
            int mes;
            if (!int.TryParse(textMês.Text, out mes) || mes < 1 || mes > 12)
            {
                MessageBox.Show("O campo 'Mês' deve estar entre 1 e 12.");
                return;
            }

            // Verifica se o valor no campo 'Ano' é válido
            int ano;
            if (!int.TryParse(textAno.Text, out ano) || ano != DateTime.Now.Year)
            {
                MessageBox.Show("O campo 'Ano' deve estar no ano atual.");
                return;
            }

            // Verifica se o campo 'Nome' contém apenas caracteres alfabéticos
            if (textNome.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Nome'.");
                return;
            }

            // Verifica se o campo 'Naturalidade' contém apenas caracteres alfabéticos
            if (textNaturalidade.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres no campo 'Naturalidade'.");
                return;
            }

            // Verifica se o campo 'Matrícula' contém apenas caracteres numéricos
            if (!textMatricula.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Matrícula'.");
                return;
            }

            // Verifica se o campo 'Dia' contém apenas caracteres numéricos
            if (!textDia.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Dia'.");
                return;
            }

            // Verifica se o campo 'Mês' contém apenas caracteres numéricos
            if (!textMês.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas caracteres numéricos no campo 'Mês'.");
                return;
            }

            // Verifica se o campo 'Ano' contém apenas caracteres numéricos
            else if (!textAno.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas caracteres numéricos  no campo 'Ano'.");
                    return;
                }
           
      
          
                // Cria um novo documento PDF
                Document doc = new Document(PageSize.A4);

                    try
                    {
                        // Cria um objeto PdfWriter para escrever no documento
                        MemoryStream memoryStream = new MemoryStream();
                        PdfWriter.GetInstance(doc, memoryStream);

                        // Abre o documento
                        doc.Open();

                        // Converte a tela do formulário em um bitmap
                        Bitmap bitmap = new Bitmap(this.Width, this.Height);
                        this.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));

                        // Cria um objeto Image do bitmap
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(bitmap, System.Drawing.Imaging.ImageFormat.Bmp);

                        // Adiciona a imagem ao documento
                        doc.Add(img);

                        // Fecha o documento
                        doc.Close();

                        // Salva o PDF no MemoryStream
                        byte[] pdfBytes = memoryStream.ToArray();

                        // Abre uma janela SaveFileDialog para permitir ao usuário escolher onde salvar o arquivo PDF
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                        saveFileDialog.FilterIndex = 0;
                        saveFileDialog.DefaultExt = "pdf";
                        saveFileDialog.AddExtension = true;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Escreve o conteúdo do MemoryStream no arquivo PDF selecionado pelo usuário
                            File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);
                        }
                        // retorna que pdf foi gerado com sucesso ,limpa os campos e retorna o combobox ao padrão
                        MessageBox.Show("PDF gerado com sucesso!");
                comboCor.SelectedIndex = 0;
                cSexo.SelectedIndex = 0;
                textNome.Text = "";
                        textNaturalidade.Text = "";
                        textLocal.Text = "";
                        textCausadaMorte.Text = "";
                        textEstadoCivil.Text = "";
                        textFiliação.Text = "";
                        textDeclarante.Text = "";
                        textSepultamento.Text = "";
                        textAnotacoes.Text = "";
                        textNomeMedico.Text = "";
                        textCpf.Text = "";
                        textDocumentoIdentificação.Text = "";
                        mEleitor.Text = "";
                    textAno.Text = "";
                        mDataFalecimento.Text = "";
                        mDataFalecimento.Text = "";
                    textAverbacoes.Text = "";
                    textDia.Text = "";
                    textMatricula.Text = "";
                    textMês.Text = "";
                  

                }
            //se houve erro ao gerar o pdf
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar o arquivo PDF: " + ex.Message);
                    }


                }





               
                             

                
            


        

        private void bVoltar_Click(object sender, EventArgs e)
        {// Esconde a janela atual
            this.Hide();
            // Cria uma nova instância da classe      Legista 

            Legista novaTela = new Legista();
            // Mostra a nova instância da janela    Legista
            novaTela.ShowDialog();
        }

       

        private void mDataFalecimento_Click(object sender, EventArgs e)
        
            {// Define o início da seleção para 0
                mDataFalecimento.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mDataFalecimento.SelectionLength = 0;
        }

        private void mDataNascimento_Click(object sender, EventArgs e)
        {// Define o início da seleção para 0
            mDataFalecimento.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mDataFalecimento.SelectionLength = 0;
        }

     

        private void mEleitor_Click(object sender, EventArgs e)
        { // Define o início da seleção para 0
            mEleitor.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            mEleitor.SelectionLength = 0;
        }

        private void textCpf_Click(object sender, EventArgs e)
        {  // Define o início da seleção para 0
            textCpf.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            textCpf.SelectionLength = 0;
        }

        private void textRG_Click(object sender, EventArgs e)
        {
            // Define o início da seleção para 0
            textDocumentoIdentificação.SelectionStart = 0;
            // Define o comprimento da seleção para 0
            textDocumentoIdentificação.SelectionLength = 0;
        }
    }
}
