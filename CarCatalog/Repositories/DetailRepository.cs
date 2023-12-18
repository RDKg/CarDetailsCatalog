using CarCatalog.Data;

namespace CarCatalog.Repositories
{
    internal class DetailRepository : IRepository<Detail>
    {
        private readonly CarCatalogDbContext _dbContext;

        public DetailRepository(CarCatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Detail> GetAll()
            => _dbContext.Set<Detail>();

        public Detail? GetById(int id)
            => _dbContext.Find<Detail>(id);

        public void Create(Detail entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Detail entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _dbContext.Find<Detail>(id);

            if (entity != null)
                Delete(entity);
        }

        public void Delete(Detail entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
