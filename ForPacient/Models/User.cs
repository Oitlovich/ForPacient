using System.Text.Json.Serialization;

namespace ForPacient.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public int MedCardId { get; set; }

        public MedCard MedCard { get; set; }
    }

}
