namespace RPOS.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Category() => Products = [];

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public virtual ICollection<Product> Products { get; set; }
    }
}
