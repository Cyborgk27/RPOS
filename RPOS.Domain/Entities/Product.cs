using System.Security.Cryptography.X509Certificates;

namespace RPOS.Domain.Entities
{
    public class Product : BaseEntity
    {
        public int RestaurantId {  get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }= string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Price { get; set; }

        public virtual Restaurant Restaurant { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;
    }
}
