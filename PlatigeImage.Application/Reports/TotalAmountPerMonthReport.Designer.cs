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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrlHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xtrMonthlyTotalAmount = new DevExpress.XtraReports.UI.XRTable();
            this.xtrvfgr = new DevExpress.XtraReports.UI.XRTableRow();
            this.xtcMonthHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xtcTotalNetAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xtcTotalGrossAmount = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xtrMonthlyTotalAmount)).BeginInit();
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
            this.xtrMonthlyTotalAmount});
            this.Detail.Name = "Detail";
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
            // xtrMonthlyTotalAmount
            // 
            this.xtrMonthlyTotalAmount.AccessibleRole = DevExpress.XtraReports.UI.XRAccessibleRole.Table;
            this.xtrMonthlyTotalAmount.LocationFloat = new DevExpress.Utils.PointFloat(48.61111F, 9.999996F);
            this.xtrMonthlyTotalAmount.Name = "xtrMonthlyTotalAmount";
            this.xtrMonthlyTotalAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xtrMonthlyTotalAmount.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xtrvfgr});
            this.xtrMonthlyTotalAmount.SizeF = new System.Drawing.SizeF(550F, 25F);
            this.xtrMonthlyTotalAmount.StylePriority.UseTextAlignment = false;
            this.xtrMonthlyTotalAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xtrvfgr
            // 
            this.xtrvfgr.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xtcMonthHeader,
            this.xtcTotalNetAmount,
            this.xtcTotalGrossAmount});
            this.xtrvfgr.Name = "xtrvfgr";
            this.xtrvfgr.Weight = 1D;
            // 
            // xtcMonthHeader
            // 
            this.xtcMonthHeader.Multiline = true;
            this.xtcMonthHeader.Name = "xtcMonthHeader";
            this.xtcMonthHeader.Text = "Miesiąc";
            this.xtcMonthHeader.Weight = 1D;
            // 
            // xtcTotalNetAmount
            // 
            this.xtcTotalNetAmount.Multiline = true;
            this.xtcTotalNetAmount.Name = "xtcTotalNetAmount";
            this.xtcTotalNetAmount.Text = "Suma netto";
            this.xtcTotalNetAmount.Weight = 1D;
            // 
            // xtcTotalGrossAmount
            // 
            this.xtcTotalGrossAmount.Multiline = true;
            this.xtcTotalGrossAmount.Name = "xtcTotalGrossAmount";
            this.xtcTotalGrossAmount.Text = "Suma brutto";
            this.xtcTotalGrossAmount.Weight = 1D;
            // 
            // TotalAmountPerMonthReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this.xtrMonthlyTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrlHeader;
        private DevExpress.XtraReports.UI.XRTableCell xtcMonthHeader;
        private DevExpress.XtraReports.UI.XRTableCell xtcTotalNetAmount;
        private DevExpress.XtraReports.UI.XRTableCell xtcTotalGrossAmount;
        private DevExpress.XtraReports.UI.XRTableRow xtrvfgr;
        private DevExpress.XtraReports.UI.XRTable xtrMonthlyTotalAmount;
    }
}
