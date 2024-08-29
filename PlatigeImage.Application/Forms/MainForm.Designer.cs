namespace PlatigeImage
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            bbiContractor = new DevExpress.XtraBars.BarButtonItem();
            btnInvoice = new DevExpress.XtraBars.BarButtonItem();
            bbiInvoicesPerContractorReports = new DevExpress.XtraBars.BarButtonItem();
            bbiTotalValueOfInvoicePerMonthReport = new DevExpress.XtraBars.BarButtonItem();
            bbiNumberOfContractorsInCountry = new DevExpress.XtraBars.BarButtonItem();
            rpMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            rpgContractor = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            rpReports = new DevExpress.XtraBars.Ribbon.RibbonPage();
            rpgReports = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            mdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ((System.ComponentModel.ISupportInitialize)mainRibbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mdiManager).BeginInit();
            SuspendLayout();
            // 
            // mainRibbon
            // 
            mainRibbon.ApplicationButtonImageOptions.Image = (Image)resources.GetObject("mainRibbon.ApplicationButtonImageOptions.Image");
            mainRibbon.EmptyAreaImageOptions.ImagePadding = new Padding(27, 23, 27, 23);
            mainRibbon.ExpandCollapseItem.Id = 0;
            mainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { mainRibbon.ExpandCollapseItem, bbiContractor, btnInvoice, bbiInvoicesPerContractorReports, bbiTotalValueOfInvoicePerMonthReport, bbiNumberOfContractorsInCountry });
            mainRibbon.Location = new Point(0, 0);
            mainRibbon.Margin = new Padding(3, 2, 3, 2);
            mainRibbon.MaxItemId = 6;
            mainRibbon.Name = "mainRibbon";
            mainRibbon.OptionsMenuMinWidth = 297;
            mainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { rpMain, rpReports });
            mainRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            mainRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            mainRibbon.ShowToolbarCustomizeItem = false;
            mainRibbon.Size = new Size(1382, 231);
            mainRibbon.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiContractor
            // 
            bbiContractor.Caption = "Kontrahenci";
            bbiContractor.Id = 1;
            bbiContractor.ImageOptions.LargeImage = (Image)resources.GetObject("bbiContractor.ImageOptions.LargeImage");
            bbiContractor.Name = "bbiContractor";
            bbiContractor.ItemClick += bbiContractor_ItemClick;
            // 
            // btnInvoice
            // 
            btnInvoice.Caption = "Faktury";
            btnInvoice.Id = 2;
            btnInvoice.ImageOptions.LargeImage = (Image)resources.GetObject("btnInvoice.ImageOptions.LargeImage");
            btnInvoice.Name = "btnInvoice";
            btnInvoice.ItemClick += btnInvoice_ItemClick;
            // 
            // bbiInvoicesPerContractorReports
            // 
            bbiInvoicesPerContractorReports.Caption = "Faktury per kontrahent";
            bbiInvoicesPerContractorReports.Id = 3;
            bbiInvoicesPerContractorReports.ImageOptions.LargeImage = (Image)resources.GetObject("bbiInvoicesPerContractorReports.ImageOptions.LargeImage");
            bbiInvoicesPerContractorReports.ItemAppearance.Normal.Options.UseTextOptions = true;
            bbiInvoicesPerContractorReports.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            bbiInvoicesPerContractorReports.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            bbiInvoicesPerContractorReports.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            bbiInvoicesPerContractorReports.Name = "bbiInvoicesPerContractorReports";
            bbiInvoicesPerContractorReports.ItemClick += bbiInvoicesPerContractorReports_ItemClickAsync;
            // 
            // bbiTotalValueOfInvoicePerMonthReport
            // 
            bbiTotalValueOfInvoicePerMonthReport.Caption = "Suma faktur per miesiąc";
            bbiTotalValueOfInvoicePerMonthReport.Id = 4;
            bbiTotalValueOfInvoicePerMonthReport.ImageOptions.LargeImage = (Image)resources.GetObject("bbiTotalValueOfInvoicePerMonthReport.ImageOptions.LargeImage");
            bbiTotalValueOfInvoicePerMonthReport.Name = "bbiTotalValueOfInvoicePerMonthReport";
            bbiTotalValueOfInvoicePerMonthReport.ItemClick += bbiTotalValueOfInvoicePerMonthReport_ItemClick;
            // 
            // bbiNumberOfContractorsInCountry
            // 
            bbiNumberOfContractorsInCountry.Caption = "Liczba kontrahentów w kraju";
            bbiNumberOfContractorsInCountry.Id = 5;
            bbiNumberOfContractorsInCountry.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem1.ImageOptions.LargeImage");
            bbiNumberOfContractorsInCountry.Name = "bbiNumberOfContractorsInCountry";
            bbiNumberOfContractorsInCountry.ItemClick += bbiNumberOfContractorsInCountry_ItemClick;
            // 
            // rpMain
            // 
            rpMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { rpgContractor });
            rpMain.Name = "rpMain";
            rpMain.Text = "Dane";
            // 
            // rpgContractor
            // 
            rpgContractor.AllowTextClipping = false;
            rpgContractor.ItemLinks.Add(bbiContractor);
            rpgContractor.ItemLinks.Add(btnInvoice);
            rpgContractor.Name = "rpgContractor";
            // 
            // rpReports
            // 
            rpReports.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { rpgReports });
            rpReports.Name = "rpReports";
            rpReports.Text = "Raporty";
            // 
            // rpgReports
            // 
            rpgReports.ItemLinks.Add(bbiInvoicesPerContractorReports);
            rpgReports.ItemLinks.Add(bbiTotalValueOfInvoicePerMonthReport);
            rpgReports.ItemLinks.Add(bbiNumberOfContractorsInCountry);
            rpgReports.Name = "rpgReports";
            // 
            // mdiManager
            // 
            mdiManager.AppearancePage.Header.Options.UseTextOptions = true;
            mdiManager.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            mdiManager.AppearancePage.HeaderActive.Font = new Font("Tahoma", 8F, FontStyle.Bold);
            mdiManager.AppearancePage.HeaderActive.Options.UseFont = true;
            mdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            mdiManager.MdiParent = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 761);
            Controls.Add(mainRibbon);
            IconOptions.ShowIcon = false;
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Ribbon = mainRibbon;
            ((System.ComponentModel.ISupportInitialize)mainRibbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)mdiManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgContractor;
        private DevExpress.XtraBars.BarButtonItem bbiContractor;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdiManager;
        private DevExpress.XtraBars.BarButtonItem btnInvoice;
        private DevExpress.XtraBars.BarButtonItem bbiInvoicesPerContractorReports;
        private DevExpress.XtraBars.BarButtonItem bbiTotalValueOfInvoicePerMonthReport;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpReports;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgReports;
        private DevExpress.XtraBars.BarButtonItem bbiNumberOfContractorsInCountry;
    }
}