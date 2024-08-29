using Microsoft.EntityFrameworkCore;
using PlatigeImage.BusinessLogic;
using PlatigeImage.Data;
using PlatigeImage.Data.Entities;
using System.ComponentModel;

namespace PlatigeImage.Forms
{
    public partial class ContractorForm : BaseForm
    {
        private readonly ApplicationDbContext _dbContext;

        public ContractorForm(ApplicationDbContext dbContext) : base(dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FillComboBox();
            _dbContext.Contractors.Load();
            bsContractor.DataSource = this._dbContext.Contractors.Local.ToBindingList();
        }

        private void FillComboBox()
        {
            if (DesignMode)
                return;

            CommonBusinessLogic.FillType(riiceType.Items);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _dbContext.SaveChanges();
            gridView.RefreshData();
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

            _dbContext.Dispose();
        }
    }
}
