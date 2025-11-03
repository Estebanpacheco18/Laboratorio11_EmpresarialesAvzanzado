namespace Laboratorio11_Empresariales.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void AddEntity(T entity);
        Task<T?> GetByIdAsync(Guid id);
    }
}