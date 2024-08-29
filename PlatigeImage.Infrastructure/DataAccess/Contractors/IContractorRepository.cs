using PlatigeImage.Data.Entities;
using PlatigeImage.Dto.InvoicesPerContractor;
using PlatigeImage.Dto.NumberOfContractorsInCountryReport;
using PlatigeImage.Infrastructure.DataAccess.Base;
using System.ComponentModel;

namespace PlatigeImage.Infrastructure.DataAccess.Contractors
{
    public interface IContractorRepository : IRepository<Contractor>
    {
        BindingList<Contractor> GetDataToBindingSource();
        Task<IList<long>> GetIdsAsync();

        Task<List<CountryContractorCountDto>> GetNumberOfContractorsInCountryAsync();
        Task<List<MonthlyInvoiceSummary>> GetInvoicesPerContractorAsync();
        
    }
}
