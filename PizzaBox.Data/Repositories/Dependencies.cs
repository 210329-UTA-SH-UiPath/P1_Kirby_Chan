using PizzaBox.Data;
using PizzaBox.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Data.Repositories
{
    public static class Dependencies
    {
        public static ICrustRepository CreateCrustRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PizzaBox.Data.Entities.PizzaBoxContext>();
            optionsBuilder.UseSqlServer("Server=tcp:kirbyrevature.database.windows.net,1433;Initial Catalog=ProjectPizzaBoxDb;Persist Security Info=False;User ID=dev;Password=AzureMonkey1994;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            var dbContext = new PizzaBox.Data.Entities.PizzaBoxContext(optionsBuilder.Options);
            return new CrustRepository(dbContext);
        }

        public static ICustomerRepository CreateCustomerRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PizzaBox.Data.Entities.PizzaBoxContext>();
            optionsBuilder.UseSqlServer("Server=tcp:kirbyrevature.database.windows.net,1433;Initial Catalog=ProjectPizzaBoxDb;Persist Security Info=False;User ID=dev;Password=AzureMonkey1994;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            var dbContext = new PizzaBox.Data.Entities.PizzaBoxContext(optionsBuilder.Options);
            return new CustomerRepository(dbContext);
        }

        public static IOrderRepository CreateOrderRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PizzaBox.Data.Entities.PizzaBoxContext>();
            optionsBuilder.UseSqlServer("Server=tcp:kirbyrevature.database.windows.net,1433;Initial Catalog=ProjectPizzaBoxDb;Persist Security Info=False;User ID=dev;Password=AzureMonkey1994;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            var dbContext = new PizzaBox.Data.Entities.PizzaBoxContext(optionsBuilder.Options);
            return new OrderRepository(dbContext);
        }

        public static IPizzaRepository CreatePizzaRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PizzaBox.Data.Entities.PizzaBoxContext>();
            optionsBuilder.UseSqlServer("Server=tcp:kirbyrevature.database.windows.net,1433;Initial Catalog=ProjectPizzaBoxDb;Persist Security Info=False;User ID=dev;Password=AzureMonkey1994;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            var dbContext = new PizzaBox.Data.Entities.PizzaBoxContext(optionsBuilder.Options);
            return new PizzaRepository(dbContext);
        }

        public static IPresetPizzaRepository CreatePresetPizzaRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PizzaBox.Data.Entities.PizzaBoxContext>();
            optionsBuilder.UseSqlServer("Server=tcp:kirbyrevature.database.windows.net,1433;Initial Catalog=ProjectPizzaBoxDb;Persist Security Info=False;User ID=dev;Password=AzureMonkey1994;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            var dbContext = new PizzaBox.Data.Entities.PizzaBoxContext(optionsBuilder.Options);
            return new PresetPizzaRepository(dbContext);
        }
        public static ISizeRepository CreateSizeRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PizzaBox.Data.Entities.PizzaBoxContext>();
            optionsBuilder.UseSqlServer("Server=tcp:kirbyrevature.database.windows.net,1433;Initial Catalog=ProjectPizzaBoxDb;Persist Security Info=False;User ID=dev;Password=AzureMonkey1994;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            var dbContext = new PizzaBox.Data.Entities.PizzaBoxContext(optionsBuilder.Options);
            return new SizeRepository(dbContext);
        }
        public static IStoreRepository CreateStoreRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PizzaBox.Data.Entities.PizzaBoxContext>();
            optionsBuilder.UseSqlServer("Server=tcp:kirbyrevature.database.windows.net,1433;Initial Catalog=ProjectPizzaBoxDb;Persist Security Info=False;User ID=dev;Password=AzureMonkey1994;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            var dbContext = new PizzaBox.Data.Entities.PizzaBoxContext(optionsBuilder.Options);
            return new StoreRepository(dbContext);
        }
        public static IToppingRepository CreateToppingRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PizzaBox.Data.Entities.PizzaBoxContext>();
            optionsBuilder.UseSqlServer("Server=tcp:kirbyrevature.database.windows.net,1433;Initial Catalog=ProjectPizzaBoxDb;Persist Security Info=False;User ID=dev;Password=AzureMonkey1994;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            var dbContext = new PizzaBox.Data.Entities.PizzaBoxContext(optionsBuilder.Options);
            return new ToppingRepository(dbContext);
        }
    }
}