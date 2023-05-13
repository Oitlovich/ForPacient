namespace ForPacient.Models
{
    public class Role
    {
        public int Id { get; set; }

        public string Role_name { get; set; }

        public List<User> Users { get; set; }
    }
}
