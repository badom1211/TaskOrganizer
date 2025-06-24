using System.ComponentModel.DataAnnotations;

namespace TaskOrganizer.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ime klijenta je obavezno")]
        public required string Name { get; set; }

        [EmailAddress(ErrorMessage = "Neispravan format emaila")]
        public string? Email { get; set; } // Nullable
    }
}