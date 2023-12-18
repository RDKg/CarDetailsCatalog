namespace CarCatalog.Repositories
{
    internal interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T? GetById(int id);

        void Create(T entity);

        void Update(T entity);

        void Delete(int id);
    }
}
