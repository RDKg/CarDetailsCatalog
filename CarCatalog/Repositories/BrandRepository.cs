using CarCatalog.Data;

namespace CarCatalog.Repositories
{
    internal class BrandRepository : IRepository<Brand>
    {
        private readonly CarCatalogDbContext _dbContext;

        public BrandRepository(CarCatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Brand> GetAll()
            => _dbContext.Set<Brand>();

        public Brand? GetById(int id)
            => _dbContext.Find<Brand>(id);

        public bool IsExistByName(string name)
            => _dbContext.Brands.Any(b => b.Name == name);

        public void Create(Brand entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Brand entity)
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
            var entity = _dbContext.Find<Brand>(id);

            if (entity != null)
                Delete(entity);
        }

        public void Delete(Brand entity)
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
