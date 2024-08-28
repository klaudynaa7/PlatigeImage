using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.IO;

namespace PlatigeImage.BusinessLogic
{
    internal class ExportData
    {
        internal void Run(GridView gridView)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";
                saveFileDialog.Title = "Zapisz jako";
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string fileExtension = Path.GetExtension(filePath);

                    if (fileExtension.Equals(".csv", StringComparison.OrdinalIgnoreCase))
                    {
                        ExportToCsv(gridView, filePath);
                    }
                    else if (fileExtension.Equals(".xml", StringComparison.OrdinalIgnoreCase))
                    {
                        ExportToXml(gridView, filePath);
                    }
                }
            }
        }

        private void ExportToCsv(GridView gridView, string filePath)
        {
            gridView.ExportToCsv(filePath);
        }

        private void ExportToXml(GridView gridView, string filePath)
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Eksport";
            foreach (GridColumn column in gridView.Columns)
            {
                dataTable.Columns.Add(column.FieldName, column.ColumnType);
            }

            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (GridColumn column in gridView.Columns)
                {
                    dataRow[column.FieldName] = gridView.GetRowCellValue(i, column);
                }
                dataTable.Rows.Add(dataRow);
            }
            dataTable.WriteXml(filePath);
        }
    }
}
