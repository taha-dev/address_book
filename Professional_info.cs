using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address_book
{
    class Professional_info
    {
        int salary;
        string _company;
        string _work_exp;
        string _designation;

        public Professional_info(int salary, string company, string work_exp, string designation)
        {
            this.salary = salary;
            _company = company;
            _work_exp = work_exp;
            _designation = designation;
        }

        public int Salary { get => salary; set => salary = value; }
        public string Company { get => _company; set => _company = value; }
        public string Work_exp { get => _work_exp; set => _work_exp = value; }
        public string Designation { get => _designation; set => _designation = value; }
        public string Print()
        {
            return string.Format("Salary: {0}, Company: {1}, Work Experience: {2}, Designation: {3}", Salary, Company, Work_exp, Designation);
        }
    }
}
