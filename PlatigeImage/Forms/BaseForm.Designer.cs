namespace PlatigeImage.Forms
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            gcContainer = new DevExpress.XtraEditors.GroupControl();
            gcGrid = new DevExpress.XtraEditors.GroupControl();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            pButton = new DevExpress.XtraEditors.PanelControl();
            pGenerateData = new DevExpress.XtraEditors.PanelControl();
            btnGenerateData = new DevExpress.XtraEditors.SimpleButton();
            pExport = new DevExpress.XtraEditors.PanelControl();
            btnExport = new DevExpress.XtraEditors.SimpleButton();
            pConfirm = new DevExpress.XtraEditors.PanelControl();
            btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gcContainer).BeginInit();
            gcContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcGrid).BeginInit();
            gcGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pButton).BeginInit();
            pButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pGenerateData).BeginInit();
            pGenerateData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pExport).BeginInit();
            pExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pConfirm).BeginInit();
            pConfirm.SuspendLayout();
            SuspendLayout();
            // 
            // gcContainer
            // 
            gcContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gcContainer.Controls.Add(gcGrid);
            gcContainer.Controls.Add(pButton);
            gcContainer.Dock = DockStyle.Fill;
            gcContainer.Location = new Point(0, 0);
            gcContainer.Name = "gcContainer";
            gcContainer.Size = new Size(1057, 590);
            gcContainer.TabIndex = 0;
            gcContainer.Text = "groupControl1";
            // 
            // gcGrid
            // 
            gcGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gcGrid.Controls.Add(gridControl);
            gcGrid.Dock = DockStyle.Fill;
            gcGrid.Location = new Point(0, 0);
            gcGrid.Name = "gcGrid";
            gcGrid.ShowCaption = false;
            gcGrid.Size = new Size(1057, 540);
            gcGrid.TabIndex = 3;
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(0, 0);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(1057, 540);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            gridView.OptionsLayout.Columns.AddNewColumns = false;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.KeyDown += gridView_KeyDown;
            // 
            // pButton
            // 
            pButton.Controls.Add(pGenerateData);
            pButton.Controls.Add(pExport);
            pButton.Controls.Add(pConfirm);
            pButton.Dock = DockStyle.Bottom;
            pButton.Location = new Point(0, 540);
            pButton.MaximumSize = new Size(0, 200);
            pButton.MinimumSize = new Size(0, 50);
            pButton.Name = "pButton";
            pButton.Size = new Size(1057, 50);
            pButton.TabIndex = 1;
            // 
            // pGenerateData
            // 
            pGenerateData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pGenerateData.Controls.Add(btnGenerateData);
            pGenerateData.Dock = DockStyle.Right;
            pGenerateData.Location = new Point(663, 2);
            pGenerateData.Name = "pGenerateData";
            pGenerateData.Size = new Size(140, 46);
            pGenerateData.TabIndex = 5;
            // 
            // btnGenerateData
            // 
            btnGenerateData.ImageOptions.Image = (Image)resources.GetObject("btnGenerateData.ImageOptions.Image");
            btnGenerateData.Location = new Point(2, 2);
            btnGenerateData.Name = "btnGenerateData";
            btnGenerateData.Size = new Size(136, 42);
            btnGenerateData.TabIndex = 0;
            btnGenerateData.Text = "Generuj dane";
            btnGenerateData.Click += btnGenerateData_Click;
            // 
            // pExport
            // 
            pExport.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pExport.Controls.Add(btnExport);
            pExport.Dock = DockStyle.Right;
            pExport.Location = new Point(803, 2);
            pExport.Name = "pExport";
            pExport.Size = new Size(130, 46);
            pExport.TabIndex = 4;
            // 
            // btnExport
            // 
            btnExport.ImageOptions.Image = (Image)resources.GetObject("btnExport.ImageOptions.Image");
            btnExport.Location = new Point(2, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(126, 42);
            btnExport.TabIndex = 0;
            btnExport.Text = "Eksport";
            btnExport.Click += btnExport_Click;
            // 
            // pConfirm
            // 
            pConfirm.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pConfirm.Controls.Add(btnConfirm);
            pConfirm.Dock = DockStyle.Right;
            pConfirm.Location = new Point(933, 2);
            pConfirm.Name = "pConfirm";
            pConfirm.Size = new Size(122, 46);
            pConfirm.TabIndex = 3;
            // 
            // btnConfirm
            // 
            btnConfirm.ImageOptions.Image = (Image)resources.GetObject("btnConfirm.ImageOptions.Image");
            btnConfirm.Location = new Point(2, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(118, 42);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Potwierdź";
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 590);
            Controls.Add(gcContainer);
            Name = "BaseForm";
            ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)gcContainer).EndInit();
            gcContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcGrid).EndInit();
            gcGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pButton).EndInit();
            pButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pGenerateData).EndInit();
            pGenerateData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pExport).EndInit();
            pExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pConfirm).EndInit();
            pConfirm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        protected DevExpress.XtraEditors.SimpleButton btnConfirm;
        protected DevExpress.XtraEditors.SimpleButton btnExport;
        protected DevExpress.XtraEditors.PanelControl pButton;
        protected DevExpress.XtraEditors.GroupControl gcContainer;
        protected DevExpress.XtraEditors.GroupControl gcGrid;
        protected DevExpress.XtraGrid.GridControl gridControl;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.PanelControl pExport;
        private DevExpress.XtraEditors.PanelControl pConfirm;
        protected DevExpress.XtraEditors.PanelControl pGenerateData;
        protected DevExpress.XtraEditors.SimpleButton btnGenerateData;
    }
}