namespace PlatigeImage
{
    partial class DatabaseConnectionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gcDataBaseConnection = new DevExpress.XtraEditors.GroupControl();
            lcDatabaseConnection = new DevExpress.XtraLayout.LayoutControl();
            btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            btnTestConnection = new DevExpress.XtraEditors.SimpleButton();
            btnListOfDatabase = new DevExpress.XtraEditors.SimpleButton();
            cbDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            tePassword = new DevExpress.XtraEditors.TextEdit();
            teLogin = new DevExpress.XtraEditors.TextEdit();
            teDataSource = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            lciDataSource = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            lciLogin = new DevExpress.XtraLayout.LayoutControlItem();
            lciPassword = new DevExpress.XtraLayout.LayoutControlItem();
            lciDatabase = new DevExpress.XtraLayout.LayoutControlItem();
            lciListOfDatabase = new DevExpress.XtraLayout.LayoutControlItem();
            lciTestConnection = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            lcgButton = new DevExpress.XtraLayout.LayoutControlGroup();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)gcDataBaseConnection).BeginInit();
            gcDataBaseConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lcDatabaseConnection).BeginInit();
            lcDatabaseConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbDatabase.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tePassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teLogin.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teDataSource.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciDataSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciDatabase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciListOfDatabase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciTestConnection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lcgButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            SuspendLayout();
            // 
            // gcDataBaseConnection
            // 
            gcDataBaseConnection.AppearanceCaption.Font = new Font("Tahoma", 8F, FontStyle.Bold);
            gcDataBaseConnection.AppearanceCaption.Options.UseFont = true;
            gcDataBaseConnection.Controls.Add(lcDatabaseConnection);
            gcDataBaseConnection.Dock = DockStyle.Fill;
            gcDataBaseConnection.Location = new Point(0, 0);
            gcDataBaseConnection.Name = "gcDataBaseConnection";
            gcDataBaseConnection.Size = new Size(618, 242);
            gcDataBaseConnection.TabIndex = 0;
            gcDataBaseConnection.Text = "BAZA DANYCH";
            // 
            // lcDatabaseConnection
            // 
            lcDatabaseConnection.Controls.Add(btnConfirm);
            lcDatabaseConnection.Controls.Add(btnTestConnection);
            lcDatabaseConnection.Controls.Add(btnListOfDatabase);
            lcDatabaseConnection.Controls.Add(cbDatabase);
            lcDatabaseConnection.Controls.Add(tePassword);
            lcDatabaseConnection.Controls.Add(teLogin);
            lcDatabaseConnection.Controls.Add(teDataSource);
            lcDatabaseConnection.Dock = DockStyle.Fill;
            lcDatabaseConnection.Location = new Point(2, 34);
            lcDatabaseConnection.Name = "lcDatabaseConnection";
            lcDatabaseConnection.Root = Root;
            lcDatabaseConnection.Size = new Size(614, 206);
            lcDatabaseConnection.TabIndex = 0;
            lcDatabaseConnection.Text = "layoutControl1";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(457, 148);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(145, 32);
            btnConfirm.StyleController = lcDatabaseConnection;
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Potwierdź";
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(12, 148);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(293, 32);
            btnTestConnection.StyleController = lcDatabaseConnection;
            btnTestConnection.TabIndex = 6;
            btnTestConnection.Text = "Testuj połączenie";
            // 
            // btnListOfDatabase
            // 
            btnListOfDatabase.Location = new Point(570, 102);
            btnListOfDatabase.Name = "btnListOfDatabase";
            btnListOfDatabase.Size = new Size(32, 32);
            btnListOfDatabase.StyleController = lcDatabaseConnection;
            btnListOfDatabase.TabIndex = 5;
            btnListOfDatabase.Text = "...";
            btnListOfDatabase.ToolTip = "Wyszukaj dostępne bazy danych";
            btnListOfDatabase.Click += btnListOfDatabase_Click;
            // 
            // cbDatabase
            // 
            cbDatabase.Location = new Point(111, 102);
            cbDatabase.Name = "cbDatabase";
            cbDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbDatabase.Size = new Size(455, 26);
            cbDatabase.StyleController = lcDatabaseConnection;
            cbDatabase.TabIndex = 4;
            // 
            // tePassword
            // 
            tePassword.Location = new Point(111, 72);
            tePassword.Name = "tePassword";
            tePassword.Properties.PasswordChar = '*';
            tePassword.Size = new Size(491, 26);
            tePassword.StyleController = lcDatabaseConnection;
            tePassword.TabIndex = 3;
            // 
            // teLogin
            // 
            teLogin.Location = new Point(111, 42);
            teLogin.Name = "teLogin";
            teLogin.Size = new Size(491, 26);
            teLogin.StyleController = lcDatabaseConnection;
            teLogin.TabIndex = 2;
            // 
            // teDataSource
            // 
            teDataSource.Location = new Point(111, 12);
            teDataSource.Name = "teDataSource";
            teDataSource.Size = new Size(491, 26);
            teDataSource.StyleController = lcDatabaseConnection;
            teDataSource.TabIndex = 0;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { lciDataSource, emptySpaceItem1, lciLogin, lciPassword, lciDatabase, lciListOfDatabase, lciTestConnection, emptySpaceItem2, emptySpaceItem5, layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new Size(614, 206);
            Root.TextVisible = false;
            // 
            // lciDataSource
            // 
            lciDataSource.Control = teDataSource;
            lciDataSource.CustomizationFormText = "Serwer";
            lciDataSource.Location = new Point(0, 0);
            lciDataSource.Name = "lciDataSource";
            lciDataSource.Size = new Size(594, 30);
            lciDataSource.Text = "Serwer";
            lciDataSource.TextSize = new Size(87, 19);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(297, 136);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(148, 36);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // lciLogin
            // 
            lciLogin.Control = teLogin;
            lciLogin.CustomizationFormText = "Login";
            lciLogin.Location = new Point(0, 30);
            lciLogin.Name = "lciLogin";
            lciLogin.Size = new Size(594, 30);
            lciLogin.Text = "Login";
            lciLogin.TextSize = new Size(87, 19);
            // 
            // lciPassword
            // 
            lciPassword.Control = tePassword;
            lciPassword.CustomizationFormText = "Hasło";
            lciPassword.Location = new Point(0, 60);
            lciPassword.Name = "lciPassword";
            lciPassword.Size = new Size(594, 30);
            lciPassword.Text = "Hasło";
            lciPassword.TextSize = new Size(87, 19);
            // 
            // lciDatabase
            // 
            lciDatabase.Control = cbDatabase;
            lciDatabase.CustomizationFormText = "Baza danych";
            lciDatabase.Location = new Point(0, 90);
            lciDatabase.Name = "lciDatabase";
            lciDatabase.Size = new Size(558, 36);
            lciDatabase.Text = "Baza danych";
            lciDatabase.TextSize = new Size(87, 19);
            // 
            // lciListOfDatabase
            // 
            lciListOfDatabase.Control = btnListOfDatabase;
            lciListOfDatabase.Location = new Point(558, 90);
            lciListOfDatabase.MaxSize = new Size(36, 36);
            lciListOfDatabase.MinSize = new Size(36, 36);
            lciListOfDatabase.Name = "lciListOfDatabase";
            lciListOfDatabase.Size = new Size(36, 36);
            lciListOfDatabase.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            lciListOfDatabase.TextSize = new Size(0, 0);
            lciListOfDatabase.TextVisible = false;
            // 
            // lciTestConnection
            // 
            lciTestConnection.Control = btnTestConnection;
            lciTestConnection.Location = new Point(0, 136);
            lciTestConnection.Name = "lciTestConnection";
            lciTestConnection.Size = new Size(297, 36);
            lciTestConnection.TextSize = new Size(0, 0);
            lciTestConnection.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(0, 172);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(594, 14);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            emptySpaceItem5.AllowHotTrack = false;
            emptySpaceItem5.Location = new Point(0, 126);
            emptySpaceItem5.Name = "emptySpaceItem5";
            emptySpaceItem5.Size = new Size(594, 10);
            emptySpaceItem5.TextSize = new Size(0, 0);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = btnConfirm;
            layoutControlItem1.Location = new Point(445, 136);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(149, 36);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // lcgButton
            // 
            lcgButton.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            lcgButton.GroupBordersVisible = false;
            lcgButton.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem3 });
            lcgButton.Name = "lcgButton";
            lcgButton.Size = new Size(142, 39);
            lcgButton.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new Point(0, 0);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new Size(142, 39);
            // 
            // DatabaseConnectionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 242);
            Controls.Add(gcDataBaseConnection);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DatabaseConnectionForm";
            Text = "Wstępna konfiguracja";
            ((System.ComponentModel.ISupportInitialize)gcDataBaseConnection).EndInit();
            gcDataBaseConnection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lcDatabaseConnection).EndInit();
            lcDatabaseConnection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cbDatabase.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tePassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teLogin.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teDataSource.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciDataSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciDatabase).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciListOfDatabase).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciTestConnection).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lcgButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcDataBaseConnection;
        private DevExpress.XtraLayout.LayoutControl lcDatabaseConnection;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teLogin;
        private DevExpress.XtraEditors.TextEdit teDataSource;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciDataSource;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciLogin;
        private DevExpress.XtraLayout.LayoutControlItem lciPassword;
        private DevExpress.XtraEditors.ComboBoxEdit cbDatabase;
        private DevExpress.XtraLayout.LayoutControlItem lciDatabase;
        private DevExpress.XtraEditors.SimpleButton btnTestConnection;
        private DevExpress.XtraEditors.SimpleButton btnListOfDatabase;
        private DevExpress.XtraLayout.LayoutControlItem lciListOfDatabase;
        private DevExpress.XtraLayout.LayoutControlItem lciTestConnection;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgButton;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}
