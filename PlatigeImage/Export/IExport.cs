using DevExpress.XtraGrid.Views.Grid;

namespace PlatigeImage.Export
{
    public interface IExport
    {
        void Export(GridView gricView, string filePath);
    }
}
