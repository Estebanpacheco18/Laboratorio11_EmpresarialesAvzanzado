namespace Laboratorio11_Empresariales.Infrastructure
{
    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>() where T : class;
        Task Complete();
    }
}