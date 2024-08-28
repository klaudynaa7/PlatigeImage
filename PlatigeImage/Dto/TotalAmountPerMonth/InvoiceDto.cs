namespace PlatigeImage.Dto.TotalAmountPerMonth
{
    public class InvoiceDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal NetAmount { get; set; }
        public decimal GrossAmount { get; set; }
    }
}
