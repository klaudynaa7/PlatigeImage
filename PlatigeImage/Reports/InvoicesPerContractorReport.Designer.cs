namespace PlatigeImage.Reports
{
    partial class InvoicesPerContractorReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrlHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xtInvoices = new DevExpress.XtraReports.UI.XRTable();
            this.xtrHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.xtcHeaderCountry = new DevExpress.XtraReports.UI.XRTableCell();
            this.xtcHeaderContractorCount = new DevExpress.XtraReports.UI.XRTableCell();
            this.Header = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.xtInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlHeader});
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xtInvoices});
            this.Detail.Name = "Detail";
            // 
            // xrlHeader
            // 
            this.xrlHeader.BackColor = System.Drawing.Color.Transparent;
            this.xrlHeader.Font = new DevExpress.Drawing.DXFont("Arial", 15F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrlHeader.LocationFloat = new DevExpress.Utils.PointFloat(48.61111F, 28.77778F);
            this.xrlHeader.Multiline = true;
            this.xrlHeader.Name = "xrlHeader";
            this.xrlHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrlHeader.SizeF = new System.Drawing.SizeF(550F, 50F);
            this.xrlHeader.StyleName = "Header";
            this.xrlHeader.StylePriority.UseBackColor = false;
            this.xrlHeader.StylePriority.UseFont = false;
            this.xrlHeader.StylePriority.UseTextAlignment = false;
            this.xrlHeader.Text = "Faktury wystawione na kontrahenta wraz z sumą kwot";
            this.xrlHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xtInvoices
            // 
            this.xtInvoices.BorderColor = System.Drawing.Color.DimGray;
            this.xtInvoices.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xtInvoices.LocationFloat = new DevExpress.Utils.PointFloat(52.7778F, 0F);
            this.xtInvoices.Name = "xtInvoices";
            this.xtInvoices.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xtInvoices.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xtrHeader});
            this.xtInvoices.SizeF = new System.Drawing.SizeF(550F, 28F);
            this.xtInvoices.StylePriority.UseBorderColor = false;
            this.xtInvoices.StylePriority.UseTextAlignment = false;
            this.xtInvoices.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xtrHeader
            // 
            this.xtrHeader.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xtcHeaderCountry,
            this.xtcHeaderContractorCount});
            this.xtrHeader.Name = "xtrHeader";
            this.xtrHeader.Weight = 1D;
            // 
            // xtcHeaderCountry
            // 
            this.xtcHeaderCountry.Multiline = true;
            this.xtcHeaderCountry.Name = "xtcHeaderCountry";
            this.xtcHeaderCountry.StyleName = "Header";
            this.xtcHeaderCountry.Text = "Kraj";
            this.xtcHeaderCountry.Weight = 1.4999999652813119D;
            // 
            // xtcHeaderContractorCount
            // 
            this.xtcHeaderContractorCount.Multiline = true;
            this.xtcHeaderContractorCount.Name = "xtcHeaderContractorCount";
            this.xtcHeaderContractorCount.StyleName = "Header";
            this.xtcHeaderContractorCount.Text = "Liczba kontrahentów";
            this.xtcHeaderContractorCount.Weight = 1.5000000347186884D;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Header.Name = "Header";
            // 
            // InvoiceReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Header});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this.xtInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrlHeader;
        private DevExpress.XtraReports.UI.XRTable xtInvoices;
        private DevExpress.XtraReports.UI.XRTableRow xtrHeader;
        private DevExpress.XtraReports.UI.XRTableCell xtcHeaderCountry;
        private DevExpress.XtraReports.UI.XRTableCell xtcHeaderContractorCount;
        private DevExpress.XtraReports.UI.XRControlStyle Header;
    }
}
