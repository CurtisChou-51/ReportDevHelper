using Aspose.Cells;

namespace ReportDevHelper
{
    public class ExcelFillHtmlHelper : IDisposable
    {
        private readonly Workbook _workbook;

        private Cells _Cells => _workbook.Worksheets[0].Cells;

        public ExcelFillHtmlHelper(string excelPath)
        {
            _workbook = new Workbook(excelPath);
        }

        public ColumnDto Read(int row)
        {
            return new ColumnDto
            {
                ColumnName = _Cells[row, 2].StringValue,
                DataType = _Cells[row, 3].StringValue,
                Len = _Cells[row, 4].StringValue,
                Type = _Cells[row, 10].StringValue,
                RadioValues = _Cells[row, 11].StringValue,
                CodeClass = _Cells[row, 12].StringValue
            };
        }

        public void Update(int row, string html)
        {
            _Cells[row, 15].Value = html;
        }

        public void Save(string path)
        {
            _workbook.Save(path);
        }

        public bool IsEnd(int row)
        {
            return _Cells.Rows.Count <= row;
        }

        public void Dispose()
        {
            _workbook.Dispose();
        }
    }
}
