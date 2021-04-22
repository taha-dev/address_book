using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address_book
{
    class Academic_info
    {
        decimal _cgpa;
        string _university;
        string _degree;
        string _program;

        public Academic_info(decimal cgpa, string university, string degree, string program)
        {
            _cgpa = cgpa;
            _university = university;
            _degree = degree;
            _program = program;
        }

        public decimal Cgpa { get => _cgpa; set => _cgpa = value; }
        public string University { get => _university; set => _university = value; }
        public string Degree { get => _degree; set => _degree = value; }
        public string Program { get => _program; set => _program = value; }
        public string Print()
        {
            return string.Format("Cgpa: {0}, University: {1}, Degree: {2}, Program: {3}, ",Cgpa, University, Degree, Program);
        }
    }
}
