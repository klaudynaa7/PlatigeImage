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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.XRGroupSortingSummary xrGroupSortingSummary1 = new DevExpress.XtraReports.UI.XRGroupSortingSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrlHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.Header = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrtHeader = new DevExpress.XtraReports.UI.XRTable();
            this.xrtrHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtcContractorNameHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtcNrOfInvoiceHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtcGrossAmountHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtDetails = new DevExpress.XtraReports.UI.XRTable();
            this.xrtrDetails = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtcNrOfInvoice = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtcGrossAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrtHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtDetails)).BeginInit();
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
            this.xrlHeader.LocationFloat = new DevExpress.Utils.PointFloat(48.61111F, 28.77778F);
            this.xrlHeader.Multiline = true;
            this.xrlHeader.Name = "xrlHeader";
            this.xrlHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlHeader.SizeF = new System.Drawing.SizeF(550F, 50F);
            this.xrlHeader.StyleName = "Header";
            this.xrlHeader.StylePriority.UseBackColor = false;
            this.xrlHeader.StylePriority.UseFont = false;
            this.xrlHeader.StylePriority.UseTextAlignment = false;
            this.xrlHeader.Text = "Faktury wystawione na kontrahenta wraz z sumą kwot";
            this.xrlHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrtDetails});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Header.Font = new DevExpress.Drawing.DXFont("Tahoma", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Header.Name = "Header";
            this.Header.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ContractorName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 23F;
            this.GroupHeader1.Name = "GroupHeader1";
            xrGroupSortingSummary1.FieldName = "ContractorName";
            this.GroupHeader1.SortingSummary = xrGroupSortingSummary1;
            // 
            // xrtHeader
            // 
            this.xrtHeader.LocationFloat = new DevExpress.Utils.PointFloat(48.61113F, 0F);
            this.xrtHeader.Name = "xrtHeader";
            this.xrtHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrtHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrtrHeader});
            this.xrtHeader.SizeF = new System.Drawing.SizeF(549.9999F, 25F);
            this.xrtHeader.StyleName = "Header";
            // 
            // xrtrHeader
            // 
            this.xrtrHeader.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtcContractorNameHeader,
            this.xrtcNrOfInvoiceHeader,
            this.xrtcGrossAmountHeader});
            this.xrtrHeader.Name = "xrtrHeader";
            this.xrtrHeader.Weight = 1D;
            // 
            // xrtcContractorNameHeader
            // 
            this.xrtcContractorNameHeader.Multiline = true;
            this.xrtcContractorNameHeader.Name = "xrtcContractorNameHeader";
            this.xrtcContractorNameHeader.Text = "Kontrahent";
            this.xrtcContractorNameHeader.Weight = 1D;
            // 
            // xrtcNrOfInvoiceHeader
            // 
            this.xrtcNrOfInvoiceHeader.Multiline = true;
            this.xrtcNrOfInvoiceHeader.Name = "xrtcNrOfInvoiceHeader";
            this.xrtcNrOfInvoiceHeader.Text = "Nr faktury";
            this.xrtcNrOfInvoiceHeader.Weight = 1D;
            // 
            // xrtcGrossAmountHeader
            // 
            this.xrtcGrossAmountHeader.Multiline = true;
            this.xrtcGrossAmountHeader.Name = "xrtcGrossAmountHeader";
            this.xrtcGrossAmountHeader.Text = "Kwota";
            this.xrtcGrossAmountHeader.Weight = 1D;
            // 
            // xrtDetails
            // 
            this.xrtDetails.LocationFloat = new DevExpress.Utils.PointFloat(231.9444F, 0F);
            this.xrtDetails.Name = "xrtDetails";
            this.xrtDetails.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrtDetails.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrtrDetails});
            this.xrtDetails.SizeF = new System.Drawing.SizeF(366.6666F, 25F);
            this.xrtDetails.StylePriority.UseTextAlignment = false;
            this.xrtDetails.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrtrDetails
            // 
            this.xrtrDetails.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtcNrOfInvoice,
            this.xrtcGrossAmount});
            this.xrtrDetails.Name = "xrtrDetails";
            this.xrtrDetails.Weight = 1D;
            // 
            // xrtcNrOfInvoice
            // 
            this.xrtcNrOfInvoice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Invoices].[InvoiceId]")});
            this.xrtcNrOfInvoice.Multiline = true;
            this.xrtcNrOfInvoice.Name = "xrtcNrOfInvoice";
            this.xrtcNrOfInvoice.Text = "xrtcNrOfInvoice";
            this.xrtcNrOfInvoice.Weight = 1D;
            // 
            // xrtcGrossAmount
            // 
            this.xrtcGrossAmount.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Invoices].[GrossAmount]")});
            this.xrtcGrossAmount.Multiline = true;
            this.xrtcGrossAmount.Name = "xrtcGrossAmount";
            this.xrtcGrossAmount.Text = "xrtcGrossAmount";
            this.xrtcGrossAmount.Weight = 1D;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(Sum([TotalGrossAmount]))")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(48.61111F, 35.02778F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 23F);
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel2.Summary = xrSummary1;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(global::PlatigeImage.Dto.InvoicesPerContractor.InvoicesPerContractorDto);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrtHeader});
            this.GroupHeader2.HeightF = 25F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContractorName]")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(48.61113F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(183.3333F, 23F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ContractorName]")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(48.61111F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // InvoicesPerContractorReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.GroupHeader1,
            this.GroupFooter1,
            this.GroupHeader2});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Header});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrtHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrlHeader;
        private DevExpress.XtraReports.UI.XRControlStyle Header;
        private DevExpress.XtraReports.UI.XRTable xrtDetails;
        private DevExpress.XtraReports.UI.XRTableRow xrtrDetails;
        private DevExpress.XtraReports.UI.XRTableCell xrtcNrOfInvoice;
        private DevExpress.XtraReports.UI.XRTableCell xrtcGrossAmount;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable xrtHeader;
        private DevExpress.XtraReports.UI.XRTableRow xrtrHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrtcContractorNameHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrtcNrOfInvoiceHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrtcGrossAmountHeader;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    }
}
