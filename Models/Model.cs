namespace MapsterDemo.Models
{
    public class Model
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = null!;
        
        public bool IsActive { get; set; }
        
        public string Email { get; set; } = null!;
        
        public DateTime CreatedAt { get; set; }
        
        public Address? Address { get; set; } 
    }
}
