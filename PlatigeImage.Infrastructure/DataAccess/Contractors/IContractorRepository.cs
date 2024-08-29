using PlatigeImage.Data.Entities;
using PlatigeImage.Dto.InvoicesPerContractor;
using PlatigeImage.Dto.NumberOfContractorsInCountryReport;
using PlatigeImage.Infrastructure.DataAccess.Base;

namespace PlatigeImage.Infrastructure.DataAccess.Contractors
{
    public interface IContractorRepository : IRepository<Contractor>
    {
        Task<IList<long>> GetIdsAsync();
        Task<List<CountryContractorCountDto>> GetNumberOfContractorsInCountryAsync();
        Task<List<InvoicesPerContractorDto>> GetInvoicesPerContractorAsync();
        
    }
}
