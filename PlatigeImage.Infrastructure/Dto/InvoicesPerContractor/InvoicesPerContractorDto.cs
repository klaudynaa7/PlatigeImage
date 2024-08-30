namespace PlatigeImage.Dto.InvoicesPerContractor
{
    public class InvoicesPerContractorDto
    {
        public long InvoiceId { get; set; }
        public string? InvoiceNumber { get; set; }
        public decimal NetAmount { get; set; }
        public decimal GrossAmount { get; set; }
        public ContractorInfoDto? Contractors { get; set; }
    }
}
