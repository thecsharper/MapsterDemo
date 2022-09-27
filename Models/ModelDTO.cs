namespace MapsterDemo.Models
{
    public class ModelDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public string Email { get; set; } = null!;
        public string CreatedAt { get; set; } = null!;

        public Address PostalAddress { get; set; }
    }
}
