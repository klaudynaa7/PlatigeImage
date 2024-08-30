using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using PlatigeImage.Resources;
using System.Data;

namespace PlatigeImage.Export
{
    public class XmlExport : IExport
    {
        public void Export(GridView gricView, string filePath)
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = StringResource.Export;
            foreach (GridColumn column in gricView.Columns)
            {
                dataTable.Columns.Add(column.FieldName, column.ColumnType);
            }

            for (int i = 0; i < gricView.DataRowCount; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (GridColumn column in gricView.Columns)
                {
                    dataRow[column.FieldName] = gricView.GetRowCellValue(i, column);
                }
                dataTable.Rows.Add(dataRow);
            }
            dataTable.WriteXml(filePath);
        }
    }
}
