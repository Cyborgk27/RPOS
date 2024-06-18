using RPOS.Domain.Domain;

namespace RPOS.Domain.Entities
{
    public class MenuForDay : BaseEntity
    {
        public MenuForDay() 
        {
            Products = new List<Product>();
        }
        public ICollection<Product> Products { get; set; } = null!;
    }
}
