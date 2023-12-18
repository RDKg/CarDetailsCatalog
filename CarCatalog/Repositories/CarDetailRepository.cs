using CarCatalog.Data;

namespace CarCatalog.Repositories
{
    internal class CarDetailRepository : IRepository<CarDetail>
    {
        private readonly CarCatalogDbContext _dbContext;

        public CarDetailRepository(CarCatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<CarDetail> GetAll()
            => _dbContext.Set<CarDetail>();

        public CarDetail? GetById(int id)
            => _dbContext.Find<CarDetail>(id);

        public bool IsExistById(int id)
            => _dbContext.CarDetails.Any(b => b.Id == id);

        public void Create(CarDetail entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(CarDetail entity)
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
            var entity = _dbContext.Find<CarDetail>(id);

            if (entity != null)
                Delete(entity);
        }

        public void Delete(CarDetail entity)
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
