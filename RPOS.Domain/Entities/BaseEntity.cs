namespace RPOS.Domain.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public int AuditCreateUserId { get; set; }
        public DateTime AuditCreateDate { get; set; }
        public int AuditUpdateUserId { get; set; }
        public DateTime AuditUpdateDate { get; set; }
        public int AuditDeleteUserId { get; set; }
        public DateTime AuditDeleteDate { get; set; }
        public int State { get; set; }
    }
}
