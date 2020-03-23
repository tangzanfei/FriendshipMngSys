using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendshipMngSys.Model
{
    public class Company
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private string address;

        public string Addiress
        {
            get { return address; }
            set { address = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }


    }
}
