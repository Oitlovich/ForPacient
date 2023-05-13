using System.Text.Json.Serialization;

namespace ForPacient.Models
{
    public class MedCard
    {
        public int Id { get; set; }

        public string Disease { get; set; }

        public string Anamnez { get; set; }

        public string Results { get; set; }

        public string Recommends { get; set; }

        public string Drugs { get; set; }

        [JsonIgnore]
        public List<User> User { get; set; }
    }
}
