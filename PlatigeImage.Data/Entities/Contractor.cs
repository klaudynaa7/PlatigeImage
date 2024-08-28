using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlatigeImage.Data.Entities
{
    [Table("Contractor")]
    public class Contractor : BaseEntity
    {
        public required byte Type { get; set; }

        public required string Name { get; set; }

        [MaxLength(20, ErrorMessage = "Shortcut must not be longer than 20 characters")]
        public string Shortcut { get; set; } = string.Empty;

        public string Country { get; set; } = " PL";

        public string Address { get; set; } = string.Empty;

        [MaxLength(11, ErrorMessage = "NIP must not be longer than 11 characters")]
        public string? NIP { get; set; }

        public bool IsActive { get; set; } = true;

        public ICollection<Invoice>? Invoices { get; set; }
    }
}
