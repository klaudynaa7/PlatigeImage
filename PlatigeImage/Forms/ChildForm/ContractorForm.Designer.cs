namespace PlatigeImage.Forms
{
    partial class ContractorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractorForm));
            bsContractor = new BindingSource(components);
            colType = new DevExpress.XtraGrid.Columns.GridColumn();
            riiceType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colShortcut = new DevExpress.XtraGrid.Columns.GridColumn();
            colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            colNIP = new DevExpress.XtraGrid.Columns.GridColumn();
            colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)bsContractor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)riiceType).BeginInit();
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
            gridControl.DataSource = bsContractor;
            gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { riiceType });
            gridControl.Size = new Size(800, 400);
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colType, colName, colShortcut, colCountry, colAddress, colNIP, colIsActive });
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
            // bsContractor
            // 
            bsContractor.DataSource = typeof(Data.Entities.Contractor);
            // 
            // colType
            // 
            colType.AppearanceHeader.Options.UseTextOptions = true;
            colType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colType.Caption = "Typ";
            colType.ColumnEdit = riiceType;
            colType.FieldName = "Type";
            colType.MinWidth = 30;
            colType.Name = "colType";
            colType.Visible = true;
            colType.VisibleIndex = 0;
            colType.Width = 112;
            // 
            // riiceType
            // 
            riiceType.AutoHeight = false;
            riiceType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            riiceType.Name = "riiceType";
            // 
            // colName
            // 
            colName.AppearanceHeader.Options.UseTextOptions = true;
            colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colName.Caption = "Nazwa";
            colName.FieldName = "Name";
            colName.MinWidth = 30;
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 1;
            colName.Width = 112;
            // 
            // colShortcut
            // 
            colShortcut.AppearanceHeader.Options.UseTextOptions = true;
            colShortcut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colShortcut.Caption = "Skrót";
            colShortcut.FieldName = "Shortcut";
            colShortcut.MinWidth = 30;
            colShortcut.Name = "colShortcut";
            colShortcut.Visible = true;
            colShortcut.VisibleIndex = 2;
            colShortcut.Width = 112;
            // 
            // colCountry
            // 
            colCountry.AppearanceHeader.Options.UseTextOptions = true;
            colCountry.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colCountry.Caption = "Kraj";
            colCountry.FieldName = "Country";
            colCountry.MinWidth = 30;
            colCountry.Name = "colCountry";
            colCountry.Visible = true;
            colCountry.VisibleIndex = 3;
            colCountry.Width = 112;
            // 
            // colAddress
            // 
            colAddress.AppearanceHeader.Options.UseTextOptions = true;
            colAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colAddress.Caption = "Adres";
            colAddress.FieldName = "Address";
            colAddress.MinWidth = 30;
            colAddress.Name = "colAddress";
            colAddress.Visible = true;
            colAddress.VisibleIndex = 4;
            colAddress.Width = 112;
            // 
            // colNIP
            // 
            colNIP.AppearanceHeader.Options.UseTextOptions = true;
            colNIP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colNIP.Caption = "NIP";
            colNIP.FieldName = "NIP";
            colNIP.MinWidth = 30;
            colNIP.Name = "colNIP";
            colNIP.Visible = true;
            colNIP.VisibleIndex = 5;
            colNIP.Width = 112;
            // 
            // colIsActive
            // 
            colIsActive.AppearanceHeader.Options.UseTextOptions = true;
            colIsActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colIsActive.Caption = "Aktywny";
            colIsActive.FieldName = "IsActive";
            colIsActive.MinWidth = 30;
            colIsActive.Name = "colIsActive";
            colIsActive.Visible = true;
            colIsActive.VisibleIndex = 6;
            colIsActive.Width = 112;
            // 
            // ContractorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "ContractorForm";
            Text = "Kontrahenci";
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
            ((System.ComponentModel.ISupportInitialize)bsContractor).EndInit();
            ((System.ComponentModel.ISupportInitialize)riiceType).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsContractor;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox riiceType;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colShortcut;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colNIP;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
    }
}