using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wypozyczalniaSamochodow
{
    public class Account
    {
        public int id;
        public string firstName;
        public string lastName;
        public string email;
        public string city;
        public string address;
        public string houseNumber;
        public string apartmentNumber;
        public string password;
        public bool isAdmin;

        public Account()
        {
            this.id = -1;
            this.firstName = null;
            this.lastName = null;
            this.email = null;
            this.isAdmin = false;
        }
        public Account(int id, string fname, string lname, string email, bool isAdmin)
        {
            this.id = id;
            this.firstName = fname;
            this.lastName = lname;
            this.email = email;
            this.isAdmin = isAdmin;
        }

    }
}
