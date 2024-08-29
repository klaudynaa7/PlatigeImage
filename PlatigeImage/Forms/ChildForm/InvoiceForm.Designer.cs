namespace PlatigeImage.Forms
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            bsInvoice = new BindingSource(components);
            colContractor = new DevExpress.XtraGrid.Columns.GridColumn();
            riiceContractor = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colNetValues = new DevExpress.XtraGrid.Columns.GridColumn();
            teValueWithCurrency = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            colGrossValue = new DevExpress.XtraGrid.Columns.GridColumn();
            colVat = new DevExpress.XtraGrid.Columns.GridColumn();
            colVatRate = new DevExpress.XtraGrid.Columns.GridColumn();
            teVatRate = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            colSaleDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)pButton).BeginInit();
            pButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcContainer).BeginInit();
            gcContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcGrid).BeginInit();
            gcGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pGenerateData).BeginInit();
            pGenerateData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)riiceContractor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teValueWithCurrency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teVatRate).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.ImageOptions.Image = (Image)resources.GetObject("btnConfirm.ImageOptions.Image");
            // 
            // btnExport
            // 
            btnExport.ImageOptions.Image = (Image)resources.GetObject("btnExport.ImageOptions.Image");
            // 
            // pButton
            // 
            pButton.Location = new Point(0, 400);
            pButton.Size = new Size(800, 50);
            // 
            // gcContainer
            // 
            gcContainer.Size = new Size(800, 450);
            // 
            // gcGrid
            // 
            gcGrid.Size = new Size(800, 400);
            // 
            // gridControl
            // 
            gridControl.DataSource = bsInvoice;
            gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { teVatRate, teValueWithCurrency, riiceContractor });
            gridControl.Size = new Size(800, 400);
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colContractor, colNumber, colNetValues, colGrossValue, colVat, colVatRate, colCurrency, colSaleDate, colDescription });
            gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            gridView.OptionsLayout.Columns.AddNewColumns = false;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            gridView.OptionsView.ShowGroupPanel = false;
            // 
            // pGenerateData
            // 
            pGenerateData.Location = new Point(406, 2);
            // 
            // btnGenerateData
            // 
            btnGenerateData.ImageOptions.Image = (Image)resources.GetObject("btnGenerateData.ImageOptions.Image");
            // 
            // bsInvoice
            // 
            bsInvoice.DataSource = typeof(Data.Entities.Invoice);
            // 
            // colContractor
            // 
            colContractor.AppearanceHeader.Options.UseTextOptions = true;
            colContractor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colContractor.Caption = "Kontrahent";
            colContractor.ColumnEdit = riiceContractor;
            colContractor.FieldName = "ContractorId";
            colContractor.MinWidth = 30;
            colContractor.Name = "colContractor";
            colContractor.Visible = true;
            colContractor.VisibleIndex = 0;
            colContractor.Width = 112;
            // 
            // riiceContractor
            // 
            riiceContractor.AutoHeight = false;
            riiceContractor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            riiceContractor.Name = "riiceContractor";
            // 
            // colNumber
            // 
            colNumber.AppearanceHeader.Options.UseTextOptions = true;
            colNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colNumber.Caption = "Numer";
            colNumber.FieldName = "Number";
            colNumber.MinWidth = 30;
            colNumber.Name = "colNumber";
            colNumber.Visible = true;
            colNumber.VisibleIndex = 1;
            colNumber.Width = 112;
            // 
            // colNetValues
            // 
            colNetValues.AppearanceHeader.Options.UseTextOptions = true;
            colNetValues.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colNetValues.Caption = "Wartoś netto";
            colNetValues.ColumnEdit = teValueWithCurrency;
            colNetValues.DisplayFormat.FormatString = "n2";
            colNetValues.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colNetValues.FieldName = "NetValues";
            colNetValues.MinWidth = 30;
            colNetValues.Name = "colNetValues";
            colNetValues.Visible = true;
            colNetValues.VisibleIndex = 2;
            colNetValues.Width = 112;
            // 
            // teValueWithCurrency
            // 
            teValueWithCurrency.AutoHeight = false;
            teValueWithCurrency.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            teValueWithCurrency.MaskSettings.Set("mask", "c");
            teValueWithCurrency.Name = "teValueWithCurrency";
            // 
            // colGrossValue
            // 
            colGrossValue.AppearanceHeader.Options.UseTextOptions = true;
            colGrossValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colGrossValue.Caption = "Wartoś brutto";
            colGrossValue.ColumnEdit = teValueWithCurrency;
            colGrossValue.DisplayFormat.FormatString = "n2";
            colGrossValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colGrossValue.FieldName = "GrossValue";
            colGrossValue.MinWidth = 30;
            colGrossValue.Name = "colGrossValue";
            colGrossValue.Visible = true;
            colGrossValue.VisibleIndex = 3;
            colGrossValue.Width = 112;
            // 
            // colVat
            // 
            colVat.AppearanceHeader.Options.UseTextOptions = true;
            colVat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colVat.Caption = "VAT";
            colVat.ColumnEdit = teValueWithCurrency;
            colVat.DisplayFormat.FormatString = "n";
            colVat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colVat.FieldName = "Vat";
            colVat.MinWidth = 30;
            colVat.Name = "colVat";
            colVat.Visible = true;
            colVat.VisibleIndex = 4;
            colVat.Width = 112;
            // 
            // colVatRate
            // 
            colVatRate.AppearanceHeader.Options.UseTextOptions = true;
            colVatRate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colVatRate.Caption = "Stawka VAT";
            colVatRate.ColumnEdit = teVatRate;
            colVatRate.FieldName = "VatRate";
            colVatRate.MinWidth = 30;
            colVatRate.Name = "colVatRate";
            colVatRate.Visible = true;
            colVatRate.VisibleIndex = 5;
            colVatRate.Width = 112;
            // 
            // teVatRate
            // 
            teVatRate.AutoHeight = false;
            teVatRate.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            teVatRate.MaskSettings.Set("mask", "P");
            teVatRate.Name = "teVatRate";
            // 
            // colCurrency
            // 
            colCurrency.AppearanceHeader.Options.UseTextOptions = true;
            colCurrency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colCurrency.Caption = "Waluta";
            colCurrency.FieldName = "Currency";
            colCurrency.MinWidth = 30;
            colCurrency.Name = "colCurrency";
            colCurrency.Visible = true;
            colCurrency.VisibleIndex = 6;
            colCurrency.Width = 112;
            // 
            // colSaleDate
            // 
            colSaleDate.AppearanceHeader.Options.UseTextOptions = true;
            colSaleDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colSaleDate.Caption = "Data sprzedaży";
            colSaleDate.DisplayFormat.FormatString = "dd.MM.yyy";
            colSaleDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colSaleDate.FieldName = "SaleDate";
            colSaleDate.MinWidth = 30;
            colSaleDate.Name = "colSaleDate";
            colSaleDate.Visible = true;
            colSaleDate.VisibleIndex = 7;
            colSaleDate.Width = 112;
            // 
            // colDescription
            // 
            colDescription.AppearanceHeader.Options.UseTextOptions = true;
            colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colDescription.Caption = "Opis";
            colDescription.FieldName = "Description";
            colDescription.MinWidth = 30;
            colDescription.Name = "colDescription";
            colDescription.Visible = true;
            colDescription.VisibleIndex = 8;
            colDescription.Width = 112;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "InvoiceForm";
            Text = "Faktury";
            ((System.ComponentModel.ISupportInitialize)pButton).EndInit();
            pButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcContainer).EndInit();
            gcContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcGrid).EndInit();
            gcGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pGenerateData).EndInit();
            pGenerateData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)riiceContractor).EndInit();
            ((System.ComponentModel.ISupportInitialize)teValueWithCurrency).EndInit();
            ((System.ComponentModel.ISupportInitialize)teVatRate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colContractor;
        private DevExpress.XtraGrid.Columns.GridColumn colNetValues;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossValue;
        private DevExpress.XtraGrid.Columns.GridColumn colVat;
        private DevExpress.XtraGrid.Columns.GridColumn colVatRate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit teVatRate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit teValueWithCurrency;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox riiceContractor;
    }
}