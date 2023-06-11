using BusinessLayer;
using DataLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestLayer
{
    [TestFixture]
    public class CarsContextTest
    {
        private CarsContext context = new CarsContext(SetupFixture.dbContext);
        private Cars car;
        private Client u1, u2;




        [SetUp]
        public void CreateInterest()
        {
            Location Sofia = new Location("Sofia");
            car = new Cars("Camaro", Sofia);

            u1 = new Client("Georgi", "Ivanov", 20, "georgi@abv.bg");
            u2 = new Client("Ivan", "Petrov", 22, "ivan@abv.bg");

            car.Clients.Add(u1);
            car.Clients.Add(u2);

            context.Create(car);
        }

        [TearDown]
        public void DropBrand()
        {
            foreach (Cars item in SetupFixture.dbContext.Cars)
            {
                SetupFixture.dbContext.Cars.Remove(item);
            }

            SetupFixture.dbContext.SaveChanges();
        }

        [Test]
        public void Create()
        {
            Location Plovdiv = new Location("Plovdiv");
            Cars newCars = new Cars("M5", Plovdiv);

            int CarsBefore = SetupFixture.dbContext.Cars.Count();
            context.Create(newCars);

            int CarsAfter = SetupFixture.dbContext.Cars.Count();
            Assert.IsTrue(CarsBefore + 1 == CarsAfter, "Create() does not work!");
        }

        [Test]
        public void Read()
        {
            Cars readCars = context.Read(car.Id);

            Assert.AreEqual(car, readCars, "Cars does not return the same object!");
        }

        [Test]
        public void ReadWithNavigationalProperties()
        {
            Cars readCars = context.Read(car.Id);

            Assert.That(readCars.Clients.Contains(u1) && readCars.Clients.Contains(u2), "U1 and U2 is not in the Clients list!");
        }


        [Test]
        public void ReadAll()
        {
            List<Cars> cars = (List<Cars>)context.ReadAll();

            Assert.That(cars.Count != 0, "ReadAll() does not return interests!");
        }


        public void Update()
        {
            Cars changedCar = context.Read(car.Id);

            changedCar.Model = "Updated " + car.Model;

            context.Update(changedCar);

            car = context.Read(car.Id);

            Assert.AreEqual(changedCar, car, "Update() does not work!");
        }

        [Test]
        public void Delete()
        {
            int CarBefore = SetupFixture.dbContext.Cars.Count();

            context.Delete(car.Id);
            int CarAfter = SetupFixture.dbContext.Cars.Count();

            Assert.IsTrue(CarBefore - 1 == CarAfter, "Delete() does not work! ????");
        }

        //[Test]
        public void TestMethod()
        {
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }


    }


}