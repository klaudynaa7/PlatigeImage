using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlatigeImage.Data
{
    [Table("Contractor")]
    internal class Contractor
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public byte Type { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Name must not be longer than 100 characters")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(20, ErrorMessage = "Shortcut must not be longer than 20 characters")]
        public string Shortcut { get; set; } = string.Empty;

        [Required]
        [MaxLength(20, ErrorMessage = "Country must not be longer than 20 characters")]
        public string Country { get; set; } = string.Empty;

        [Required]
        [MaxLength(500, ErrorMessage = "Address must not be longer than 500 characters")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(11, ErrorMessage = "NIP must not be longer than 11 characters")]
        public string NIP { get; set; } = string.Empty;

        [Required]
        public bool IsActive { get; set; } = true;

        public ICollection<Invoice>? Invoices { get; set; }
    }
}
