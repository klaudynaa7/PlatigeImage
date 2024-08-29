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
            this.components = new System.ComponentModel.Container();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrlHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.Header = new DevExpress.XtraReports.UI.XRControlStyle();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.xrtHeader = new DevExpress.XtraReports.UI.XRTable();
            this.xrtrHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtcCountryHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtrCountOfContractor = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtDetails = new DevExpress.XtraReports.UI.XRTable();
            this.xrtrDetails = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtcCountry = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtcCountOfContractors = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtDetails)).BeginInit();
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
            this.xrtDetails});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Header.Name = "Header";
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(global::PlatigeImage.Dto.NumberOfContractorsInCountryReport.CountryContractorCountDto);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // xrtHeader
            // 
            this.xrtHeader.Font = new DevExpress.Drawing.DXFont("Arial", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrtHeader.LocationFloat = new DevExpress.Utils.PointFloat(52.77784F, 0F);
            this.xrtHeader.Name = "xrtHeader";
            this.xrtHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrtHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrtrHeader});
            this.xrtHeader.SizeF = new System.Drawing.SizeF(550F, 25F);
            this.xrtHeader.StyleName = "Header";
            this.xrtHeader.StylePriority.UseFont = false;
            this.xrtHeader.StylePriority.UseTextAlignment = false;
            this.xrtHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrtrHeader
            // 
            this.xrtrHeader.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtcCountryHeader,
            this.xrtrCountOfContractor});
            this.xrtrHeader.Name = "xrtrHeader";
            this.xrtrHeader.Weight = 1D;
            // 
            // xrtcCountryHeader
            // 
            this.xrtcCountryHeader.Multiline = true;
            this.xrtcCountryHeader.Name = "xrtcCountryHeader";
            this.xrtcCountryHeader.Text = "Kraj";
            this.xrtcCountryHeader.Weight = 2.75D;
            // 
            // xrtrCountOfContractor
            // 
            this.xrtrCountOfContractor.Multiline = true;
            this.xrtrCountOfContractor.Name = "xrtrCountOfContractor";
            this.xrtrCountOfContractor.Text = "Liczba kontrahentów";
            this.xrtrCountOfContractor.Weight = 2.75D;
            // 
            // xrtDetails
            // 
            this.xrtDetails.BorderColor = System.Drawing.Color.DimGray;
            this.xrtDetails.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrtDetails.LocationFloat = new DevExpress.Utils.PointFloat(52.77784F, 0F);
            this.xrtDetails.Name = "xrtDetails";
            this.xrtDetails.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrtDetails.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrtrDetails});
            this.xrtDetails.SizeF = new System.Drawing.SizeF(550F, 25F);
            this.xrtDetails.StylePriority.UseBorderColor = false;
            this.xrtDetails.StylePriority.UseBorders = false;
            this.xrtDetails.StylePriority.UseTextAlignment = false;
            this.xrtDetails.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrtrDetails
            // 
            this.xrtrDetails.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtcCountry,
            this.xrtcCountOfContractors});
            this.xrtrDetails.Name = "xrtrDetails";
            this.xrtrDetails.Weight = 1D;
            // 
            // xrtcCountry
            // 
            this.xrtcCountry.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Country]")});
            this.xrtcCountry.Multiline = true;
            this.xrtcCountry.Name = "xrtcCountry";
            this.xrtcCountry.Text = "xrtcCountry";
            this.xrtcCountry.Weight = 2.7500002080743968D;
            // 
            // xrtcCountOfContractors
            // 
            this.xrtcCountOfContractors.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContractorCount]")});
            this.xrtcCountOfContractors.Multiline = true;
            this.xrtcCountOfContractors.Name = "xrtcCountOfContractors";
            this.xrtcCountOfContractors.Text = "xrtcCountOfContractors";
            this.xrtcCountOfContractors.Weight = 2.7500000971013847D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrtHeader});
            this.GroupHeader1.HeightF = 25F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // NumberOfContractorsInCountryReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.GroupHeader1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Header});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrlHeader;
        private DevExpress.XtraReports.UI.XRControlStyle Header;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.XRTable xrtHeader;
        private DevExpress.XtraReports.UI.XRTableRow xrtrHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrtcCountryHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrtrCountOfContractor;
        private DevExpress.XtraReports.UI.XRTable xrtDetails;
        private DevExpress.XtraReports.UI.XRTableRow xrtrDetails;
        private DevExpress.XtraReports.UI.XRTableCell xrtcCountry;
        private DevExpress.XtraReports.UI.XRTableCell xrtcCountOfContractors;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
    }
}
