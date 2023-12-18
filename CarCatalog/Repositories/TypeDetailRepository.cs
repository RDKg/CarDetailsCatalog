using CarCatalog.Data;

namespace CarCatalog.Repositories
{
    internal class TypeDetailRepository : IRepository<TypeDetail>
    {
        private readonly CarCatalogDbContext _dbContext;

        public TypeDetailRepository(CarCatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<TypeDetail> GetAll() 
            => _dbContext.Set<TypeDetail>();
        
        public TypeDetail? GetById(int id) 
            => _dbContext.Find<TypeDetail>(id);

        public IEnumerable<TypeDetail> GetByIds(int[] ids)
            => _dbContext.TypeDetails.Where(item => ids.Contains(item.Id));

        public bool IsExistByName(string name)
            => _dbContext.TypeDetails.Any(b => b.Name == name);

        public void Create(TypeDetail entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(TypeDetail entity)
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
            var entity = _dbContext.Find<TypeDetail>(id);

            if (entity != null)
                Delete(entity);
        }

        public void Delete(TypeDetail entity)
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
