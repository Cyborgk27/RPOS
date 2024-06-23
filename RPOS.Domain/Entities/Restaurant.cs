namespace RPOS.Domain.Entities
{
    public class Restaurant : BaseEntity
    {
        public Restaurant() => Products = [];

        public String? Email { get; set; }
        public string? Name { get; set; }
        public float Rating { get; set; }

        public virtual Address Address { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; }
    }
}
