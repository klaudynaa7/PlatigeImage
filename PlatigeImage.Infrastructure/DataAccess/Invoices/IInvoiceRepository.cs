using PlatigeImage.Data.Entities;
using PlatigeImage.Dto.InvoicesPerContractor;
using PlatigeImage.Dto.TotalAmountPerMonth;
using PlatigeImage.Infrastructure.DataAccess.Base;

namespace PlatigeImage.Infrastructure.DataAccess.Invoices
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        Task<IList<MonthlyInvoiceSummaryDto>> GetTotalAmountPerMonth();
        Task<List<InvoicesPerContractorDto>> GetInvoicesPerContractorAsync();
    }
}
