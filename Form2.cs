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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            top();
        }
        int x = 100, y = 100;
        Graphics graphics;
       


        public string hari { get; set; }

        Font font1 = new Font("Times New Roman", 11, FontStyle.Bold);
        void sam_Printpage(Object sender, PrintPageEventArgs e)
        {
            graphics = e.Graphics;
            Font headerFont = new Font("Bernard MT Condensed", 15, FontStyle.Regular);


            Font bodyFont = new Font("Times New Roman", 10, FontStyle.Bold);
            graphics.DrawString("Page No.:_______ ", headerFont, Brushes.IndianRed, x + 550, 40);
            graphics.DrawString("Date: __/__/_____", headerFont, Brushes.IndianRed, x + 550, 70);


            graphics.DrawLine(Pens.Red, 1, 120, 875, 120);//horizontal
            graphics.DrawLine(Pens.Red, 1, 125, 875, 125);//horizontal
            graphics.DrawLine(Pens.Red, 120, 1, 120, 1300);//vertical
            graphics.DrawLine(Pens.Red, 125, 1, 125, 1300);//vertical
            graphics.DrawRectangle(Pens.IndianRed, x + 535, 35, 650, 75);

            graphics.DrawLine(Pens.DarkBlue, 1, 175, 875, 175);
            graphics.DrawLine(Pens.DarkBlue, 1, 225, 875, 225);
            graphics.DrawLine(Pens.DarkBlue, 1, 275, 875, 275);
            graphics.DrawLine(Pens.DarkBlue, 1, 325, 875, 325);
            graphics.DrawLine(Pens.DarkBlue, 1, 375, 875, 375);
            graphics.DrawLine(Pens.DarkBlue, 1, 425, 875, 425);
            graphics.DrawLine(Pens.DarkBlue, 1, 475, 875, 475);
            graphics.DrawLine(Pens.DarkBlue, 1, 525, 875, 525);
            graphics.DrawLine(Pens.DarkBlue, 1, 575, 875, 575);
            graphics.DrawLine(Pens.DarkBlue, 1, 625, 875, 625);
            graphics.DrawLine(Pens.DarkBlue, 1, 675, 875, 675);
            graphics.DrawLine(Pens.DarkBlue, 1, 725, 875, 725);
            graphics.DrawLine(Pens.DarkBlue, 1, 775, 875, 775);
            graphics.DrawLine(Pens.DarkBlue, 1, 825, 875, 825);
            graphics.DrawLine(Pens.DarkBlue, 1, 875, 875, 875);
            graphics.DrawLine(Pens.DarkBlue, 1, 925, 875, 925);
            graphics.DrawLine(Pens.DarkBlue, 1, 975, 875, 975);
            graphics.DrawLine(Pens.DarkBlue, 1, 1025, 875, 1025);
            graphics.DrawLine(Pens.DarkBlue, 1, 1075, 875, 1075);
            graphics.DrawLine(Pens.DarkBlue, 1, 1125, 875, 1125);
            graphics.DrawLine(Pens.DarkBlue, 1, 1175, 875, 1175);







        }

        public void top()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
            printDocument.PrintPage += new PrintPageEventHandler(sam_Printpage);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

        }
    }
}
