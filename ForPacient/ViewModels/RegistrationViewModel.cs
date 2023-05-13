using System.ComponentModel.DataAnnotations;

namespace ForPacient.ViewModels
{
    public class RegistrationViewModel
    {
        [Required]
        [MinLength(6)]
        public int Age { get; set; }
        [Required]
        [MinLength(6)]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        public string Phone { get; set; }
        [Required]
        [MinLength(6)]
        public string RoleId { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        [Required]
        [MinLength(2)]
        public string Firstname { get; set; }
        [Required]
        [MinLength(2)]
        public string Lastname { get; set; }
    }
}
