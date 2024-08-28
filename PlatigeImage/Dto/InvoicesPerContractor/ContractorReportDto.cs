namespace PlatigeImage.Dto.InvoicesPerContractor
{
    public class MonthlyInvoiceSummary
    {
        public long ContractorId { get; set; }
        public string ContractorName { get; set; }
        public string Country { get; set; }
        public List<InvoiceInfoDto> Invoices { get; set; }
        public decimal TotalNetAmount { get; set; }
        public decimal TotalGrossAmount { get; set; }
    }
}
