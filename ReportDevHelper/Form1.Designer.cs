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
            label4 = new Label();
            tabCreateTd = new TabPage();
            btnReplaceTags = new Button();
            label3 = new Label();
            txtResultHtml = new TextBox();
            txtColsExpr = new TextBox();
            btnCreateTd = new Button();
            txtTmplExcelPath = new TextBox();
            tabCardData = new TabPage();
            label2 = new Label();
            txtSql = new TextBox();
            label1 = new Label();
            txtConnStr = new TextBox();
            txtResultCardData = new TextBox();
            btnCardData = new Button();
            btnGenProps = new Button();
            tabControl1.SuspendLayout();
            tabFillHtml.SuspendLayout();
            tabCreateTd.SuspendLayout();
            tabCardData.SuspendLayout();
            SuspendLayout();
            // 
            // btnFillHtml
            // 
            btnFillHtml.Location = new Point(684, 45);
            btnFillHtml.Name = "btnFillHtml";
            btnFillHtml.Size = new Size(75, 23);
            btnFillHtml.TabIndex = 0;
            btnFillHtml.Text = "Fill Html";
            btnFillHtml.UseVisualStyleBackColor = true;
            btnFillHtml.Click += btnFillHtml_Click;
            // 
            // txtExcelPath
            // 
            txtExcelPath.Location = new Point(28, 45);
            txtExcelPath.Margin = new Padding(2, 2, 2, 2);
            txtExcelPath.Name = "txtExcelPath";
            txtExcelPath.Size = new Size(640, 23);
            txtExcelPath.TabIndex = 1;
            txtExcelPath.TextChanged += txtExcelPath_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabFillHtml);
            tabControl1.Controls.Add(tabCreateTd);
            tabControl1.Controls.Add(tabCardData);
            tabControl1.Location = new Point(21, 9);
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(781, 431);
            tabControl1.TabIndex = 2;
            // 
            // tabFillHtml
            // 
            tabFillHtml.Controls.Add(label4);
            tabFillHtml.Controls.Add(txtExcelPath);
            tabFillHtml.Controls.Add(btnFillHtml);
            tabFillHtml.Location = new Point(4, 24);
            tabFillHtml.Margin = new Padding(2, 2, 2, 2);
            tabFillHtml.Name = "tabFillHtml";
            tabFillHtml.Padding = new Padding(2, 2, 2, 2);
            tabFillHtml.Size = new Size(773, 403);
            tabFillHtml.TabIndex = 0;
            tabFillHtml.Text = "FillHtml";
            tabFillHtml.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 17);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 11;
            label4.Text = "Excel Path";
            // 
            // tabCreateTd
            // 
            tabCreateTd.Controls.Add(btnGenProps);
            tabCreateTd.Controls.Add(btnReplaceTags);
            tabCreateTd.Controls.Add(label3);
            tabCreateTd.Controls.Add(txtResultHtml);
            tabCreateTd.Controls.Add(txtColsExpr);
            tabCreateTd.Controls.Add(btnCreateTd);
            tabCreateTd.Controls.Add(txtTmplExcelPath);
            tabCreateTd.Location = new Point(4, 24);
            tabCreateTd.Margin = new Padding(2, 2, 2, 2);
            tabCreateTd.Name = "tabCreateTd";
            tabCreateTd.Padding = new Padding(2, 2, 2, 2);
            tabCreateTd.Size = new Size(773, 403);
            tabCreateTd.TabIndex = 1;
            tabCreateTd.Text = "CreateTd";
            tabCreateTd.UseVisualStyleBackColor = true;
            // 
            // btnReplaceTags
            // 
            btnReplaceTags.Location = new Point(646, 206);
            btnReplaceTags.Name = "btnReplaceTags";
            btnReplaceTags.Size = new Size(96, 23);
            btnReplaceTags.TabIndex = 11;
            btnReplaceTags.Text = "Replace Tags";
            btnReplaceTags.UseVisualStyleBackColor = true;
            btnReplaceTags.Click += btnReplaceTags_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 16);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 10;
            label3.Text = "Excel-With-Html Path";
            // 
            // txtResultHtml
            // 
            txtResultHtml.Location = new Point(23, 245);
            txtResultHtml.Margin = new Padding(2, 2, 2, 2);
            txtResultHtml.MaxLength = int.MaxValue;
            txtResultHtml.Multiline = true;
            txtResultHtml.Name = "txtResultHtml";
            txtResultHtml.Size = new Size(721, 146);
            txtResultHtml.TabIndex = 6;
            txtResultHtml.WordWrap = false;
            // 
            // txtColsExpr
            // 
            txtColsExpr.Location = new Point(23, 84);
            txtColsExpr.Margin = new Padding(2, 2, 2, 2);
            txtColsExpr.MaxLength = int.MaxValue;
            txtColsExpr.Multiline = true;
            txtColsExpr.Name = "txtColsExpr";
            txtColsExpr.Size = new Size(721, 103);
            txtColsExpr.TabIndex = 5;
            txtColsExpr.WordWrap = false;
            // 
            // btnCreateTd
            // 
            btnCreateTd.Location = new Point(552, 206);
            btnCreateTd.Name = "btnCreateTd";
            btnCreateTd.Size = new Size(75, 23);
            btnCreateTd.TabIndex = 4;
            btnCreateTd.Text = "Create Td";
            btnCreateTd.UseVisualStyleBackColor = true;
            btnCreateTd.Click += btnCreateTd_Click;
            // 
            // txtTmplExcelPath
            // 
            txtTmplExcelPath.Location = new Point(23, 42);
            txtTmplExcelPath.Margin = new Padding(2, 2, 2, 2);
            txtTmplExcelPath.Name = "txtTmplExcelPath";
            txtTmplExcelPath.Size = new Size(721, 23);
            txtTmplExcelPath.TabIndex = 3;
            txtTmplExcelPath.TextChanged += txtTmplExcelPath_TextChanged;
            // 
            // tabCardData
            // 
            tabCardData.Controls.Add(label2);
            tabCardData.Controls.Add(txtSql);
            tabCardData.Controls.Add(label1);
            tabCardData.Controls.Add(txtConnStr);
            tabCardData.Controls.Add(txtResultCardData);
            tabCardData.Controls.Add(btnCardData);
            tabCardData.Location = new Point(4, 24);
            tabCardData.Margin = new Padding(2, 2, 2, 2);
            tabCardData.Name = "tabCardData";
            tabCardData.Size = new Size(773, 403);
            tabCardData.TabIndex = 2;
            tabCardData.Text = "CardData";
            tabCardData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 85);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 11;
            label2.Text = "Sql";
            // 
            // txtSql
            // 
            txtSql.Location = new Point(30, 103);
            txtSql.Margin = new Padding(2, 2, 2, 2);
            txtSql.Multiline = true;
            txtSql.Name = "txtSql";
            txtSql.Size = new Size(718, 70);
            txtSql.TabIndex = 10;
            txtSql.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 9;
            label1.Text = "ConnStr";
            // 
            // txtConnStr
            // 
            txtConnStr.Location = new Point(30, 47);
            txtConnStr.Margin = new Padding(2, 2, 2, 2);
            txtConnStr.Name = "txtConnStr";
            txtConnStr.Size = new Size(718, 23);
            txtConnStr.TabIndex = 8;
            // 
            // txtResultCardData
            // 
            txtResultCardData.Location = new Point(30, 220);
            txtResultCardData.Margin = new Padding(2, 2, 2, 2);
            txtResultCardData.Multiline = true;
            txtResultCardData.Name = "txtResultCardData";
            txtResultCardData.Size = new Size(718, 169);
            txtResultCardData.TabIndex = 7;
            txtResultCardData.WordWrap = false;
            // 
            // btnCardData
            // 
            btnCardData.Location = new Point(672, 185);
            btnCardData.Name = "btnCardData";
            btnCardData.Size = new Size(75, 23);
            btnCardData.TabIndex = 5;
            btnCardData.Text = "CardData";
            btnCardData.UseVisualStyleBackColor = true;
            btnCardData.Click += btnCardData_Click;
            // 
            // btnGenProps
            // 
            btnGenProps.Location = new Point(444, 206);
            btnGenProps.Name = "btnGenProps";
            btnGenProps.Size = new Size(82, 23);
            btnGenProps.TabIndex = 12;
            btnGenProps.Text = "Gen Props";
            btnGenProps.UseVisualStyleBackColor = true;
            btnGenProps.Click += btnGenProps_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabFillHtml.ResumeLayout(false);
            tabFillHtml.PerformLayout();
            tabCreateTd.ResumeLayout(false);
            tabCreateTd.PerformLayout();
            tabCardData.ResumeLayout(false);
            tabCardData.PerformLayout();
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
        private TabPage tabCardData;
        private Button btnCardData;
        private TextBox txtResultCardData;
        private TextBox txtConnStr;
        private Label label1;
        private TextBox txtSql;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnReplaceTags;
        private Button btnGenProps;
    }
}
