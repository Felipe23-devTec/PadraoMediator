namespace PadraoMadiatorAprendendo.Repository
{
    public interface IRepository<T>
    {
        Task<IList<T>> GetAll();

        Task<T> Get(int id);

        Task Add(T item);

        Task Edit(T item);

        Task Delete(int id);
    }
}
