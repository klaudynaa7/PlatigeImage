namespace PlatigeImage.Dto.TotalAmountPerMonth
{
    public class MonthlyInvoiceSummaryDto
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal TotalNetAmount { get; set; }
        public decimal TotalGrossAmount { get; set; }
    }
}
