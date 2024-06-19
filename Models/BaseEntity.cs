namespace FiorelloApi.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool SoftDelete { get; set; }
    }
}
