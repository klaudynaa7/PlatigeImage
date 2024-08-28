namespace PlatigeImage.Forms
{
    partial class NumberOfDataToGenerateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberOfDataToGenerateForm));
            groupControl = new DevExpress.XtraEditors.GroupControl();
            layoutControl = new DevExpress.XtraLayout.LayoutControl();
            btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            teNumberOfDataToGenerate = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            lciNumberOfDataToGenerate = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            lciConfirm = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)groupControl).BeginInit();
            groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl).BeginInit();
            layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teNumberOfDataToGenerate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciNumberOfDataToGenerate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciConfirm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            SuspendLayout();
            // 
            // groupControl
            // 
            groupControl.Controls.Add(layoutControl);
            groupControl.Dock = DockStyle.Fill;
            groupControl.Location = new Point(0, 0);
            groupControl.Name = "groupControl";
            groupControl.ShowCaption = false;
            groupControl.Size = new Size(441, 156);
            groupControl.TabIndex = 0;
            // 
            // layoutControl
            // 
            layoutControl.Controls.Add(btnConfirm);
            layoutControl.Controls.Add(teNumberOfDataToGenerate);
            layoutControl.Dock = DockStyle.Fill;
            layoutControl.Location = new Point(2, 2);
            layoutControl.Name = "layoutControl";
            layoutControl.Root = Root;
            layoutControl.Size = new Size(437, 152);
            layoutControl.TabIndex = 0;
            layoutControl.Text = "layoutControl1";
            // 
            // btnConfirm
            // 
            btnConfirm.ImageOptions.Image = (Image)resources.GetObject("btnConfirm.ImageOptions.Image");
            btnConfirm.Location = new Point(303, 108);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(122, 32);
            btnConfirm.StyleController = layoutControl;
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Potwierdź";
            btnConfirm.Click += btnConfirm_Click;
            // 
            // teNumberOfDataToGenerate
            // 
            teNumberOfDataToGenerate.Location = new Point(307, 53);
            teNumberOfDataToGenerate.Name = "teNumberOfDataToGenerate";
            teNumberOfDataToGenerate.Properties.DisplayFormat.FormatString = "N0";
            teNumberOfDataToGenerate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            teNumberOfDataToGenerate.Properties.MaxLength = 2;
            teNumberOfDataToGenerate.Size = new Size(118, 26);
            teNumberOfDataToGenerate.StyleController = layoutControl;
            teNumberOfDataToGenerate.TabIndex = 0;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { lciNumberOfDataToGenerate, emptySpaceItem1, emptySpaceItem2, lciConfirm, emptySpaceItem3 });
            Root.Name = "Root";
            Root.Size = new Size(437, 152);
            Root.TextVisible = false;
            // 
            // lciNumberOfDataToGenerate
            // 
            lciNumberOfDataToGenerate.Control = teNumberOfDataToGenerate;
            lciNumberOfDataToGenerate.Location = new Point(0, 41);
            lciNumberOfDataToGenerate.Name = "lciNumberOfDataToGenerate";
            lciNumberOfDataToGenerate.Size = new Size(417, 30);
            lciNumberOfDataToGenerate.Text = "Podaj liczbę danych do wygenerowania:";
            lciNumberOfDataToGenerate.TextSize = new Size(283, 19);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 96);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(291, 36);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(0, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(417, 41);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // lciConfirm
            // 
            lciConfirm.Control = btnConfirm;
            lciConfirm.Location = new Point(291, 96);
            lciConfirm.Name = "lciConfirm";
            lciConfirm.Size = new Size(126, 36);
            lciConfirm.TextSize = new Size(0, 0);
            lciConfirm.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new Point(0, 71);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new Size(417, 25);
            emptySpaceItem3.TextSize = new Size(0, 0);
            // 
            // NumberOfDataToGenerateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 156);
            Controls.Add(groupControl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NumberOfDataToGenerateForm";
            ShowIcon = false;
            Text = "Generowanie danych";
            ((System.ComponentModel.ISupportInitialize)groupControl).EndInit();
            groupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl).EndInit();
            layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teNumberOfDataToGenerate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciNumberOfDataToGenerate).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciConfirm).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.TextEdit teNumberOfDataToGenerate;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciNumberOfDataToGenerate;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem lciConfirm;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}