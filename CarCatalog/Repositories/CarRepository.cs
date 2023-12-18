using CarCatalog.Data;

namespace CarCatalog.Repositories
{
    internal class CarRepository : IRepository<Car>
    {
        private readonly CarCatalogDbContext _dbContext;

        public CarRepository(CarCatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Car> GetAll()
            => _dbContext.Set<Car>();

        public Car? GetById(int id)
            => _dbContext.Find<Car>(id);

        public bool IsExistByBrandAndModel(string model, string brand)
            => _dbContext.Cars.Any(b => b.Model == model && b.Brand.Name == brand);

        public void Create(Car entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Car entity)
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
            var entity = _dbContext.Find<Car>(id);

            if (entity != null)
                Delete(entity);
        }

        public void Delete(Car entity)
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
