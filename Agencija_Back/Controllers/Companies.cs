using Agencija_Back.DataBase;
using Agencija_Back.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agencija_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Companies : ControllerBase
    {
        CompaniesRepository companiesRepository=new CompaniesRepository();
        [Route("getCompanies")]
        [HttpGet]
        public IEnumerable<Company> GetCompanies()
        {
            return new List<Company>();
        }
        [Route("login")]
        [HttpPost]
        public Company Login(string email,string password)
        {
            Company company = new Company();
            return company;
        }
        [Route("register")]
        [HttpPost]
        public Company Register(string email, string password,string pib,string name)
        {
            if(name!=null && name!="" &&
                pib!=null && pib!="" &&
                email != null && email != "")
            {
                Company company = companiesRepository.AddCompany(new Company { email=email,password=password,pib=pib,name=name});
                return company;
            }
            return null;
            
        }
    }
}
