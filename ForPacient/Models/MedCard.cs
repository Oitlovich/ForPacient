namespace ForPacient.Models
{
    public class MedCard
    {
        public int Id { get; set; }
        public string Disease { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }    

        public User User { get; set; }
    }
}
