namespace PlatigeImage.Reports
{
    partial class NumberOfContractorsInCountryReport
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
            this.xrlHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xtCountryContractorCount = new DevExpress.XtraReports.UI.XRTable();
            this.xtrHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.xtcHeaderCountry = new DevExpress.XtraReports.UI.XRTableCell();
            this.xtcHeaderContractorCount = new DevExpress.XtraReports.UI.XRTableCell();
            this.Header = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.xtCountryContractorCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlHeader});
            this.TopMargin.Name = "TopMargin";
            // 
            // xrlHeader
            // 
            this.xrlHeader.Font = new DevExpress.Drawing.DXFont("Arial", 15F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrlHeader.LocationFloat = new DevExpress.Utils.PointFloat(52.7778F, 25.30556F);
            this.xrlHeader.Multiline = true;
            this.xrlHeader.Name = "xrlHeader";
            this.xrlHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlHeader.SizeF = new System.Drawing.SizeF(550F, 50F);
            this.xrlHeader.StylePriority.UseFont = false;
            this.xrlHeader.StylePriority.UseTextAlignment = false;
            this.xrlHeader.Text = "Liczba kontrahentów w danym kraju";
            this.xrlHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xtCountryContractorCount});
            this.Detail.HeightF = 52.08334F;
            this.Detail.Name = "Detail";
            // 
            // xtCountryContractorCount
            // 
            this.xtCountryContractorCount.BorderColor = System.Drawing.Color.DimGray;
            this.xtCountryContractorCount.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xtCountryContractorCount.LocationFloat = new DevExpress.Utils.PointFloat(52.7778F, 0F);
            this.xtCountryContractorCount.Name = "xtCountryContractorCount";
            this.xtCountryContractorCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xtCountryContractorCount.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xtrHeader});
            this.xtCountryContractorCount.SizeF = new System.Drawing.SizeF(550F, 28F);
            this.xtCountryContractorCount.StylePriority.UseBorderColor = false;
            this.xtCountryContractorCount.StylePriority.UseTextAlignment = false;
            this.xtCountryContractorCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            // NumberOfContractorsInCountryReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Header});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this.xtCountryContractorCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable xtCountryContractorCount;
        private DevExpress.XtraReports.UI.XRLabel xrlHeader;
        private DevExpress.XtraReports.UI.XRTableRow xtrHeader;
        private DevExpress.XtraReports.UI.XRTableCell xtcHeaderCountry;
        private DevExpress.XtraReports.UI.XRTableCell xtcHeaderContractorCount;
        private DevExpress.XtraReports.UI.XRControlStyle Header;
    }
}
