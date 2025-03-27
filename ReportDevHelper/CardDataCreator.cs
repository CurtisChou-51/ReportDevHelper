using System.Data;
using System.Data.SqlClient;
using System.Text.Json;

namespace ReportDevHelper
{
    public class CardDataCreator
    {
        private string _connectionString;

        public CardDataCreator(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string Create(string sql)
        {
            DataSet ds = GetData(sql);
            DataTable dt = ds.Tables[0];

            Dictionary<string, object> cardData = new();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Dictionary<string, object> rowData = CreateRowData(dt.Rows[i]);
                cardData[i.ToString()] = rowData;
            }

            string json = JsonSerializer.Serialize(cardData, new JsonSerializerOptions { WriteIndented = true });
            return $"let cardData = {json}\n;";
        }

        private Dictionary<string, object> CreateRowData(DataRow dr)
        {
            Dictionary<string, object> rowData = new()
            {
                { "dataErrorListId", 0 },
                { "censusNo", dr["CensusNo"] },
                { "dataId", dr["Id"] },
                { "relationGroupId", dr["RelationGroupId"] },
                { "specialSkipRemark", "" },
                { "sourceId", dr["SourceId"].ToString() ?? "" }
            };

            foreach (DataColumn column in dr.Table.Columns)
            {
                if (column.ColumnName is "Id" or "ProjectId" or "FileId" or "CensusNo" or "CensusNoSeq" or "RelationGroupId" or "SourceId")
                    continue;

                Dictionary<string, object> columnData = new()
                {
                    { "DataErrorListId", 0 },
                    { "DataErrorListColumnId", -1 },
                    { "FileSchemaColumnId", 0 },
                    { "ColumnEName", column.ColumnName },
                    { "ConditionNameList", new List<string>() },
                    { "PreviousData", "" },
                    { "ModifyValue", "" },
                    { "Remarks", "" },
                    { "IsManual", false },
                    { "IsFormulaChange", false },
                    { "IsRelationKey", false },
                    { "isCensusNoCol", false },
                    { "DataLength", column.MaxLength },
                    { "DataTypeId", 1 },
                    { "IsMask", false },
                    { "FormValue", dr[column].ToString() ?? "" },
                    { "hasFormModified", false }
                };

                rowData[column.ColumnName] = columnData;
            }
            return rowData;
        }

        private DataSet GetData(string sql)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(sql, conn);
            using var adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new();
            adapter.Fill(dataSet);
            return dataSet;
        }
    }
}
