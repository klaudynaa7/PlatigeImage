using DevExpress.XtraGrid.Views.Grid;

namespace PlatigeImage.Export
{
    public class CsvExport : IExport
    {
        public void Export(GridView gricView, string filePath)
        {
            gricView.ExportToCsv(filePath);
        }
    }
}
