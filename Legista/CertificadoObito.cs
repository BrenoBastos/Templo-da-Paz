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



using Paragraph = iTextSharp.text.Paragraph;
using Font = iTextSharp.text.Font;

using Document = iTextSharp.text.Document;

namespace WindowsFormsApp1
{
    public partial class CertificadoObito : Form
    {
        public CertificadoObito()
        {
            InitializeComponent();

            // Chama os métodos para inicializar os ComboBox
            CenterToScreen();
            comboBoxiniciar2();
            comboBoxiniciar3();
            BackColor = Color.FromArgb(0x5A, 0x48, 0x48);
            bBaixar.FlatAppearance.MouseOverBackColor = bBaixar.BackColor;
            bBaixar.FlatAppearance.BorderSize = 0;

            bBaixar.FlatAppearance.MouseDownBackColor = bBaixar.BackColor;
            bVoltar.FlatAppearance.MouseOverBackColor = bVoltar.BackColor;
            bVoltar.FlatAppearance.MouseDownBackColor = bVoltar.BackColor;

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
            // Cria um novo documento PDF
            Document doc = new Document(iTextSharp.text.PageSize.A4);

            try
            {
                // Cria um objeto PdfWriter para escrever no documento
                MemoryStream memoryStream = new MemoryStream();
                PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);

                // Abre o documento
                doc.Open();

                // Cria o objeto PdfContentByte a partir do writer
                PdfContentByte contentByte = writer.DirectContent;

                // Define a fonte e o tamanho do título
                Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);

                // Define a posição e o conteúdo do título
                ColumnText.ShowTextAligned(contentByte, Element.ALIGN_CENTER, new Phrase("Certidão de Óbito", titleFont),
                    doc.PageSize.Width / 2, doc.PageSize.Height - 50, 0);

                // Define a fonte e o tamanho do texto principal
                Font mainFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                // Define a largura dos parágrafos
                float columnWidth = doc.PageSize.Width / 2;

                // Define a posição e o conteúdo das informações pessoais
                ColumnText.ShowTextAligned(contentByte, Element.ALIGN_LEFT, new Phrase("CPF: " + textCpf.Text, mainFont),
                    36, doc.PageSize.Height - 108, 0);

                ColumnText.ShowTextAligned(contentByte, Element.ALIGN_LEFT, new Phrase("Nome: " + textNome.Text, mainFont),
                    36, doc.PageSize.Height - 126, 0);

                // Define a posição e o conteúdo das informações de falecimento
                ColumnText.ShowTextAligned(contentByte, Element.ALIGN_LEFT, new Phrase("Data de Falecimento: " + mDataFalecimento.Text, mainFont),
                    36, doc.PageSize.Height - 162, 0);

                ColumnText.ShowTextAligned(contentByte, Element.ALIGN_LEFT, new Phrase("Dia: " + textDia.Text, mainFont),
                    36, doc.PageSize.Height - 180, 0);

                ColumnText.ShowTextAligned(contentByte, Element.ALIGN_LEFT, new Phrase("Mês: " + textMês.Text, mainFont),
                    36, doc.PageSize.Height - 198, 0);

                ColumnText.ShowTextAligned(contentByte, Element.ALIGN_LEFT, new Phrase("Ano: " + textAno.Text, mainFont),
                    36, doc.PageSize.Height - 216, 0);

                // Define a posição e o conteúdo das informações adicionais
                ColumnText.ShowTextAligned(contentByte, Element.ALIGN_LEFT, new Phrase("Sepultamento: " + textSepultamento.Text, mainFont),
                    36, doc.PageSize.Height - 252, 0);

                ColumnText.ShowTextAligned(contentByte, Element.ALIGN_LEFT, new Phrase("Declarante: " + textDeclarante.Text, mainFont),
                    36, doc.PageSize.Height - 270, 0);

                ColumnText.ShowTextAligned(contentByte, Element.ALIGN_LEFT, new Phrase("Nome do Médico: " + textNomeMedico.Text, mainFont),
                    36, doc.PageSize.Height - 288, 0);

                // Define a posição e o conteúdo das informações adicionais
                ColumnText.ShowTextAligned(contentByte, Element.ALIGN_LEFT, new Phrase("Anotações: " + textAverbacoes.Text, mainFont),
                    36, doc.PageSize.Height - 324, 0);

                ColumnText.ShowTextAligned(contentByte, Element.ALIGN_LEFT, new Phrase("Anotações de Cadastro: " + textAnotacoes.Text, mainFont),
                    36, doc.PageSize.Height - 342, 0);

                // Define a posição da assinatura
                ColumnText.ShowTextAligned(contentByte, Element.ALIGN_LEFT, new Phrase("Assinatura______________________", mainFont),
                    36, doc.PageSize.Height - 400, 0);

                // Fecha o documento
                doc.Close();

                // Salva o PDF no MemoryStream
                byte[] pdfBytes = memoryStream.ToArray();

                // Abre uma janela SaveFileDialog para permitir ao usuário escolher onde salvar o arquivo PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (.pdf)|.pdf";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Escreve o conteúdo do MemoryStream no arquivo PDF selecionado pelo usuário
                    File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);
                }

                // Retorna que o PDF foi gerado com sucesso, limpa os campos e retorna o ComboBox ao padrão
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
            // Se ocorrer um erro ao gerar o PDF
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

        private void cSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CertificadoObito_Load(object sender, EventArgs e)
        {

        }

        private void comboCor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textNaturalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textSepultamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
