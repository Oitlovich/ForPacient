using System.ComponentModel.DataAnnotations;

namespace ForPacient.ViewModels
{
    public class RegistrationViewModel
    {
        [Required]
        public int Age { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        public int MedCardId { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }
    }
}
