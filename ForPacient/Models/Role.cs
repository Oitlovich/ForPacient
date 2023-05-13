using System.Text.Json.Serialization;

namespace ForPacient.Models
{
    public class Role
    {
        public int Id { get; set; }

        public string Role_name { get; set; }

        [JsonIgnore]
        public List<User> Users { get; set; }
    }
}
