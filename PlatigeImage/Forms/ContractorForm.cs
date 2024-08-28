using Microsoft.EntityFrameworkCore;
using PlatigeImage.BusinessLogic;
using PlatigeImage.Data;
using PlatigeImage.Data.Entities;
using PlatigeImage.Infrastructure.Connection;
using System.ComponentModel;

namespace PlatigeImage.Forms
{
    public partial class ContractorForm : BaseForm
    {
        private ApplicationDbContext? dbContext;
        ConnectionDetails _connectionInfo = ConnectionDetails.GetInstance();

        public ContractorForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FillComboBox();
            this.dbContext = new ApplicationDbContext(_connectionInfo.GetConnectionString());
            this.dbContext.Contractors.Load();
            this.bsContractor.DataSource = this.dbContext.Contractors.Local.ToBindingList();
        }

        private void FillComboBox()
        {
            if (DesignMode)
                return;

            CommonBusinessLogic.FillType(riiceType.Items);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();
            this.gridView.RefreshData();
        }

        protected override void GenerateData()
        {
            List<Contractor>? contractors = ContractorBusinessLogic.GenerateContractors(InputValue);
            if (contractors == null)
                return;

            foreach (var contractor in contractors)
                bsContractor.Add(contractor);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }
    }
}
