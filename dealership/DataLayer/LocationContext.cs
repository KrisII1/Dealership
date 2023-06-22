using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LocationContext : IDb<Location, int>
    {
        DealershipDBContext dbContext;

        public LocationContext(DealershipDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Location item)
        {
            try
            {
                dbContext.Locations.Add(item);
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
                dbContext.Locations.Remove(dbContext.Locations.Find(key));
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Location Read(int key, bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Location> query = dbContext.Locations;
                if (useNavigationalProperties)
                {
                    query = query.Include(p => p.Cars);
                }
                return query.FirstOrDefault(p => p.Id == key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Location> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Location> query = dbContext.Locations;
                if (useNavigationalProperties)
                {
                    query = query.Include(p => p.Cars);
                }
                return query.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Location item, bool useNavigationalProperties = false)
        {
            try
            {
                if (useNavigationalProperties)
                {
                    Location nameFromDB = Read(item.Id);

                    if (nameFromDB == null)
                    {
                        Create(item);
                        return;
                    }

                    nameFromDB.Name = item.Name;
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}