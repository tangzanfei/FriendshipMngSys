using FriendshipMngSys.DBUtility;
using FriendshipMngSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendshipMngSys.ViewModels
{
    public class PersonEditViewModel:NotifyBase
    {
        private Person mPerson=new Person();

        public Person Person
        {
            get { return mPerson; }
            set 
            { 
                mPerson = value;
                NotifyPropertyChange("Person");
            }
        }





    }
}
