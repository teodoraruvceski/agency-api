using Agencija_Back.Models;
using System;
using System.Linq;

namespace Agencija_Back.DataBase
{
    public class CompaniesRepository
    {
        private ProjectDbContext db;
        public CompaniesRepository()
        {
            db=new ProjectDbContext();
        }
        public Company AddCompany(Company company)
        {
            try
            {
                db.companies.Add(company);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                return null;
            }
            return FindByName(company.name);
        }
        public Company FindById(int id)
        {
            return db.companies.Find(id);
        }
        public Company FindByName(string name)
        {
            return db.companies.SingleOrDefault(c=> c.name== name);
        }
        public void UpdateCompany(Company company)
        {
            db.companies.Update(company);
        }
        
    }
}
