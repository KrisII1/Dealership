using BusinessLayer;
using DataLayer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLayer
{
  
        [TestFixture]
        public class ClientContextTest
        {
            private ClientContext context = new ClientContext(SetupFixture.dbContext);
            private Client u3;
            private Cars car1, car2;




            [SetUp]
            public void CreateClient()
            {
                u3 = new Client("ivan", "Ivanov", 24, "ivanivanov@abv.bg");


                Location Plovdiv = new Location("Plovdiv");
                car1 = new Cars("lambo", Plovdiv);
                car2 = new Cars("Porsche", Plovdiv);

                u3.Cars.Add(car1);
                u3.Cars.Add(car2);

                context.Create(u3);
            }

            [TearDown]
            public void DropClient()
            {
                foreach (Client item in SetupFixture.dbContext.Clients)
                {
                    SetupFixture.dbContext.Clients.Remove(item);
                }

                SetupFixture.dbContext.SaveChanges();
            }

            [Test]
            public void Create()
            {
                
                Client newClients = new Client("Pesho", "Peshev", 28, "peshopeshev@abv.bg");


                
                int ClientsBefore = SetupFixture.dbContext.Clients.Count();
                context.Create(newClients);



                
                int ClientsAfter = SetupFixture.dbContext.Clients.Count();
                Assert.IsTrue(ClientsBefore + 1 == ClientsAfter, "Create() does not work!");
            }

            [Test]
            public void Read()
            {
                Client readClient = context.Read(u3.ID);

                Assert.AreEqual(u3, readClient, "Client does not return the same object!");
            }

            [Test]
            public void ReadWithNavigationalProperties()
            {
                Client readClient = context.Read(u3.ID);

                Assert.That(readClient.Cars.Contains(car1) && readClient.Cars.Contains(car2), "Cars 1 and 2 are not in the list!");
            }


            [Test]
            public void ReadAll()
            {
                List<Client> client = (List<Client>)context.ReadAll();

                Assert.That(client.Count != 0, "ReadAll() does not return clients!");
            }


            public void Update()
            {
                Client changedClient = context.Read(u3.ID);

                changedClient.FirstName = "Updated " + u3.FirstName;

                context.Update(changedClient);

                u3 = context.Read(u3.ID);

                Assert.AreEqual(changedClient, u3, "Update() does not work!");
            }

            [Test]
            public void Delete()
            {
                int ClientsBefore = SetupFixture.dbContext.Clients.Count();

                context.Delete(u3.ID);
                int ClientsAfter = SetupFixture.dbContext.Clients.Count();

                Assert.IsTrue(ClientsBefore - 1 == ClientsAfter, "Delete() does not work!");
            }

            //[Test]
            public void TestMethod()
            {
                var answer = 42;
                Assert.That(answer, Is.EqualTo(42), "Some useful error message");
            }


        }
}
