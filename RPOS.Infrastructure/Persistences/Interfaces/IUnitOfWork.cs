namespace RPOS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork
    {
        //Declaración o matrícula de nuestras interfaces a nivel de repo
        ICategoryRepository Category { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
