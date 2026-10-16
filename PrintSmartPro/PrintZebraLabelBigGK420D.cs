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
    public partial class PrintZebraLabelBigGK420D : Form
    {

        readonly DataTable SendTableToPrint = new DataTable();
        public string TargetPrinterName { get; set; }
        public PrintZebraLabelBigGK420D(DataTable TableToPrint, string printerName = null)
        {
            InitializeComponent();
            SendTableToPrint = TableToPrint;
            TargetPrinterName = printerName;
        }

        readonly BarcodeWriter BCWriter = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };

        private void PrintZebraLabelBigGK420D_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in SendTableToPrint.Rows)
            {
                //if(TxtbPrintValue.Text.Length > 0)
                //{
                    TxtbPrintValue.Text = row.Field<string>("Print Data").Replace("\r", "");
                    BarcodeImage.Image = BCWriter.Write(TxtbPrintValue.Text);

                    System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
                    if (!string.IsNullOrEmpty(TargetPrinterName))
                    {
                        myPrintDocument1.PrinterSettings.PrinterName = TargetPrinterName;
                    }
                    PrintDialog myPrinDialog1 = new PrintDialog();
                    myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(MyPrintDocument1_PrintPage);
                    myPrinDialog1.Document = myPrintDocument1;

                    myPrintDocument1.Print();
                //}
                //else
                //{
                //    MessageBox.Show("No data !");
                //}


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
