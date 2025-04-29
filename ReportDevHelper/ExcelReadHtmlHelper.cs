using Aspose.Cells;

namespace ReportDevHelper
{
    public class ExcelReadHtmlHelper : IDisposable
    {
        private readonly Workbook _workbook;

        private Cells _Cells => _workbook.Worksheets[0].Cells;

        public ExcelReadHtmlHelper(string excelPath)
        {
            _workbook = new Workbook(excelPath);
        }

        public Dictionary<string, string> Read()
        {
            int row = 1;
            Dictionary<string, string> dict = new();
            while (_Cells.Rows.Count > row)
            {
                string columnName = _Cells[row, 2].StringValue;
                string html = _Cells[row, 15].StringValue;
                row++;
                if (string.IsNullOrEmpty(columnName) || string.IsNullOrEmpty(html))
                    continue;
                dict[columnName] = html;
            }
            return dict;
        }

        public IEnumerable<string> YieldReadColumns()
        {
            int row = 1;
            while (_Cells.Rows.Count > row)
            {
                string columnName = _Cells[row, 2].StringValue;
                row++;
                if (!string.IsNullOrEmpty(columnName))
                    yield return columnName;
            }
        }

        public void Dispose()
        {
            _workbook.Dispose();
        }
    }
}
