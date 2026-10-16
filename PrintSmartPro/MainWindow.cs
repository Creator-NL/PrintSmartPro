using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace PrintSmartPro
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        List<string> HeaderNames = new List<string>();

        DataTable ImportedDataTable = new DataTable();
        DataColumn DataTableColumn;
        DataRow DataTableRow;
        DataView DataTableView;


        private void BtnImport_Click(object sender, EventArgs e)
        {

            ImportedDataTable = new DataTable();
            HeaderNames = new List<string>();


            GetClipboardDataToDataTable();

            //if (mmmTest == "NotOk")
            //{
            //    ImportedDataTable = new DataTable();
            //    HeaderNames = new List<string>();
            //    //WorkerNames = new List<string>();
            //    return;
            //}
            //SetGridViewHeaderStyle();
            //SetGridviewColumnWitdh();
            //SetGridviewRowColor();
            //MarkCountDifference();
            //ImportDataButton.Click -= ImportDataButton_Click;
        }



        private void GetClipboardDataToDataTable()
        {
            try
            {
                HeaderNames.Add("Print Data");
                DataTableColumn = new DataColumn
                {
                    DataType = System.Type.GetType("System.String"),
                    ColumnName = "Print Data"
                };
                ImportedDataTable.Columns.Add(DataTableColumn);

                HeaderNames.Add("Amount");
                DataTableColumn = new DataColumn
                {
                    DataType = System.Type.GetType("System.String"),
                    ColumnName = "Amount"
                };
                ImportedDataTable.Columns.Add(DataTableColumn);

                //HeaderNames.Add("Print Data");
                //DataTableColumn = new DataColumn();
                //DataTableColumn.DataType = System.Type.GetType("System.String");
                //DataTableColumn.ColumnName = "Print Data";
                //ImportedDataTable.Columns.Add(DataTableColumn);

                //HeaderNames.Add("Amount");
                //DataTableColumn = new DataColumn();
                //DataTableColumn.DataType = System.Type.GetType("System.String");
                //DataTableColumn.ColumnName = "Amount";
                //ImportedDataTable.Columns.Add(DataTableColumn);

                string CopiedContent = Clipboard.GetText();

                foreach (string row in CopiedContent.Split('\n'))
                {
                    string RowFix = row.Replace("\r", "");
                    string EmptyRowTest = row.Replace("\t", "");
                    EmptyRowTest = EmptyRowTest.Replace("\r", "");

                    if (!string.IsNullOrEmpty(EmptyRowTest))
                    {
                        string[] CopiedCells = row.Split('\t');
                        DataTableRow = ImportedDataTable.NewRow();
                        /*                        if (CopiedCells.Length.Equals(1)) */// fix row lenght ////////////////////////////////////////////////////////////////
                        if (CopiedCells.Length < 3)
                        {
                            for (int i = 0; i < CopiedCells.Length; i++)
                            {
                                string CleanCopiedCells = CopiedCells[i].Replace("\"", "");
                                DataTableRow[HeaderNames[i]] = CleanCopiedCells;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please check youre coppied information" + "\n" + "Max 2 Columns (pzn(etc..) and Amount to print)" + "\n" + "Or only a pzn or location etc");
                        }
                    ImportedDataTable.Rows.Add(DataTableRow);
                    }
                }
                DataTableView = new DataView(ImportedDataTable);
                //DataTableView.Sort = "Zähler Asc, Zählzeit Asc";
                DgvItemsToPrint.DataSource = DataTableView;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //if()
            //{

            //}
            //else
            //{

            //}

        }


        private void ChkStretchImage_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkStretchImage.Checked)
            {
                BarcodeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                BarcodeImage.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            BarcodeFormat format = BarcodeFormat.CODE_128;
            if (CbbBarcodeFormat.SelectedItem != null)
            {
                Enum.TryParse(CbbBarcodeFormat.SelectedItem.ToString(), out format);
            }

            BarcodeWriter BCWriter = new BarcodeWriter();
            BCWriter.Format = format;

            // If stretching, we pass 0 for width so ZXing generates a tightly cropped image horizontally.
            // We ALWAYS pass the exact height so the text doesn't get stretched vertically!
            int width = ChkStretchImage.Checked ? 0 : BarcodeImage.Width;
            int height = BarcodeImage.Height;

            BCWriter.Options = new ZXing.Common.EncodingOptions
            {
                Width = width,
                Height = height,
                Margin = 1
            };

            // Make the text bigger and bolder
            try
            {
                if (BCWriter.Renderer is ZXing.Rendering.BitmapRenderer bitmapRenderer)
                {
                    bitmapRenderer.TextFont = new Font("Segoe UI", 12, FontStyle.Bold);
                }
            }
            catch { /* Ignore if renderer casting fails */ }
            
            try
            {
                BarcodeImage.Image = BCWriter.Write(TxtEncode.Text);
                
                // Ensure the SizeMode matches the checkbox
                BarcodeImage.SizeMode = ChkStretchImage.Checked ? PictureBoxSizeMode.StretchImage : PictureBoxSizeMode.CenterImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating barcode: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            string selectedPrinter = CbbPrinter.SelectedItem?.ToString();
            DialogResult dr = MessageBox.Show($"You are about to print to:\n{selectedPrinter}\n\nAre you sure you want to proceed? (This could be hundreds of labels)", "Confirm Print", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (CbbSelectPrintType.Text.Equals("A4 Product Manipulation"))
                {
                    PrintA4ProductManipulation printA4ProductManipulation = new PrintA4ProductManipulation(ImportedDataTable, selectedPrinter);
                    printA4ProductManipulation.Show();
                }
                else if (CbbSelectPrintType.Text.Equals("A4 Barcode"))
                {
                    PrintA4Barcode printA4Barcode = new PrintA4Barcode(ImportedDataTable, selectedPrinter);
                    printA4Barcode.Show();
                }
                else if (CbbSelectPrintType.Text.Equals("GK420d Big Label"))
                {
                    PrintZebraLabelBigGK420D printZebraLabelBigGK420D = new PrintZebraLabelBigGK420D(ImportedDataTable, selectedPrinter);
                    printZebraLabelBigGK420D.Show();
                }
                else
                {
                    MessageBox.Show("Please select a print type");
                }
            }
            //PrintA4 printA4 = new PrintA4(ImportedDataTable);
            //printA4.Show();
            //System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
            //PrintDialog myPrinDialog1 = new PrintDialog();
            //myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
            //myPrinDialog1.Document = myPrintDocument1;
            //myPrintDocument1.Print();
            //if (myPrinDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    myPrintDocument1.Print();
            //}
        }

        private void BtnPrinterSettings_Click(object sender, EventArgs e)
        {
            string selectedPrinter = CbbPrinter.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedPrinter))
            {
                try
                {
                    System.Diagnostics.Process.Start("rundll32.exe", $"printui.dll,PrintUIEntry /e /n \"{selectedPrinter}\"");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not open printer preferences: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDecode_Click(object sender, EventArgs e)
        {
            BarcodeReader BCReader = new BarcodeReader() { };
            var result = BCReader.Decode((Bitmap)BarcodeImage.Image);

            if (result != null)
            {
                TxtDecode.Text = result.Text;
            }
        }

        private void BarcodeImage_Click(object sender, EventArgs e)
        {
            if (BarcodeImage.Image != null)
            {
                Clipboard.SetImage(BarcodeImage.Image);
                ToolStripStatusLabel.Text = "Barcode image copied to clipboard!";
            }
        }

        private void BtnSearchGv_Click(object sender, EventArgs e)
        {
            DgvItemsToPrint.ClearSelection();


            int rowIndex = -1;

            try
            {
                DataGridViewRow row = DgvItemsToPrint.Rows.Cast<DataGridViewRow>().First(r => r.Cells["Print Data"].Value.ToString().Equals(TxbSearchGv.Text));

                rowIndex = row.Index;

                DgvItemsToPrint.Rows[rowIndex].Selected = true;
                DgvItemsToPrint.FirstDisplayedScrollingRowIndex = DgvItemsToPrint.SelectedRows[0].Index;
                ToolStripStatusLabel.Text = string.Empty;

            }
            catch
            {
                ToolStripStatusLabel.Text = "Not found";
                //MessageBox.Show("Not found");
            }














        }




        DataTable DataTableFix = new DataTable();
        DataColumn DataTableFixDataTableColumn;
        DataRow DataTableFixDataTableRow;
        DataView DataTableFixDataTableView;



        private void BtnPrintSingleText_Click(object sender, EventArgs e)
        {
            DataTableFix = new DataTable();




            HeaderNames.Add("Print Data");
            DataTableFixDataTableColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Print Data"
            };
            DataTableFix.Columns.Add(DataTableFixDataTableColumn);

            HeaderNames.Add("Amount");
            DataTableFixDataTableColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Amount"
            };
            DataTableFix.Columns.Add(DataTableFixDataTableColumn);

            DataTableFixDataTableRow = DataTableFix.NewRow();
            DataTableFixDataTableRow[HeaderNames[0]] = TxtEncode.Text;
            DataTableFix.Rows.Add(DataTableFixDataTableRow);

            string selectedPrinter = CbbPrinter.SelectedItem?.ToString();
            PrintZebraLabelBigGK420D printZebraLabelBigGK420D = new PrintZebraLabelBigGK420D(DataTableFix, selectedPrinter);
            printZebraLabelBigGK420D.Show();


            //System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
            //PrintDialog myPrinDialog1 = new PrintDialog();
            //myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(MyPrintDocument2_PrintPage);
            //myPrinDialog1.Document = myPrintDocument1;

            //myPrintDocument1.Print();
            //PrintZebraLabelBigGK420D printZebraLabelBigGK420D = new PrintZebraLabelBigGK420D(ImportedDataTable);
            //printZebraLabelBigGK420D.Show();
        }
        //private void MyPrintDocument2_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    Bitmap myBitmap1 = new Bitmap(BarcodeImage.Width, BarcodeImage.Height);
        //    BarcodeImage.DrawToBitmap(myBitmap1, new Rectangle(0, 0, BarcodeImage.Width + TxtEncode.Width, BarcodeImage.Height + TxtEncode.Height));
        //    e.Graphics.DrawImage(myBitmap1, 0, 0);
        //    myBitmap1.Dispose();
        //}








        private void MainWindow_Load(object sender, EventArgs e)
        {

            this.TTMainWindow.SetToolTip(this.BtnImport, "Import excel data for mass printing.\nOnly one copy will be printed if no amount is provided.");
            this.TTMainWindow.SetToolTip(this.BtnSearchGv, "Search for a item in the gridview.\nResult will be marked");
            
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                CbbPrinter.Items.Add(printer);
            }
            PrinterSettings printsettings = new PrinterSettings();
            CbbPrinter.SelectedItem = printsettings.PrinterName;

            CbbBarcodeFormat.SelectedIndex = 0; // Default to CODE_128

        }


    }
}