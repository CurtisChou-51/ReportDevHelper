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
            btnFillHtml = new Button();
            txtExcelPath = new TextBox();
            tabControl1 = new TabControl();
            tabFillHtml = new TabPage();
            tabCreateTd = new TabPage();
            txtResultHtml = new TextBox();
            txtColsExpr = new TextBox();
            btnCreateTd = new Button();
            txtTmplExcelPath = new TextBox();
            tabControl1.SuspendLayout();
            tabFillHtml.SuspendLayout();
            tabCreateTd.SuspendLayout();
            SuspendLayout();
            // 
            // btnFillHtml
            // 
            btnFillHtml.Location = new Point(708, 78);
            btnFillHtml.Margin = new Padding(4);
            btnFillHtml.Name = "btnFillHtml";
            btnFillHtml.Size = new Size(96, 29);
            btnFillHtml.TabIndex = 0;
            btnFillHtml.Text = "Fill Html";
            btnFillHtml.UseVisualStyleBackColor = true;
            btnFillHtml.Click += btnFillHtml_Click;
            // 
            // txtExcelPath
            // 
            txtExcelPath.Location = new Point(36, 25);
            txtExcelPath.Name = "txtExcelPath";
            txtExcelPath.Size = new Size(768, 27);
            txtExcelPath.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabFillHtml);
            tabControl1.Controls.Add(tabCreateTd);
            tabControl1.Location = new Point(27, 32);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(990, 488);
            tabControl1.TabIndex = 2;
            // 
            // tabFillHtml
            // 
            tabFillHtml.Controls.Add(txtExcelPath);
            tabFillHtml.Controls.Add(btnFillHtml);
            tabFillHtml.Location = new Point(4, 28);
            tabFillHtml.Name = "tabFillHtml";
            tabFillHtml.Padding = new Padding(3);
            tabFillHtml.Size = new Size(982, 456);
            tabFillHtml.TabIndex = 0;
            tabFillHtml.Text = "FillHtml";
            tabFillHtml.UseVisualStyleBackColor = true;
            // 
            // tabCreateTd
            // 
            tabCreateTd.Controls.Add(txtResultHtml);
            tabCreateTd.Controls.Add(txtColsExpr);
            tabCreateTd.Controls.Add(btnCreateTd);
            tabCreateTd.Controls.Add(txtTmplExcelPath);
            tabCreateTd.Location = new Point(4, 28);
            tabCreateTd.Name = "tabCreateTd";
            tabCreateTd.Padding = new Padding(3);
            tabCreateTd.Size = new Size(982, 456);
            tabCreateTd.TabIndex = 1;
            tabCreateTd.Text = "CreateTd";
            tabCreateTd.UseVisualStyleBackColor = true;
            // 
            // txtResultHtml
            // 
            txtResultHtml.Location = new Point(36, 224);
            txtResultHtml.Multiline = true;
            txtResultHtml.Name = "txtResultHtml";
            txtResultHtml.Size = new Size(768, 194);
            txtResultHtml.TabIndex = 6;
            txtResultHtml.WordWrap = false;
            // 
            // txtColsExpr
            // 
            txtColsExpr.Location = new Point(36, 75);
            txtColsExpr.Multiline = true;
            txtColsExpr.Name = "txtColsExpr";
            txtColsExpr.Size = new Size(768, 129);
            txtColsExpr.TabIndex = 5;
            // 
            // btnCreateTd
            // 
            btnCreateTd.Location = new Point(820, 175);
            btnCreateTd.Margin = new Padding(4);
            btnCreateTd.Name = "btnCreateTd";
            btnCreateTd.Size = new Size(96, 29);
            btnCreateTd.TabIndex = 4;
            btnCreateTd.Text = "Create Td";
            btnCreateTd.UseVisualStyleBackColor = true;
            btnCreateTd.Click += btnCreateTd_Click;
            // 
            // txtTmplExcelPath
            // 
            txtTmplExcelPath.Location = new Point(36, 29);
            txtTmplExcelPath.Name = "txtTmplExcelPath";
            txtTmplExcelPath.Size = new Size(768, 27);
            txtTmplExcelPath.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 570);
            Controls.Add(tabControl1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabFillHtml.ResumeLayout(false);
            tabFillHtml.PerformLayout();
            tabCreateTd.ResumeLayout(false);
            tabCreateTd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFillHtml;
        private TextBox txtExcelPath;
        private TabControl tabControl1;
        private TabPage tabFillHtml;
        private TabPage tabCreateTd;
        private TextBox txtTmplExcelPath;
        private Button btnCreateTd;
        private TextBox txtColsExpr;
        private TextBox txtResultHtml;
    }
}
