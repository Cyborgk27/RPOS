using RPOS.Domain.Domain;

namespace RPOS.Domain.Entities
{
    public class MenuForDay : BaseEntity
    {
        public MenuForDay() 
        {
            Products = new List<Product>();
        }
        public virtual ICollection<Product> Products { get; set; } = null!;
    }
}
