using Microsoft.EntityFrameworkCore;
using PlatigeImage.BusinessLogic;
using PlatigeImage.Data;
using System.ComponentModel;

namespace PlatigeImage.Forms
{
    public partial class InvoiceForm : BaseForm
    {
        private readonly ApplicationDbContext _dbContext;

        public InvoiceForm(ApplicationDbContext dbContext) : base(dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FillContractor();
            _dbContext.Invoices.Include(c => c.Contractor).Load();
            bsInvoice.DataSource = this._dbContext.Invoices.Local.ToBindingList();
        }

        private void FillContractor()
        {
            if (DesignMode)
                return;

            //CommonBusinessLogic.FillContractor(riiceContractor.Items);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _dbContext!.SaveChanges();
            gridView.RefreshData();
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

            _dbContext?.Dispose();
        }
    }
}
