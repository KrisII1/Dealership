using DataLayer;

namespace ServiceLayer
{
    public static class ContextGenerator
    {
        public static DealershipDBContext dbContext;
        public static ClientContext clientContext;
        public static LocationContext locationContext;
        public static CarsContext carsContext;

        public static DealershipDBContext GetDbContext()
        {
            if (dbContext == null)
            {
                SetDbContext();
            }
            return dbContext;
        }

        public static void SetDbContext()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }

            dbContext = new DealershipDBContext();
        }
        public static ClientContext GetClientContext()
        {
            if (clientContext == null)
            {
                SetClientContext();
            }

            return clientContext;
        }
        public static void SetClientContext()
        {
            clientContext = new ClientContext(GetDbContext());
        }

        public static LocationContext GetLocationContext()
        {
            if (locationContext == null)
            {
                SetCarsContext();
            }

            return locationContext;
        }

        public static void SetCarsContext()
        {
            carsContext = new CarsContext(GetDbContext());
        }

        public static void GetSelectedCar()
        {
            carsContext = new CarsContext(GetDbContext());
        }
        public static CarsContext GetCarsContext()
        {
            if (carsContext == null)
            {
                SetCarsContext();
            }

            return carsContext;
        }
    

    }
}