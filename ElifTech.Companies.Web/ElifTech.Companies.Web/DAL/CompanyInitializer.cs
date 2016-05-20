using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ElifTech.Companies.Web.Context;


namespace ElifTech.Companies.Web.DAL
{
    public class CompanyInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<CompaniesContext>
    {

        protected override void Seed(CompaniesContext context)
        {
            var _companies = new List<Companie>
            {
                new Companie { ParentId = 0, Name = "Coca-cola", Earnings = 74 },
                new Companie { ParentId = 1, Name = "Fanta", Earnings = 40 },
                new Companie { ParentId = 2, Name = "Sprite", Earnings = 48 },
                new Companie { ParentId = 3, Name = "Yupi", Earnings = 32 }
            };

            _companies.ForEach(s => context.Companies.Add(s));
            context.SaveChanges();
        }
    }
}