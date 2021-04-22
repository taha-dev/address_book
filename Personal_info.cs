using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address_book
{
    class Personal_info
    {
        string _fname;
        string _lname;
        string _email;
        string _city;
        string _address;
        string _country;

        public Personal_info(string fname, string lname, string email, string city, string address, string country)
        {
            _fname = fname;
            _lname = lname;
            _email = email;
            _city = city;
            _address = address;
            _country = country;
        }

        public string Fname { get => _fname; set => _fname = value; }
        public string Lname { get => _lname; set => _lname = value; }
        public string Email { get => _email; set => _email = value; }
        public string City { get => _city; set => _city = value; }
        public string Address { get => _address; set => _address = value; }
        public string Country { get => _country; set => _country = value; }
        public string Print()
        {
            return "First Name: "+Fname+", Last Name: "+Lname+", Email: "+Email+", City: "+City+", Address: "+Address+", Country: "+Country+", ";
        }
    }
}
