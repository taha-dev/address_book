using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address_book
{
    class User
    {
        Personal_info _personal_info;
        Academic_info _academic_info;
        Professional_info _professional_info;

        public User(Personal_info personal_info, Academic_info academic_info, Professional_info professional_info)
        {
            _personal_info = personal_info;
            _academic_info = academic_info;
            _professional_info = professional_info;
        }

        internal Personal_info Personal_info { get => _personal_info; set => _personal_info = value; }
        internal Academic_info Academic_info { get => _academic_info; set => _academic_info = value; }
        internal Professional_info Professional_info { get => _professional_info; set => _professional_info = value; }
        public string Print_user()
        {
            return this.Personal_info.Print() + this.Academic_info.Print() + this.Professional_info.Print();
        }
    }
}
