using Microsoft.EntityFrameworkCore;
using PlatigeImage.Data;
using PlatigeImage.Data.Entities;
using PlatigeImage.Dto.InvoicesPerContractor;
using PlatigeImage.Dto.NumberOfContractorsInCountryReport;
using PlatigeImage.Dto.TotalAmountPerMonth;
using PlatigeImage.Infrastructure.DataAccess.Base;

namespace PlatigeImage.Infrastructure.DataAccess.Contractors
{
    internal class ContractorRepository(ApplicationDbContext dbContext) : BaseRepository<Contractor>(dbContext), IContractorRepository
    {
        public async Task<IList<long>> GetIdsAsync()
        {
            return await GetAll()
                        .Select(x => x.Id)
                        .ToListAsync();
        }

        public async Task<List<InvoicesPerContractorDto>> GetInvoicesPerContractorAsync()
        {
            return await GetAll()
                .Include(c => c.Invoices)
                .Select(c => new InvoicesPerContractorDto
                {
                    ContractorId = c.Id,
                    ContractorName = c.Name,
                    Invoices = c.Invoices == null ? null : c.Invoices.Select(i => new InvoiceInfoDto
                    {
                        InvoiceId = i.Id,
                        InvoiceNumber = i.Number,
                        NetAmount = i.NetValues,
                        GrossAmount = i.GrossValue
                    }).ToList()//,
                    //TotalNetAmount = c.Invoices == null ? 0 : c.Invoices.Sum(i => i.NetValues),
                    //TotalGrossAmount = c.Invoices == null ? 0 : c.Invoices.Sum(i => i.GrossValue)
                })
                .ToListAsync();
        }

        public async Task<List<CountryContractorCountDto>> GetNumberOfContractorsInCountryAsync()
        {
            return await GetAll()
                .GroupBy(c => c.Country.Trim())
                .Select(g => new CountryContractorCountDto
                {
                    ContractorCount = g.Count(),
                    Country = g.Key
                })
                .ToListAsync();
        }
    }
}
