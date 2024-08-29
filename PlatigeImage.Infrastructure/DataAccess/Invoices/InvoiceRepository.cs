using PlatigeImage.Data.Entities;
using PlatigeImage.Data;
using PlatigeImage.Infrastructure.DataAccess.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using PlatigeImage.Dto.TotalAmountPerMonth;

namespace PlatigeImage.Infrastructure.DataAccess.Invoices
{
    internal class InvoiceRepository(ApplicationDbContext dbContext) : BaseRepository<Invoice>(dbContext), IInvoiceRepository
    {
        private void LoadData()
        {
            DbContext.Invoices.Load();
        }

        public BindingList<Invoice> GetDataToBindingSource()
        {
            LoadData();
            return DbContext.Invoices.Local.ToBindingList();
        }

        public async Task<IList<MonthlyInvoiceSummaryDto>> GetTotalAmountPerMonth()
        {
            return /*await GetAllAsync()*/
                await DbContext.Set<Invoice>()
                .GroupBy(i => new { i.SaleDate.Year, i.SaleDate.Month })
                .Select(g => new MonthlyInvoiceSummaryDto
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    TotalNetAmount = g.Sum(i => i.NetValues),
                    TotalGrossAmount = g.Sum(i => i.GrossValue)
                })
                .OrderBy(s => s.Year)
                .ThenBy(s => s.Month)
                .ToListAsync();
        }
    }
}
