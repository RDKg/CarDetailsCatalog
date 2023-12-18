using CarCatalog.Data;
using CarCatalog.Repositories;

namespace CarCatalog
{
    internal static class Program
    {
        public static CarCatalogDbContext DbContext { get; } = new CarCatalogDbContext();

        public static BrandRepository BrandRepository = new BrandRepository(DbContext);
        public static CarRepository CarRepository = new CarRepository(DbContext);
        public static CartItemRepository CartItemRepository = new CartItemRepository(DbContext);
        public static DetailRepository DetailRepository = new DetailRepository(DbContext);
        public static CarDetailRepository CarDetailRepository = new CarDetailRepository(DbContext);
        public static TypeDetailRepository TypeDetailRepository = new TypeDetailRepository(DbContext);

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //DbContext.Database.EnsureDeleted();
            DbContext.Database.EnsureCreated();

            Application.Run(new CarCatalogForm());
        }
    }
}