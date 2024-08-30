using PlatigeImage.Data.Entities;
using PlatigeImage.Data;
using PlatigeImage.Infrastructure.DataAccess.Base;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.Dto.TotalAmountPerMonth;
using System.Globalization;
using PlatigeImage.Dto.InvoicesPerContractor;

namespace PlatigeImage.Infrastructure.DataAccess.Invoices
{
    internal class InvoiceRepository(ApplicationDbContext dbContext) : BaseRepository<Invoice>(dbContext), IInvoiceRepository
    {
        public async Task<IList<MonthlyInvoiceSummaryDto>> GetTotalAmountPerMonth()
        {
            return await GetAll()
                .GroupBy(i => new { i.SaleDate.Year, i.SaleDate.Month})
                .Select(g => new MonthlyInvoiceSummaryDto
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    MonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(g.Key.Month),
                    TotalNetAmount = g.Sum(i => i.NetValues),
                    TotalGrossAmount = g.Sum(i => i.GrossValue)
                })
                .OrderBy(s => s.Year)
                .ThenBy(s => s.Month)
                .ToListAsync();
        }

        public async Task<List<InvoicesPerContractorDto>> GetInvoicesPerContractorAsync()
        {
            return await GetAll()
                .Include(x => x.Contractor)
                .Select(x => new InvoicesPerContractorDto
                {
                    InvoiceId = x.Id,
                    InvoiceNumber = x.Number,
                    NetAmount = x.NetValues,
                    GrossAmount = x.GrossValue,
                    Contractors = x.Contractor == null ? null : new ContractorInfoDto
                    {
                        ContractorId = x.ContractorId,
                        ContractorName = x.Contractor.Name,
                        Country = x.Contractor.Country
                    }
                })
                .ToListAsync();
        }
    }
}
