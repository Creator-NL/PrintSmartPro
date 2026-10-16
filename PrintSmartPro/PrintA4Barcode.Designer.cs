
namespace PrintSmartPro
{
    partial class PrintA4Barcode
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
            this.TxtbPrintValue = new System.Windows.Forms.TextBox();
            this.BarcodeImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtbPrintValue
            // 
            this.TxtbPrintValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbPrintValue.Location = new System.Drawing.Point(253, 149);
            this.TxtbPrintValue.Name = "TxtbPrintValue";
            this.TxtbPrintValue.Size = new System.Drawing.Size(281, 44);
            this.TxtbPrintValue.TabIndex = 20;
            this.TxtbPrintValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BarcodeImage
            // 
            this.BarcodeImage.BackColor = System.Drawing.SystemColors.Window;
            this.BarcodeImage.Location = new System.Drawing.Point(253, 75);
            this.BarcodeImage.Name = "BarcodeImage";
            this.BarcodeImage.Size = new System.Drawing.Size(281, 73);
            this.BarcodeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BarcodeImage.TabIndex = 19;
            this.BarcodeImage.TabStop = false;
            // 
            // PrintA4Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 727);
            this.Controls.Add(this.TxtbPrintValue);
            this.Controls.Add(this.BarcodeImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintA4Barcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintA4Barcode";
            this.Load += new System.EventHandler(this.PrintA4Barcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtbPrintValue;
        private System.Windows.Forms.PictureBox BarcodeImage;
    }
}