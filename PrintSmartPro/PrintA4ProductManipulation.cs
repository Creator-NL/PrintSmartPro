using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace PrintSmartPro
{
    public partial class PrintA4ProductManipulation : Form
    {
        readonly DataTable SendTableToPrint = new DataTable();
        public string TargetPrinterName { get; set; }

        public PrintA4ProductManipulation(DataTable TableToPrint, string printerName = null)
        {
            InitializeComponent();
            SendTableToPrint = TableToPrint;
            TargetPrinterName = printerName;
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }


        readonly BarcodeWriter BCWriter = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
        private void PrintA4_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in SendTableToPrint.Rows)
            {
                TxtbPrintValue.Text = row.Field<string>("Print Data").Replace("\r", "");
                int PrintCount = Convert.ToInt32(row.Field<string>("Amount"));
                BarcodeImage.Image = BCWriter.Write(TxtbPrintValue.Text);
                System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
                if (!string.IsNullOrEmpty(TargetPrinterName))
                {
                    myPrintDocument1.PrinterSettings.PrinterName = TargetPrinterName;
                }
                PrintDialog myPrinDialog1 = new PrintDialog();
                myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(MyPrintDocument1_PrintPage);
                myPrinDialog1.Document = myPrintDocument1;

                if(PrintCount > 1)
                {
                    for (int i = 0; i < PrintCount; i++)
                    {
                        myPrintDocument1.Print();
                    }
                }
                else
                {
                    myPrintDocument1.Print();
                }


            }
            this.Close();
        }

        private void MyPrintDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap myBitmap2 = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(myBitmap2, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(myBitmap2, 0, 0);
            myBitmap2.Dispose();
        }
    }
}
