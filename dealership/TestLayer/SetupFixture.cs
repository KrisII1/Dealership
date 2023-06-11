using DataLayer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;

namespace TestLayer
{
    [SetUpFixture]
    public static class SetupFixture
    {
        public static DealershipDBContext dbContext;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {

            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            dbContext = new DealershipDBContext(builder.Options);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {

            dbContext.Dispose();
        }
    }
}
