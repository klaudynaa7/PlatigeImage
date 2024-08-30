using Microsoft.EntityFrameworkCore;
using PlatigeImage.Data;
using PlatigeImage.Data.Entities;
using PlatigeImage.Dto.NumberOfContractorsInCountryReport;
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
