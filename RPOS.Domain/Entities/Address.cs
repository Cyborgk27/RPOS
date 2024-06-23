namespace RPOS.Domain.Entities
{
    public class Address : BaseEntity
    {
        public int RestaurantId { get; set; }
        public string? FirstStreet { get; set; }
        public string? SecondStreet { get; set; }

        public virtual Restaurant Restaurant { get; set; } = null!;
    }
}
