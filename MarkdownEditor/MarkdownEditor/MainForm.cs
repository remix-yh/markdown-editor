using Markdig;
using PdfSharp.Pdf;
using System;
using System.IO;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace MarkdownEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timMarkdownPreview_Tick(object sender, EventArgs e)
        {
            string html = Markdown.ToHtml(txtMarkdown.Text);
            brsMarkdownPreview.DocumentText = html;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "markdown.pdf";
                saveFileDialog.Filter = "PDFファイル(*.pdf)|*.pdf|すべてのファイル(*.*)|*.*";
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    PdfDocument pdfDocument = new PdfDocument();
                    PdfDocument pdf = PdfGenerator.GeneratePdf(brsMarkdownPreview.DocumentText, PdfSharp.PageSize.A4);
                    pdf.Save(fs);
                }
            }
        }
    }
}
