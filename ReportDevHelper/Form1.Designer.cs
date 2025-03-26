namespace ReportDevHelper
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
            button1 = new Button();
            txtExcelPath = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(713, 73);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 0;
            button1.Text = "Fill Html";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtExcelPath
            // 
            txtExcelPath.Location = new Point(41, 28);
            txtExcelPath.Name = "txtExcelPath";
            txtExcelPath.Size = new Size(768, 27);
            txtExcelPath.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 570);
            Controls.Add(txtExcelPath);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtExcelPath;
    }
}
