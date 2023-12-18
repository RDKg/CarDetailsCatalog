using CarCatalog.Data;

namespace CarCatalog.Repositories
{
    internal class CartItemRepository : IRepository<CartItem>
    {
        private readonly CarCatalogDbContext _dbContext;

        public CartItemRepository(CarCatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<CartItem> GetAll()
            => _dbContext.Set<CartItem>();

        public CartItem? GetById(int id)
            => _dbContext.Find<CartItem>(id);

        public CartItem? GetByCarDetail(CarDetail carDetail)
            => _dbContext.CartItems.Where(ci => ci.CarDetail.Id == carDetail.Id).FirstOrDefault();

        public IEnumerable<CartItem> GetByCarDetails(IEnumerable<CarDetail> carDetails)
            => _dbContext.CartItems.Where(ci => carDetails.Contains(ci.CarDetail));

        public bool IsExistByCarDetailId(int id)
            => _dbContext.CartItems.Any(b => b.CarDetail.Id == id);

        public void Create(CartItem entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(CartItem entity)
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
            var entity = _dbContext.Find<CartItem>(id);

            if (entity != null)
                Delete(entity);
        }

        public void Delete(CartItem entity)
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
