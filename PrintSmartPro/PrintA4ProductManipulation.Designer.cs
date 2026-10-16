
namespace PrintSmartPro
{
    partial class PrintA4ProductManipulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintA4ProductManipulation));
            this.TxtbPrintValue = new System.Windows.Forms.TextBox();
            this.BarcodeImage = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtbPrintValue
            // 
            this.TxtbPrintValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbPrintValue.Location = new System.Drawing.Point(266, 155);
            this.TxtbPrintValue.Name = "TxtbPrintValue";
            this.TxtbPrintValue.Size = new System.Drawing.Size(281, 44);
            this.TxtbPrintValue.TabIndex = 18;
            this.TxtbPrintValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BarcodeImage
            // 
            this.BarcodeImage.BackColor = System.Drawing.SystemColors.Window;
            this.BarcodeImage.Location = new System.Drawing.Point(266, 81);
            this.BarcodeImage.Name = "BarcodeImage";
            this.BarcodeImage.Size = new System.Drawing.Size(281, 73);
            this.BarcodeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BarcodeImage.TabIndex = 17;
            this.BarcodeImage.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(33, 205);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(755, 510);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // PrintA4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 727);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TxtbPrintValue);
            this.Controls.Add(this.BarcodeImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintA4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintA4";
            this.Load += new System.EventHandler(this.PrintA4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtbPrintValue;
        private System.Windows.Forms.PictureBox BarcodeImage;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}