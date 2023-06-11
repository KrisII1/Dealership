using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CarsContext : IDb<Cars, int>
    {
        DealershipDBContext dbContext;

        public CarsContext(DealershipDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Cars item)
        {
            try
            {
                dbContext.Cars.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int key)
        {
            try
            {
                dbContext.Cars.Remove(dbContext.Cars.Find(key));
                dbContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Cars Read(int key, bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Cars> query = dbContext.Cars;
                if (useNavigationalProperties)
                {
                    query = query.Include(p => p.Clients);
                }
                return query.FirstOrDefault(p => p.Id == key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Cars> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Cars> query = dbContext.Cars;
                if (useNavigationalProperties)
                {
                    query = query.Include(p => p.Clients);
                }
                return query.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Cars item, bool useNavigationalProperties = false)
        {
            if (useNavigationalProperties)
            {
                Cars interestFromDb = Read(item.Id);

                if (interestFromDb != null)
                {
                    Create(item);
                    return;
                }

                interestFromDb.Model = item.Model;
                interestFromDb.Location = item.Location;

                dbContext.SaveChanges();
            }

        }
    }
}
