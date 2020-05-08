using FriendshipMngSys.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendshipMngSys.ViewModels
{
    public class MainWindowViewModel : NotifyBase
    {
        ObservableCollection<Person> mPersonList = new ObservableCollection<Person>();

        public ObservableCollection<Person> PersonList
        {
            get => mPersonList;
            set
            {
                mPersonList = value;
                NotifyPropertyChange("PersonList");
            }
        }


        private Person mSelectedPerson;

        public Person SelectedPerson
        {
            get { return mSelectedPerson; }
            set { mSelectedPerson = value; NotifyPropertyChange("SelectedPerson"); }
        }

    }
}
