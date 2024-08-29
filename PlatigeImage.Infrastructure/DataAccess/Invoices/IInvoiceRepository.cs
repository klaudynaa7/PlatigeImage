using PlatigeImage.Data.Entities;
using PlatigeImage.Dto.TotalAmountPerMonth;
using PlatigeImage.Infrastructure.DataAccess.Base;
using System.ComponentModel;

namespace PlatigeImage.Infrastructure.DataAccess.Invoices
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        BindingList<Invoice> GetDataToBindingSource();
        Task<IList<MonthlyInvoiceSummaryDto>> GetTotalAmountPerMonth();
    }
}
