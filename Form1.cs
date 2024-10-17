using System;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace AppReutilizacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento para abrir y reproducir un archivo de video/audio en Windows Media Player desde archivo local
        private void btnAbrirMedia_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Media Files|*.mp4;*.mp3;*.wav";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mediaPlayer.URL = ofd.FileName;
                mediaPlayer.Ctlcontrols.play();
            }
        }

        // Evento para abrir y reproducir un archivo de video/audio desde una URL ingresada en el TextBox
        private void btnReproducirURL_Click(object sender, EventArgs e)
        {
            string videoUrl = textBoxURL.Text; // Obtener la URL ingresada por el usuario en el TextBox
            if (!string.IsNullOrWhiteSpace(videoUrl))
            {
                mediaPlayer.URL = videoUrl;
                mediaPlayer.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una URL válida.");
            }
        }

        // Evento para abrir y leer un archivo PDF
        private void btnAbrirPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files|*.pdf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LeerPDF(ofd.FileName);
            }
        }

        // Método para leer un archivo PDF y mostrarlo en un TextBox
        private void LeerPDF(string filePath)
        {
            textBoxPDF.Clear();  // Limpiar el TextBox antes de leer el PDF

            using (PdfReader reader = new PdfReader(filePath))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    string pageText = PdfTextExtractor.GetTextFromPage(reader, i);
                    textBoxPDF.Text += pageText + Environment.NewLine; // Agregar el contenido al TextBox
                }
            }
        }

        // Evento para navegar a una página web en el WebBrowser
        private void btnNavegarWeb_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.google.com");
        }
    }
}
