﻿using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;

namespace ReportDevHelper
{
    public partial class Form1 : Form
    {
        private HtmlCreator _htmlCreator = new();

        public Form1()
        {
            InitializeComponent();
            _htmlCreator.Init();

            txtConnStr.Text = ConfigurationManager.AppSettings["connStr"];
            txtSql.Text = ConfigurationManager.AppSettings["cardDataDefaultSql"];
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

            Dictionary<string, string> dict = helper.Read();
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

        private void btnCardData_Click(object sender, EventArgs e)
        {
            CardDataCreator cardDataCreator = new(txtConnStr.Text);
            string sql = txtSql.Text;
            txtResultCardData.Text = cardDataCreator.Create(sql);
        }

        private void btnReplaceTags_Click(object sender, EventArgs e)
        {
            string excelPath = txtTmplExcelPath.Text;
            using ExcelReadHtmlHelper helper = new(excelPath);

            Dictionary<string, string> dict = helper.Read();
            string input = txtColsExpr.Text;
            txtResultHtml.Text = ReplaceTags(input, dict);
        }

        private void btnGenProps_Click(object sender, EventArgs e)
        {
            string excelPath = txtTmplExcelPath.Text;
            using ExcelReadHtmlHelper helper = new(excelPath);

            HashSet<string> cols = helper.YieldReadColumns().ToHashSet();
            txtResultHtml.Clear();

            foreach (string input in txtColsExpr.Text.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries))
            {
                // find all expressions in input
                string[] exprs = Regex.Matches(input, @"[A-Za-z]+[\d\*]*")
                    .Cast<Match>()
                    .Select(m => m.Value)
                    .Distinct()
                    .ToArray();

                // find all matched columns for each expression
                var propMatch = exprs
                    .Select(x => new { prop = x, matches = GetMatchedProps(x, cols).ToArray() })
                    .ToArray();

                // replace each expression with its matched columns and combine
                int maxCount = propMatch.Max(x => x.matches.Length);
                for (int i = 0; i < maxCount; i++)
                {
                    string reuslt = input;
                    foreach (var item in propMatch)
                    {
                        if (item.matches.Length > i)
                            reuslt = reuslt.Replace(item.prop, item.matches[i]);
                    }
                    txtResultHtml.AppendText(reuslt + Environment.NewLine);
                }
            }
        }

        private static IEnumerable<string> GetMatchedProps(string propExpr, HashSet<string> cols)
        {
            string regexPattern = $"^{Regex.Escape(propExpr.Replace("＊", "*")).Replace("\\*", ".*")}$";
            foreach (string col in cols)
                if (Regex.IsMatch(col, regexPattern))
                    yield return col;
        }

        private static string ReplaceTags(string template, Dictionary<string, string> replacementDict)
        {
            string pattern = @"\[([0-9A-Za-z@]+)\]";
            return Regex.Replace(template, pattern, match =>
            {
                string[] matchAry = match.Groups[1].Value.Split('@');
                string key = matchAry.First();
                string templateHtml = replacementDict.TryGetValue(key, out string? value) ? value : match.Value;
                if (matchAry.Length == 1)
                    return templateHtml;

                // for radio expression，ex: [FB30002@1]、[FB30002@2]、[FB30002@3]
                string radioValue = matchAry[1];
                return templateHtml.Split('\n').FirstOrDefault(x => x.Contains($"value=\"{radioValue}\"")) ?? match.Value;
            });
        }

        private void txtExcelPath_TextChanged(object sender, EventArgs e)
        {
            txtExcelPath.Text = txtExcelPath.Text.Trim('\"');
        }

        private void txtTmplExcelPath_TextChanged(object sender, EventArgs e)
        {
            txtTmplExcelPath.Text = txtTmplExcelPath.Text.Trim('\"');
        }

    }
}
