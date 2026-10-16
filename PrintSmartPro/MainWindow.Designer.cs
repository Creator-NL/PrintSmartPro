
namespace PrintSmartPro
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DgvItemsToPrint = new System.Windows.Forms.DataGridView();
            this.BtnImport = new System.Windows.Forms.Button();
            this.TxtDecode = new System.Windows.Forms.TextBox();
            this.TxtEncode = new System.Windows.Forms.TextBox();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnDecode = new System.Windows.Forms.Button();
            this.BtnEncode = new System.Windows.Forms.Button();
            this.BarcodeImage = new System.Windows.Forms.PictureBox();
            this.CbbSelectPrintType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbbBarcodeFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkStretchImage = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbbPrinter = new System.Windows.Forms.ComboBox();
            this.BtnPrinterSettings = new System.Windows.Forms.Button();
            this.LblSearchGv = new System.Windows.Forms.Label();
            this.TxbSearchGv = new System.Windows.Forms.TextBox();
            this.BtnSearchGv = new System.Windows.Forms.Button();
            this.BtnPrintSingleText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TTMainWindow = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItemsToPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvItemsToPrint
            // 
            this.DgvItemsToPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvItemsToPrint.BackgroundColor = System.Drawing.Color.White;
            this.DgvItemsToPrint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvItemsToPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItemsToPrint.Location = new System.Drawing.Point(20, 20);
            this.DgvItemsToPrint.Name = "DgvItemsToPrint";
            this.DgvItemsToPrint.Size = new System.Drawing.Size(252, 500);
            this.DgvItemsToPrint.TabIndex = 0;
            // 
            // BtnImport
            // 
            this.BtnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImport.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImport.ForeColor = System.Drawing.Color.White;
            this.BtnImport.Location = new System.Drawing.Point(296, 20);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(100, 30);
            this.BtnImport.TabIndex = 1;
            this.BtnImport.Text = "Import";
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // TxtDecode
            // 
            this.TxtDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDecode.Location = new System.Drawing.Point(296, 528);
            this.TxtDecode.Name = "TxtDecode";
            this.TxtDecode.Size = new System.Drawing.Size(320, 33);
            this.TxtDecode.TabIndex = 9;
            // 
            // TxtEncode
            // 
            this.TxtEncode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEncode.Location = new System.Drawing.Point(296, 406);
            this.TxtEncode.Name = "TxtEncode";
            this.TxtEncode.Size = new System.Drawing.Size(320, 33);
            this.TxtEncode.TabIndex = 7;
            this.TxtEncode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTMainWindow.SetToolTip(this.TxtEncode, "Text goes here !");
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Location = new System.Drawing.Point(296, 180);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(320, 35);
            this.BtnPrint.TabIndex = 12;
            this.BtnPrint.Text = "Print Document";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnDecode
            // 
            this.BtnDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDecode.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnDecode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDecode.ForeColor = System.Drawing.Color.White;
            this.BtnDecode.Location = new System.Drawing.Point(296, 494);
            this.BtnDecode.Name = "BtnDecode";
            this.BtnDecode.Size = new System.Drawing.Size(320, 28);
            this.BtnDecode.TabIndex = 11;
            this.BtnDecode.Text = "Decode";
            this.BtnDecode.UseVisualStyleBackColor = false;
            this.BtnDecode.Click += new System.EventHandler(this.BtnDecode_Click);
            // 
            // BtnEncode
            // 
            this.BtnEncode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEncode.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEncode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEncode.ForeColor = System.Drawing.Color.White;
            this.BtnEncode.Location = new System.Drawing.Point(296, 441);
            this.BtnEncode.Name = "BtnEncode";
            this.BtnEncode.Size = new System.Drawing.Size(150, 35);
            this.BtnEncode.TabIndex = 10;
            this.BtnEncode.Text = "Generate Barcode";
            this.BtnEncode.UseVisualStyleBackColor = false;
            this.BtnEncode.Click += new System.EventHandler(this.BtnEncode_Click);
            // 
            // BarcodeImage
            // 
            this.BarcodeImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BarcodeImage.BackColor = System.Drawing.Color.White;
            this.BarcodeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarcodeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarcodeImage.Location = new System.Drawing.Point(296, 265);
            this.BarcodeImage.Name = "BarcodeImage";
            this.BarcodeImage.Size = new System.Drawing.Size(320, 135);
            this.BarcodeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BarcodeImage.TabIndex = 13;
            this.BarcodeImage.TabStop = false;
            this.BarcodeImage.Click += new System.EventHandler(this.BarcodeImage_Click);
            // 
            // CbbSelectPrintType
            // 
            this.CbbSelectPrintType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbbSelectPrintType.FormattingEnabled = true;
            this.CbbSelectPrintType.Items.AddRange(new object[] {
            "A4 Barcode",
            "A4 Product Manipulation",
            "GK420d Big Label"});
            this.CbbSelectPrintType.Location = new System.Drawing.Point(416, 107);
            this.CbbSelectPrintType.Name = "CbbSelectPrintType";
            this.CbbSelectPrintType.Size = new System.Drawing.Size(200, 36);
            this.CbbSelectPrintType.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select Print Type:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Select Printer:";
            // 
            // CbbPrinter
            // 
            this.CbbPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbbPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbPrinter.FormattingEnabled = true;
            this.CbbPrinter.Location = new System.Drawing.Point(416, 142);
            this.CbbPrinter.Name = "CbbPrinter";
            this.CbbPrinter.Size = new System.Drawing.Size(160, 36);
            this.CbbPrinter.TabIndex = 26;
            // 
            // BtnPrinterSettings
            // 
            this.BtnPrinterSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrinterSettings.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnPrinterSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrinterSettings.ForeColor = System.Drawing.Color.White;
            this.BtnPrinterSettings.Location = new System.Drawing.Point(580, 140);
            this.BtnPrinterSettings.Name = "BtnPrinterSettings";
            this.BtnPrinterSettings.Size = new System.Drawing.Size(36, 30);
            this.BtnPrinterSettings.TabIndex = 27;
            this.BtnPrinterSettings.Text = "⚙️";
            this.BtnPrinterSettings.UseVisualStyleBackColor = false;
            this.BtnPrinterSettings.Click += new System.EventHandler(this.BtnPrinterSettings_Click);
            // 
            // CbbBarcodeFormat
            // 
            this.CbbBarcodeFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbbBarcodeFormat.FormattingEnabled = true;
            this.CbbBarcodeFormat.Items.AddRange(new object[] {
            "CODE_128",
            "CODE_39",
            "QR_CODE",
            "EAN_13",
            "UPC_A",
            "DATA_MATRIX"});
            this.CbbBarcodeFormat.Location = new System.Drawing.Point(435, 231);
            this.CbbBarcodeFormat.Name = "CbbBarcodeFormat";
            this.CbbBarcodeFormat.Size = new System.Drawing.Size(90, 25);
            this.CbbBarcodeFormat.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Format:";
            // 
            // ChkStretchImage
            // 
            this.ChkStretchImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkStretchImage.AutoSize = true;
            this.ChkStretchImage.Location = new System.Drawing.Point(540, 233);
            this.ChkStretchImage.Name = "ChkStretchImage";
            this.ChkStretchImage.Size = new System.Drawing.Size(80, 28);
            this.ChkStretchImage.TabIndex = 24;
            this.ChkStretchImage.Text = "Stretch";
            this.ChkStretchImage.UseVisualStyleBackColor = true;
            this.ChkStretchImage.CheckedChanged += new System.EventHandler(this.ChkStretchImage_CheckedChanged);
            // 
            // LblSearchGv
            // 
            this.LblSearchGv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSearchGv.AutoSize = true;
            this.LblSearchGv.Location = new System.Drawing.Point(296, 70);
            this.LblSearchGv.Name = "LblSearchGv";
            this.LblSearchGv.Size = new System.Drawing.Size(120, 28);
            this.LblSearchGv.TabIndex = 16;
            this.LblSearchGv.Text = "Search Data:";
            // 
            // TxbSearchGv
            // 
            this.TxbSearchGv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbSearchGv.Location = new System.Drawing.Point(386, 67);
            this.TxbSearchGv.Name = "TxbSearchGv";
            this.TxbSearchGv.Size = new System.Drawing.Size(120, 33);
            this.TxbSearchGv.TabIndex = 17;
            // 
            // BtnSearchGv
            // 
            this.BtnSearchGv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchGv.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSearchGv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchGv.ForeColor = System.Drawing.Color.White;
            this.BtnSearchGv.Location = new System.Drawing.Point(516, 65);
            this.BtnSearchGv.Name = "BtnSearchGv";
            this.BtnSearchGv.Size = new System.Drawing.Size(100, 30);
            this.BtnSearchGv.TabIndex = 18;
            this.BtnSearchGv.Text = "Search";
            this.BtnSearchGv.UseVisualStyleBackColor = false;
            this.BtnSearchGv.Click += new System.EventHandler(this.BtnSearchGv_Click);
            // 
            // BtnPrintSingleText
            // 
            this.BtnPrintSingleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrintSingleText.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnPrintSingleText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintSingleText.ForeColor = System.Drawing.Color.White;
            this.BtnPrintSingleText.Location = new System.Drawing.Point(466, 441);
            this.BtnPrintSingleText.Name = "BtnPrintSingleText";
            this.BtnPrintSingleText.Size = new System.Drawing.Size(150, 35);
            this.BtnPrintSingleText.TabIndex = 19;
            this.BtnPrintSingleText.Text = "Print Barcode";
            this.BtnPrintSingleText.UseVisualStyleBackColor = false;
            this.BtnPrintSingleText.Click += new System.EventHandler(this.BtnPrintSingleText_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Barcode:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(636, 28);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(0, 23);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(636, 610);
            this.Controls.Add(this.TxtEncode);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvItemsToPrint);
            this.Controls.Add(this.BtnPrintSingleText);
            this.Controls.Add(this.BtnSearchGv);
            this.Controls.Add(this.TxbSearchGv);
            this.Controls.Add(this.LblSearchGv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbbBarcodeFormat);
            this.Controls.Add(this.ChkStretchImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbbPrinter);
            this.Controls.Add(this.BtnPrinterSettings);
            this.Controls.Add(this.CbbSelectPrintType);
            this.Controls.Add(this.BarcodeImage);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnDecode);
            this.Controls.Add(this.BtnEncode);
            this.Controls.Add(this.TxtDecode);
            this.Controls.Add(this.BtnImport);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Smart Pro";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvItemsToPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvItemsToPrint;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.TextBox TxtDecode;
        private System.Windows.Forms.TextBox TxtEncode;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnDecode;
        private System.Windows.Forms.Button BtnEncode;
        private System.Windows.Forms.PictureBox BarcodeImage;
        private System.Windows.Forms.ComboBox CbbSelectPrintType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbbBarcodeFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkStretchImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbbPrinter;
        private System.Windows.Forms.Button BtnPrinterSettings;
        private System.Windows.Forms.Label LblSearchGv;
        private System.Windows.Forms.TextBox TxbSearchGv;
        private System.Windows.Forms.Button BtnSearchGv;
        private System.Windows.Forms.Button BtnPrintSingleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip TTMainWindow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}