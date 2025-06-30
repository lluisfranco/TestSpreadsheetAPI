namespace TestSpreadsheetAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            SuspendLayout();
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(20, 16);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(151, 44);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "simpleButton1";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new Point(188, 16);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(151, 44);
            simpleButton2.TabIndex = 1;
            simpleButton2.Text = "simpleButton2";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton3
            // 
            simpleButton3.Location = new Point(345, 16);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(151, 44);
            simpleButton3.TabIndex = 2;
            simpleButton3.Text = "simpleButton3";
            simpleButton3.Click += simpleButton3_Click;
            // 
            // spreadsheetControl1
            // 
            spreadsheetControl1.Location = new Point(26, 90);
            spreadsheetControl1.Name = "spreadsheetControl1";
            spreadsheetControl1.Size = new Size(746, 348);
            spreadsheetControl1.TabIndex = 3;
            spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(spreadsheetControl1);
            Controls.Add(simpleButton3);
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
    }
}
