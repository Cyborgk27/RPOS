using RPOS.Domain.Domain;

namespace RPOS.Domain.Entities
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }
        public int MenuId { get; set; }

        public String? Name { get; set; }
        public String? Description { get; set; }
        public float? Price { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual MenuForDay MenuForDay { get; set; } = null!;
    }
}
