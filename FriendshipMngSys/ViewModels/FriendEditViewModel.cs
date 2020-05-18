using FriendshipMngSys.DBUtility;
using FriendshipMngSys.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendshipMngSys.ViewModels
{
    public class FriendEditViewModel : NotifyBase
    {

        
        private Person mPerson = new Person();

        public Person Person
        {
            get { return mPerson; }
            set
            {
                mPerson = value;
                if (value != null)
                {
                    RefreshFriendList(value);
                    RefreshPersonList(value);
                }
                NotifyPropertyChange("Person");
            }
        }

        private ObservableCollection<Person> friendList = new ObservableCollection<Person>();

        public ObservableCollection<Person> FriendList
        {
            get { return friendList; }
        }

        private ObservableCollection<Person> personList = new ObservableCollection<Person>();
        public ObservableCollection<Person> PersonList
        {
            get { return personList; }
        }


        public string FindName { get; set; }



        void RefreshFriendList(Person person)
        {

            var list = DbHelper.GetFriendListByID(person.ID);
            foreach (var friend in list)
            {
                friendList.Add(friend);
            }
        }

        void RefreshPersonList(Person person)
        {
            List<Person> mypersonList = new List<Person>();
            var list = DbHelper.PersonBLL.GetModelList("ID != '" + person.ID + "'");
            foreach (var p in list)
            {
                Person myperson = ModelConvertHelper.DBToModel(p);

                mypersonList.Add(myperson);
            }
            mypersonList = mypersonList.Except(friendList,new PersonIdComparer()).ToList();
            foreach (var item in mypersonList)
            {
                personList.Add(item);

            }
        }



    }
}
