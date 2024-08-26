using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlatigeImage.Data
{
    [Table("Invoice")]
    internal class Invoice
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public long ContractorId { get; set; }

        [ForeignKey("ContractorId")]
        public Contractor Contractor { get; set; }

        [Required]
        public string Numer { get; set; } = string.Empty;

        [Required]
        public decimal NetAmount { get; set; }

        [Required]
        public decimal VatRate { get; set; }

        [Required]
        public string Currency { get; set; } = string.Empty;

        [Required]
        public DateTime SaleDate { get; set; } = DateTime.Now;

        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
