namespace PlatigeImage.Reports
{
    partial class TotalAmountPerMonthReport
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
            this.xrtTotalAmountPerMonth = new DevExpress.XtraReports.UI.XRTable();
            this.xrtrTotalAmountPerMonth = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtcYear = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtcMonth = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtcNEtAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtcGrossAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xtrMonthlyTotalAmount = new DevExpress.XtraReports.UI.XRTable();
            this.xtrvfgr = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtcYearHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xtcMonthHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xtcTotalNetAmountHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xtcTotalGrossAmountHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Header = new DevExpress.XtraReports.UI.XRControlStyle();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrtTotalAmountPerMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtrMonthlyTotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
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
            this.xrlHeader.BackColor = System.Drawing.Color.Transparent;
            this.xrlHeader.Font = new DevExpress.Drawing.DXFont("Arial", 15F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrlHeader.LocationFloat = new DevExpress.Utils.PointFloat(48.61111F, 20.44445F);
            this.xrlHeader.Multiline = true;
            this.xrlHeader.Name = "xrlHeader";
            this.xrlHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlHeader.SizeF = new System.Drawing.SizeF(550F, 50F);
            this.xrlHeader.StylePriority.UseBackColor = false;
            this.xrlHeader.StylePriority.UseFont = false;
            this.xrlHeader.StylePriority.UseTextAlignment = false;
            this.xrlHeader.Text = "Suma faktur netto i brutto w okresach miesięcznych";
            this.xrlHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrtTotalAmountPerMonth});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            // 
            // xrtTotalAmountPerMonth
            // 
            this.xrtTotalAmountPerMonth.BorderColor = System.Drawing.Color.DimGray;
            this.xrtTotalAmountPerMonth.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrtTotalAmountPerMonth.LocationFloat = new DevExpress.Utils.PointFloat(48.61111F, 0F);
            this.xrtTotalAmountPerMonth.Name = "xrtTotalAmountPerMonth";
            this.xrtTotalAmountPerMonth.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrtTotalAmountPerMonth.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrtrTotalAmountPerMonth});
            this.xrtTotalAmountPerMonth.SizeF = new System.Drawing.SizeF(550F, 25F);
            this.xrtTotalAmountPerMonth.StylePriority.UseBorderColor = false;
            this.xrtTotalAmountPerMonth.StylePriority.UseBorders = false;
            this.xrtTotalAmountPerMonth.StylePriority.UseTextAlignment = false;
            this.xrtTotalAmountPerMonth.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrtrTotalAmountPerMonth
            // 
            this.xrtrTotalAmountPerMonth.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtcYear,
            this.xrtcMonth,
            this.xrtcNEtAmount,
            this.xrtcGrossAmount});
            this.xrtrTotalAmountPerMonth.Name = "xrtrTotalAmountPerMonth";
            this.xrtrTotalAmountPerMonth.Weight = 1D;
            // 
            // xrtcYear
            // 
            this.xrtcYear.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Year]")});
            this.xrtcYear.Multiline = true;
            this.xrtcYear.Name = "xrtcYear";
            this.xrtcYear.Text = "xrtcYear";
            this.xrtcYear.Weight = 1.375D;
            // 
            // xrtcMonth
            // 
            this.xrtcMonth.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MonthName]")});
            this.xrtcMonth.Multiline = true;
            this.xrtcMonth.Name = "xrtcMonth";
            this.xrtcMonth.Text = "xrtcMonth";
            this.xrtcMonth.Weight = 1.375D;
            // 
            // xrtcNEtAmount
            // 
            this.xrtcNEtAmount.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalNetAmount]")});
            this.xrtcNEtAmount.Multiline = true;
            this.xrtcNEtAmount.Name = "xrtcNEtAmount";
            this.xrtcNEtAmount.Text = "xrtcNEtAmount";
            this.xrtcNEtAmount.Weight = 1.375D;
            // 
            // xrtcGrossAmount
            // 
            this.xrtcGrossAmount.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalGrossAmount]")});
            this.xrtcGrossAmount.Multiline = true;
            this.xrtcGrossAmount.Name = "xrtcGrossAmount";
            this.xrtcGrossAmount.Text = "xrtcGrossAmount";
            this.xrtcGrossAmount.Weight = 1.375D;
            // 
            // xtrMonthlyTotalAmount
            // 
            this.xtrMonthlyTotalAmount.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table;
            this.xtrMonthlyTotalAmount.LocationFloat = new DevExpress.Utils.PointFloat(48.61111F, 0F);
            this.xtrMonthlyTotalAmount.Name = "xtrMonthlyTotalAmount";
            this.xtrMonthlyTotalAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xtrMonthlyTotalAmount.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xtrvfgr});
            this.xtrMonthlyTotalAmount.SizeF = new System.Drawing.SizeF(550F, 25F);
            this.xtrMonthlyTotalAmount.StyleName = "Header";
            this.xtrMonthlyTotalAmount.StylePriority.UseTextAlignment = false;
            this.xtrMonthlyTotalAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xtrvfgr
            // 
            this.xtrvfgr.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtcYearHeader,
            this.xtcMonthHeader,
            this.xtcTotalNetAmountHeader,
            this.xtcTotalGrossAmountHeader});
            this.xtrvfgr.Name = "xtrvfgr";
            this.xtrvfgr.Weight = 1D;
            // 
            // xrtcYearHeader
            // 
            this.xrtcYearHeader.Multiline = true;
            this.xrtcYearHeader.Name = "xrtcYearHeader";
            this.xrtcYearHeader.Text = "Rok";
            this.xrtcYearHeader.Weight = 1D;
            // 
            // xtcMonthHeader
            // 
            this.xtcMonthHeader.Multiline = true;
            this.xtcMonthHeader.Name = "xtcMonthHeader";
            this.xtcMonthHeader.Text = "Miesiąc";
            this.xtcMonthHeader.Weight = 1D;
            // 
            // xtcTotalNetAmountHeader
            // 
            this.xtcTotalNetAmountHeader.Multiline = true;
            this.xtcTotalNetAmountHeader.Name = "xtcTotalNetAmountHeader";
            this.xtcTotalNetAmountHeader.Text = "Suma netto";
            this.xtcTotalNetAmountHeader.Weight = 1D;
            // 
            // xtcTotalGrossAmountHeader
            // 
            this.xtcTotalGrossAmountHeader.Multiline = true;
            this.xtcTotalGrossAmountHeader.Name = "xtcTotalGrossAmountHeader";
            this.xtcTotalGrossAmountHeader.Text = "Suma brutto";
            this.xtcTotalGrossAmountHeader.Weight = 1D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xtrMonthlyTotalAmount});
            this.GroupHeader1.HeightF = 25F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Header.Font = new DevExpress.Drawing.DXFont("Tahoma", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Header.Name = "Header";
            this.Header.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(global::PlatigeImage.Dto.TotalAmountPerMonth.MonthlyInvoiceSummaryDto);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // TotalAmountPerMonthReport
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
            ((System.ComponentModel.ISupportInitialize)(this.xrtTotalAmountPerMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtrMonthlyTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrlHeader;
        private DevExpress.XtraReports.UI.XRTableCell xtcMonthHeader;
        private DevExpress.XtraReports.UI.XRTableCell xtcTotalNetAmountHeader;
        private DevExpress.XtraReports.UI.XRTableCell xtcTotalGrossAmountHeader;
        private DevExpress.XtraReports.UI.XRTableRow xtrvfgr;
        private DevExpress.XtraReports.UI.XRTable xtrMonthlyTotalAmount;
        private DevExpress.XtraReports.UI.XRTableCell xrtcYearHeader;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRControlStyle Header;
        private DevExpress.XtraReports.UI.XRTable xrtTotalAmountPerMonth;
        private DevExpress.XtraReports.UI.XRTableRow xrtrTotalAmountPerMonth;
        private DevExpress.XtraReports.UI.XRTableCell xrtcYear;
        private DevExpress.XtraReports.UI.XRTableCell xrtcMonth;
        private DevExpress.XtraReports.UI.XRTableCell xrtcNEtAmount;
        private DevExpress.XtraReports.UI.XRTableCell xrtcGrossAmount;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
    }
}
