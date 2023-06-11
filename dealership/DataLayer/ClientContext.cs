using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ClientContext : IDb<Client, int>
    {
        DealershipDBContext dbContext;

        public ClientContext(DealershipDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Client item)
        {
            try
            {
                dbContext.Clients.Add(item);
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
                dbContext.Clients.Remove(dbContext.Clients.Find(key));
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
        }        }

        public Client Read(int key, bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Client> query = dbContext.Clients;
                if(useNavigationalProperties)
                {
                    query = query.Include(p => p.Cars);
                }
                return query.FirstOrDefault(p => p.ID == key);
            }
            catch (Exception)
            {

                throw;
            }        
        }

        public IEnumerable<Client> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Client> query = dbContext.Clients;
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

        public void Update(Client item, bool useNavigationalProperties = false)
        {
            try
            {
                if (useNavigationalProperties)
                {
                    Client userFromDb = Read(item.ID);

                    if (userFromDb == null)
                    {
                        Create(item);
                        return;
                    }

                    userFromDb.FirstName = item.FirstName;
                    userFromDb.LastName = item.LastName;
                    userFromDb.Age = item.Age;
                    userFromDb.Email = item.Email;


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
