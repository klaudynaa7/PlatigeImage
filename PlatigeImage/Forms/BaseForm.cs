﻿using PlatigeImage.BusinessLogic;

namespace PlatigeImage.Forms
{
    public partial class BaseForm : Form
    {
        public int InputValue { get; private set; } 
        //private ApplicationDbContext dbContext;
        //private ConnectionDetails _connectionInfo = ConnectionDetails.GetInstance();

        //public ApplicationDbContext DbContext { get { return dbContext; } }
        public BaseForm()
        {
            InitializeComponent();
            //this.dbContext = new ApplicationDbContext(_connectionInfo.GetConnectionString());
        }

        //private void btnConfirm_Click(object sender, EventArgs e)
        //{
        //    //this.dbContext!.SaveChanges();
        //    //this.gridView.RefreshData();
        //}

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportData exportData = new ExportData();
            exportData.Run(gridView);
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                gridView.DeleteSelectedRows();
            }
        }

        private void btnGenerateData_Click(object sender, EventArgs e)
        {
            using (var inputForm = new NumberOfDataToGenerateForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    if (inputForm.InputValue > 0)
                    {
                        InputValue = inputForm.InputValue;
                        GenerateData();
                    }
                    else
                        MessageBox.Show("Proszę wprowadzić poprawną liczbę.");
                }
            }
        }

        protected virtual void GenerateData()
        {
            //
        }


        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    base.OnClosing(e);

        //this.dbContext?.Dispose();
        //this.dbContext = null;
        //}
    }
}
