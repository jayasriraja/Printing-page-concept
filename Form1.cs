using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace pageconcept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Font font1 = new Font("Times New Roman", 9);    // Default Text
        Font font2 = new Font("Times New Roman", 10);    // BillNo, Date & Customer Id & coloum name
        Font font3 = new Font("Times New Roman", 10, FontStyle.Bold);  // Company Name, Bill Heading [Ex: ESTIMATE]
        Font font4 = new Font("Times New Roman", 9);    // Header, Footer
        Font font5 = new Font("Times New Roman", 10);
        Font font6 = new Font("Times New Roman", 14, FontStyle.Bold);
        // int X, Y, pageWidth, offsetY, rightMargin;
        SolidBrush brush = new SolidBrush(Color.Black);
        Pen dashPen = new Pen(Color.Black, 1);
        Graphics g; Int32 pageHeight;

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {
            PrintDialog prdialog = new PrintDialog();
            PrintDocument prdoc = new PrintDocument();
            PrinterSettings prsetting = new PrinterSettings();
            prdialog.Document = prdoc;
            IEnumerable<PaperSize> paperSizes = prsetting.PaperSizes.Cast<PaperSize>();

            PaperSize paperSize = new PaperSize("Custom", 488, pageHeight); // 413,583
            prdialog.Document.DefaultPageSettings.PaperSize = paperSize;
        }
    }
}
