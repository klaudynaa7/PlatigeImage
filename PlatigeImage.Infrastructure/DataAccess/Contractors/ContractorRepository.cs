using Microsoft.EntityFrameworkCore;
using PlatigeImage.Data;
using PlatigeImage.Data.Entities;
using PlatigeImage.Dto.InvoicesPerContractor;
using PlatigeImage.Dto.NumberOfContractorsInCountryReport;
using PlatigeImage.Dto.TotalAmountPerMonth;
using PlatigeImage.Infrastructure.DataAccess.Base;
using System.ComponentModel;

namespace PlatigeImage.Infrastructure.DataAccess.Contractors
{
    internal class ContractorRepository(ApplicationDbContext dbContext) : BaseRepository<Contractor>(dbContext), IContractorRepository
    {
        private void LoadData()
            => DbContext.Contractors.Load();
        

        public BindingList<Contractor> GetDataToBindingSource()
        {
            LoadData();
            return DbContext.Contractors.Local.ToBindingList();
        }

        public async Task<IList<long>> GetIdsAsync()
        {
            return await DbContext.Set<Contractor>()
                        .Select(x => x.Id)
                        .ToListAsync();
        }

        public async Task<List<CountryContractorCountDto>> GetNumberOfContractorsInCountryAsync()
        {
            return await GetAllAsync()
                .GroupBy(c => c.Country)
                .Select(g => new CountryContractorCountDto
                {
                    ContractorCount = g.Count(),
                    Country = g.Key
                })
                .ToListAsync();
        }

        public async Task<List<MonthlyInvoiceSummary>> GetInvoicesPerContractorAsync()
        {
            return await GetAllAsync()
                .Include(c => c.Invoices)
                .Select(c => new MonthlyInvoiceSummary
                {
                    ContractorId = c.Id,
                    ContractorName = c.Name,
                    Country = c.Country,
                    Invoices = c.Invoices.Select(i => new InvoiceInfoDto
                    {
                        InvoiceId = i.Id,
                        NetAmount = i.NetValues,
                        GrossAmount = i.GrossValue
                    }).ToList(),
                    TotalNetAmount = c.Invoices.Sum(i => i.NetValues),
                    TotalGrossAmount = c.Invoices.Sum(i => i.GrossValue)
                })
                .ToListAsync();
        }
    }
}
