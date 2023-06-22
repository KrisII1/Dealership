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
    public class LocationContextTest
    {
        private LocationContext context = new LocationContext(SetupFixture.dbContext);
        private Location l1;
        private Cars car1, car2;




        [SetUp]
        public void CreateLocation()
        {
            
            l1 = new Location("Peshtera");

            car1 = new Cars("e63", l1);
            car2 = new Cars("c63", l1);

            l1.Cars.Add(car1);
            l1.Cars.Add(car2);

            context.Create(l1);
        }

        [TearDown]
        public void DropLocation()
        {
            foreach(Location item in SetupFixture.dbContext.Locations)
            {
                SetupFixture.dbContext.Locations.Remove(item);
            }

            SetupFixture.dbContext.SaveChanges();
        }

        [Test]
        public void Create()
        {

            Location newLocations = new Location("Varna");



            int LocationsBefore = SetupFixture.dbContext.Locations.Count();
            context.Create(newLocations);




            int LocationsAfter = SetupFixture.dbContext.Locations.Count();
            Assert.IsTrue(LocationsBefore + 1 == LocationsAfter, "Create() does not work!");
        }

        [Test]
        public void Read()
        {
            Location readLocation = context.Read(l1.Id);

            Assert.AreEqual(l1, readLocation, "Location does not return the same object!");
        }

        [Test]
        public void ReadWithNavigationalProperties()
        {
            Location readLocation = context.Read(l1.Id);

            Assert.That(readLocation.Cars.Contains(car1) && readLocation.Cars.Contains(car2), "Cars 1 and 2 are not in the list!");
        }


        [Test]
        public void ReadAll()
        {
            List<Location> location = (List<Location>)context.ReadAll();

            Assert.That(location.Count != 0, "ReadAll() does not return clients!");
        }


        public void Update()
        {
            Location ChangedLocation = context.Read(l1.Id);

            ChangedLocation.Name = "Updated " + l1.Name;

            context.Update(ChangedLocation);

            l1 = context.Read(l1.Id);

            Assert.AreEqual(ChangedLocation, l1, "Update() does not work!");
        }

        [Test]
        public void Delete()
        {
            int LocationsBefore = SetupFixture.dbContext.Locations.Count();

            context.Delete(l1.Id);
            int LocationsAfter = SetupFixture.dbContext.Locations.Count();

            Assert.IsTrue(LocationsBefore - 1 == LocationsAfter, "Delete() does not work!");
        }

        //[Test]
        public void TestMethod()
        {
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }


    }
}
