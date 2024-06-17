using RPOS.Domain.Domain;

namespace RPOS.Domain.Entities
{
    public class Product : BaseEntity
    {
        public String? Name { get; set; }
        public String? Description { get; set; }
        public float? Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
