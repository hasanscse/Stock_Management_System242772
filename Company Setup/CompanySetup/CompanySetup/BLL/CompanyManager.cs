using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanySetup.Models;

namespace CompanySetup.BLL
{
    public class CompanyManager
    {
        CompanyRepository _companyRepository = new CompanyRepository();

        public int Insert(Company company)
        {
            return _companyRepository.Insert(company);

        }

        public DataTable ShowCompany()
        {
            return _companyRepository.ShowCompany();
        }

    }
}
