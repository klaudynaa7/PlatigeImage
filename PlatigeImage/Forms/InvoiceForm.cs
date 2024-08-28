using Microsoft.EntityFrameworkCore;
using PlatigeImage.BusinessLogic;
using PlatigeImage.Data;
using PlatigeImage.Infrastructure.Connection;
using System.ComponentModel;

namespace PlatigeImage.Forms
{
    public partial class InvoiceForm : BaseForm
    {        
        ConnectionDetails _connectionInfo = ConnectionDetails.GetInstance();
        private ApplicationDbContext? _dbContext;

        public InvoiceForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FillContractor();            
            this._dbContext = new ApplicationDbContext(_connectionInfo.GetConnectionString());
            this._dbContext.Invoices.Include(c => c.Contractor).Load();
            this.bsInvoice.DataSource = this._dbContext.Invoices.Local.ToBindingList();
        }

        private void FillContractor()
        {
            if (DesignMode)
                return;

            CommonBusinessLogic.FillContractor(riiceContractor.Items);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this._dbContext!.SaveChanges();
            this.gridView.RefreshData();
        }

        protected override void GenerateData()
        {
            var invoices = InvoiceBusinessLogic.GenerateIvoices(InputValue);
            if (invoices == null)
                return;

            foreach (var contractor in invoices)
                bsInvoice.Add(contractor);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this._dbContext?.Dispose();
            this._dbContext = null;
        }
    }
}
