
namespace PrintSmartPro
{
    partial class PrintZebraLabelBigGK420D
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
            this.BarcodeImage = new System.Windows.Forms.PictureBox();
            this.TxtbPrintValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BarcodeImage
            // 
            this.BarcodeImage.BackColor = System.Drawing.SystemColors.Window;
            this.BarcodeImage.Location = new System.Drawing.Point(0, 0);
            this.BarcodeImage.Name = "BarcodeImage";
            this.BarcodeImage.Size = new System.Drawing.Size(281, 73);
            this.BarcodeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BarcodeImage.TabIndex = 14;
            this.BarcodeImage.TabStop = false;
            // 
            // TxtbPrintValue
            // 
            this.TxtbPrintValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbPrintValue.Location = new System.Drawing.Point(0, 74);
            this.TxtbPrintValue.Name = "TxtbPrintValue";
            this.TxtbPrintValue.Size = new System.Drawing.Size(281, 44);
            this.TxtbPrintValue.TabIndex = 16;
            this.TxtbPrintValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PrintZebraLabelBigGK420D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 113);
            this.Controls.Add(this.TxtbPrintValue);
            this.Controls.Add(this.BarcodeImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintZebraLabelBigGK420D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintZebraLabelBigGK420D";
            this.Load += new System.EventHandler(this.PrintZebraLabelBigGK420D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BarcodeImage;
        private System.Windows.Forms.TextBox TxtbPrintValue;
    }
}