using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ElifTech.Companies.Web.DAL;
using System.Linq;
using System.Collections.Generic;
using ElifTech.Companies.Web.Context;

namespace ElifTech.Companies.Web.Tests
{
    [TestClass]
    public class DbTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            CompaniesContext context = new CompaniesContext();
            var _companies = new List<Companie>
            {
                new Companie { ParentId = 0, Name = "Coca-cola", Earnings = 74 },
                new Companie { ParentId = 1, Name = "Fanta", Earnings = 40 },
                new Companie { ParentId = 2, Name = "Sprite", Earnings = 48 },
                new Companie { ParentId = 3, Name = "Yupi", Earnings = 32 }
            };

            _companies.ForEach(s => context.Companies.Add(s));
            context.SaveChanges();
            var companies = context.Companies.ToList();
            
            Assert.IsTrue(companies.Count > 0);
        }
    }
}
