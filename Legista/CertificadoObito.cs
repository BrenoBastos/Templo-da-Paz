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
        }

        private void button1_Click(object sender, EventArgs e)
{
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o arquivo PDF: " + ex.Message);
            }
        }
    }
}
