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
            comboBoxiniciar1();
            comboBoxiniciar2();
            comboBoxiniciar3();
        }
        private void comboBoxiniciar1()
        {
            if (cEstadoCivil.Items.Count == 0)
            {
                cEstadoCivil.Items.Add("Solteiro(a)");
                cEstadoCivil.Items.Add("Casado(a)");
                cEstadoCivil.Items.Add("União Estável");
                cEstadoCivil.Items.Add("Viúvo(a)");

                cEstadoCivil.SelectedIndex = 0;
                cEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
        private void comboBoxiniciar2()
        {
            if (comboCor.Items.Count == 0)
            {
                comboCor.Items.Add("Branco");
                comboCor.Items.Add("Preto");
                comboCor.Items.Add("Pardo");
                comboCor.Items.Add("Amarelo");
                comboCor.Items.Add("Indígena");
                comboCor.SelectedIndex = 0;
                comboCor.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
        private void comboBoxiniciar3()
        {
            if (cSexo.Items.Count == 0)
            {
                
                    cSexo.Items.Add("Masculino");
                    cSexo.Items.Add("Feminino");
                    cSexo.Items.Add("Outro");
                cSexo.SelectedIndex = 0;
                cSexo.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
       
        private void button1_Click(object sender, EventArgs e)
{
            if (string.IsNullOrWhiteSpace(textNome.Text) || !textCpf.MaskCompleted || string.IsNullOrWhiteSpace(textNaturalidade.Text) || string.IsNullOrWhiteSpace(textLocal.Text) || !textRG.MaskCompleted
                 || string.IsNullOrWhiteSpace(textCausadaMorte.Text) || string.IsNullOrWhiteSpace(textIdade.Text) || string.IsNullOrWhiteSpace(textFiliação.Text) || !mEleitor.MaskCompleted || !mHora.MaskCompleted || string.IsNullOrWhiteSpace(textDeclarante.Text) || !mDataFalecimento.MaskCompleted || !mDataNascimento.MaskCompleted||
                 string.IsNullOrWhiteSpace(textSepultamento.Text)||string.IsNullOrWhiteSpace(textAnotacoes.Text)|| string.IsNullOrWhiteSpace(textNomeMedico.Text)|| !mCRM.MaskCompleted)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
         
               
                else
                {
                if (textNome.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas caracteres  no campo 'Nome'.");
                    return;
                }
               else if (textNaturalidade.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Por favor, insira apenas caracteres  no campo 'Naturalidade'.");
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
                        MessageBox.Show("PDF gerado com sucesso!");
                        textNome.Text = "";
                        textNaturalidade.Text = "";
                        textLocal.Text = "";
                        textCausadaMorte.Text = "";
                        textIdade.Text = "";
                        textFiliação.Text = "";
                        textDeclarante.Text = "";
                        textSepultamento.Text = "";
                        textAnotacoes.Text = "";
                        textNomeMedico.Text = "";
                        textCpf.Text = "";
                        textRG.Text = "";
                        mEleitor.Text = "";
                        mCRM.Text = "";
                        mDataFalecimento.Text = "";
                        mDataNascimento.Text = "";
                        mHora.Text = "";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar o arquivo PDF: " + ex.Message);
                    }


                }





               
                             

                
            }


        

        private void bVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Legista novaTela = new Legista();
            novaTela.ShowDialog();
        }

        private void mCRM_Click(object sender, EventArgs e)
        {

            mCRM.SelectionStart = 0;
            mCRM.SelectionLength = 0;
        }

        private void mDataFalecimento_Click(object sender, EventArgs e)
        {
            mDataFalecimento.SelectionStart = 0;
            mDataFalecimento.SelectionLength = 0;
        }

        private void mDataNascimento_Click(object sender, EventArgs e)
        {
            mDataNascimento.SelectionStart = 0;
            mDataNascimento.SelectionLength = 0;
        }

        private void mHora_Click(object sender, EventArgs e)
        {
            mHora.SelectionStart = 0;
            mHora.SelectionLength = 0;
        }

        private void mEleitor_Click(object sender, EventArgs e)
        {
            mEleitor.SelectionStart = 0;
            mEleitor.SelectionLength = 0;
        }

        private void textCpf_Click(object sender, EventArgs e)
        {
            textCpf.SelectionStart = 0;
            textCpf.SelectionLength = 0;
        }

        private void textRG_Click(object sender, EventArgs e)
        {

            textRG.SelectionStart = 0;
            textRG.SelectionLength = 0;
        }
    }
}
