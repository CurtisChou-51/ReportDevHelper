using System.Text;

namespace ReportDevHelper
{
    public partial class Form1 : Form
    {
        private HtmlCreator _htmlCreator = new();

        public Form1()
        {
            InitializeComponent();
            _htmlCreator.Init();
        }

        private void btnFillHtml_Click(object sender, EventArgs e)
        {
            string excelPath = txtExcelPath.Text;
            using ExcelFillHtmlHelper helper = new(excelPath);
            int row = 1;
            while (!helper.IsEnd(row))
            {
                ColumnDto dto = helper.Read(row);
                string html = _htmlCreator.Create(dto);
                helper.Update(row, html);
                row++;
            }

            string newFileName = $"{Path.GetFileNameWithoutExtension(excelPath)}_html.xlsx";
            string savePath = Path.Combine(Path.GetDirectoryName(excelPath)!, newFileName);
            helper.Save(savePath);

            MessageBox.Show("Done");
        }

        private void btnCreateTd_Click(object sender, EventArgs e)
        {
            string excelPath = txtTmplExcelPath.Text;
            using ExcelReadHtmlHelper helper = new(excelPath);

            var dict = helper.Read();
            string input = txtColsExpr.Text;
            StringBuilder sb = new();
            foreach (string item in input.Split(Environment.NewLine))
            {
                sb.Append($"<tr>{Environment.NewLine}");
                foreach (string col in item.Split(new char[] { ' ', '\t' }))
                {
                    sb.Append("    <td style=\"text-align: center;\">");
                    if (dict.TryGetValue(col, out string? html))
                        sb.Append(html);
                    else
                        sb.Append(col);
                    sb.Append($"</td>{Environment.NewLine}");
                }
                sb.Append($"</tr>{Environment.NewLine}");
            }
            txtResultHtml.Text = sb.ToString();
        }
    }
}
