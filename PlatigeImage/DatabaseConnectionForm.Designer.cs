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
            ceIntegratedSecurity = new DevExpress.XtraEditors.CheckEdit();
            btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            btnTestConnection = new DevExpress.XtraEditors.SimpleButton();
            btnListOfDatabase = new DevExpress.XtraEditors.SimpleButton();
            cbDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            tePassword = new DevExpress.XtraEditors.TextEdit();
            teUserId = new DevExpress.XtraEditors.TextEdit();
            teServer = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            lciServer = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            lciUserId = new DevExpress.XtraLayout.LayoutControlItem();
            lciPassword = new DevExpress.XtraLayout.LayoutControlItem();
            lciDatabase = new DevExpress.XtraLayout.LayoutControlItem();
            lciListOfDatabase = new DevExpress.XtraLayout.LayoutControlItem();
            lciTestConnection = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            lciConfirmButton = new DevExpress.XtraLayout.LayoutControlItem();
            lciIntegratedSecurity = new DevExpress.XtraLayout.LayoutControlItem();
            lcgButton = new DevExpress.XtraLayout.LayoutControlGroup();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)gcDataBaseConnection).BeginInit();
            gcDataBaseConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lcDatabaseConnection).BeginInit();
            lcDatabaseConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ceIntegratedSecurity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbDatabase.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tePassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teUserId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teServer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciServer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciUserId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciDatabase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciListOfDatabase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciTestConnection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciConfirmButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciIntegratedSecurity).BeginInit();
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
            gcDataBaseConnection.Size = new Size(618, 324);
            gcDataBaseConnection.TabIndex = 0;
            gcDataBaseConnection.Text = "BAZA DANYCH";
            // 
            // lcDatabaseConnection
            // 
            lcDatabaseConnection.Controls.Add(ceIntegratedSecurity);
            lcDatabaseConnection.Controls.Add(btnConfirm);
            lcDatabaseConnection.Controls.Add(btnTestConnection);
            lcDatabaseConnection.Controls.Add(btnListOfDatabase);
            lcDatabaseConnection.Controls.Add(cbDatabase);
            lcDatabaseConnection.Controls.Add(tePassword);
            lcDatabaseConnection.Controls.Add(teUserId);
            lcDatabaseConnection.Controls.Add(teServer);
            lcDatabaseConnection.Dock = DockStyle.Fill;
            lcDatabaseConnection.Location = new Point(2, 34);
            lcDatabaseConnection.Name = "lcDatabaseConnection";
            lcDatabaseConnection.Root = Root;
            lcDatabaseConnection.Size = new Size(614, 288);
            lcDatabaseConnection.TabIndex = 0;
            lcDatabaseConnection.Text = "layoutControl1";
            // 
            // ceIntegratedSecurity
            // 
            ceIntegratedSecurity.Location = new Point(12, 138);
            ceIntegratedSecurity.Name = "ceIntegratedSecurity";
            ceIntegratedSecurity.Properties.Caption = "Uwierzytelnianie Windows";
            ceIntegratedSecurity.Size = new Size(590, 27);
            ceIntegratedSecurity.StyleController = lcDatabaseConnection;
            ceIntegratedSecurity.TabIndex = 7;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(457, 234);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(145, 32);
            btnConfirm.StyleController = lcDatabaseConnection;
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Potwierdź";
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(12, 234);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(293, 32);
            btnTestConnection.StyleController = lcDatabaseConnection;
            btnTestConnection.TabIndex = 6;
            btnTestConnection.Text = "Testuj połączenie";
            btnTestConnection.Click += btnTestConnection_Click;
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
            // teUserId
            // 
            teUserId.Location = new Point(111, 42);
            teUserId.Name = "teUserId";
            teUserId.Size = new Size(491, 26);
            teUserId.StyleController = lcDatabaseConnection;
            teUserId.TabIndex = 2;
            // 
            // teServer
            // 
            teServer.Location = new Point(111, 12);
            teServer.Name = "teServer";
            teServer.Size = new Size(491, 26);
            teServer.StyleController = lcDatabaseConnection;
            teServer.TabIndex = 0;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { lciServer, emptySpaceItem1, lciUserId, lciPassword, lciDatabase, lciListOfDatabase, lciTestConnection, emptySpaceItem2, emptySpaceItem5, lciConfirmButton, lciIntegratedSecurity });
            Root.Name = "Root";
            Root.Size = new Size(614, 288);
            Root.TextVisible = false;
            // 
            // lciServer
            // 
            lciServer.Control = teServer;
            lciServer.CustomizationFormText = "Serwer";
            lciServer.Location = new Point(0, 0);
            lciServer.Name = "lciServer";
            lciServer.Size = new Size(594, 30);
            lciServer.Text = "Serwer";
            lciServer.TextSize = new Size(87, 19);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(297, 222);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(148, 36);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // lciUserId
            // 
            lciUserId.Control = teUserId;
            lciUserId.CustomizationFormText = "Login";
            lciUserId.Location = new Point(0, 30);
            lciUserId.Name = "lciUserId";
            lciUserId.Size = new Size(594, 30);
            lciUserId.Text = "Login";
            lciUserId.TextSize = new Size(87, 19);
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
            lciTestConnection.Location = new Point(0, 222);
            lciTestConnection.Name = "lciTestConnection";
            lciTestConnection.Size = new Size(297, 36);
            lciTestConnection.TextSize = new Size(0, 0);
            lciTestConnection.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(0, 258);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(594, 10);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            emptySpaceItem5.AllowHotTrack = false;
            emptySpaceItem5.Location = new Point(0, 157);
            emptySpaceItem5.Name = "emptySpaceItem5";
            emptySpaceItem5.Size = new Size(594, 65);
            emptySpaceItem5.TextSize = new Size(0, 0);
            // 
            // lciConfirmButton
            // 
            lciConfirmButton.Control = btnConfirm;
            lciConfirmButton.Location = new Point(445, 222);
            lciConfirmButton.Name = "lciConfirmButton";
            lciConfirmButton.Size = new Size(149, 36);
            lciConfirmButton.TextSize = new Size(0, 0);
            lciConfirmButton.TextVisible = false;
            // 
            // lciIntegratedSecurity
            // 
            lciIntegratedSecurity.Control = ceIntegratedSecurity;
            lciIntegratedSecurity.CustomizationFormText = "Uwierzytelnianie Windows";
            lciIntegratedSecurity.Location = new Point(0, 126);
            lciIntegratedSecurity.Name = "lciIntegratedSecurity";
            lciIntegratedSecurity.Size = new Size(594, 31);
            lciIntegratedSecurity.Text = "Uwierzytelnianie Windows";
            lciIntegratedSecurity.TextSize = new Size(0, 0);
            lciIntegratedSecurity.TextVisible = false;
            // 
            // lcgButton
            // 
            lcgButton.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            lcgButton.GroupBordersVisible = false;
            lcgButton.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem3 });
            lcgButton.Location = new Point(0, 0);
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
            emptySpaceItem3.TextSize = new Size(0, 0);
            // 
            // DatabaseConnectionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 324);
            Controls.Add(gcDataBaseConnection);
            MaximizeBox = false;
            MaximumSize = new Size(640, 380);
            MinimizeBox = false;
            MinimumSize = new Size(640, 380);
            Name = "DatabaseConnectionForm";
            Text = "Wstępna konfiguracja";
            ((System.ComponentModel.ISupportInitialize)gcDataBaseConnection).EndInit();
            gcDataBaseConnection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lcDatabaseConnection).EndInit();
            lcDatabaseConnection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ceIntegratedSecurity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbDatabase.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tePassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teUserId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teServer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciServer).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciUserId).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciDatabase).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciListOfDatabase).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciTestConnection).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciConfirmButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciIntegratedSecurity).EndInit();
            ((System.ComponentModel.ISupportInitialize)lcgButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcDataBaseConnection;
        private DevExpress.XtraLayout.LayoutControl lcDatabaseConnection;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teUserId;
        private DevExpress.XtraEditors.TextEdit teServer;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciServer;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciUserId;
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
        private DevExpress.XtraLayout.LayoutControlItem lciConfirmButton;
        private DevExpress.XtraLayout.LayoutControlGroup lcgButton;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.CheckEdit ceIntegratedSecurity;
        private DevExpress.XtraLayout.LayoutControlItem lciIntegratedSecurity;
    }
}
