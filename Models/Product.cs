namespace FiorelloApi.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Category CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
