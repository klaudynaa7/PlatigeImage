using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlatigeImage.Data.Entities
{
    [Table("Invoice")]
    public class Invoice : BaseEntity
    {
        public required long ContractorId { get; set; }

        public virtual Contractor? Contractor { get; set; }

        public required string Number { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public required decimal NetValues { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public required decimal GrossValue { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public required decimal Vat { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public required decimal VatRate { get; set; }

        public string Currency { get; set; } = "PLN";

        public DateTime SaleDate { get; set; } = DateTime.Now;

        public string Description { get; set; } = string.Empty;
    }
}