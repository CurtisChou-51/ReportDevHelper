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

        private void button1_Click(object sender, EventArgs e)
        {
            string excelPath = txtExcelPath.Text;
            using ExcelHelper excelHelper = new(excelPath);
            int row = 1;
            while (!excelHelper.IsEnd(row))
            {
                ColumnDto dto = excelHelper.Read(row);
                string html = _htmlCreator.Create(dto);
                excelHelper.Update(row, html);
                row++;
            }

            string newFileName = $"{Path.GetFileNameWithoutExtension(excelPath)}_html.xlsx";
            string savePath = Path.Combine(Path.GetDirectoryName(excelPath)!, newFileName);
            excelHelper.Save(savePath);

            MessageBox.Show("Done");
        }

    }
}
