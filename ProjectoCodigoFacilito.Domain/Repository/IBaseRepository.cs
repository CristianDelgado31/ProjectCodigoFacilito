namespace ProjectoCodigoFacilito.Domain.Repository;

public interface IBaseRepository<T>
{
    public IUnitOfWork UnitOfWork { get; }
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> CreateAsync(T entity);
    Task<int> DeleteAsync(int id);
}