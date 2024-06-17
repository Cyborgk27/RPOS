using RPOS.Domain.Domain;

namespace RPOS.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Category() 
        {
            Products = new List<Product>();
        }
        public String? Name { get; set; }
        public String? Description { get; set; }
        

        public ICollection<Product> Products { get; set; }
    }
}
