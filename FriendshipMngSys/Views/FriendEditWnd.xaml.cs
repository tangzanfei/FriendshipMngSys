using FriendshipMngSys.DBUtility;
using FriendshipMngSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FriendshipMngSys.Views
{
    /// <summary>
    /// FriendEdit.xaml 的交互逻辑
    /// </summary>
    public partial class FriendEditWnd : Window
    {
        public FriendEditWnd()
        {
            InitializeComponent();
        }

        public Person SelectPerson
        {
            get { return VM.Person; }
            set { VM.Person = value; }
        }

        public List<Person> FriendList
        {
            get { return VM.FriendList.ToList(); }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int a = listboxPerson.SelectedItems.Count;
            var list = listboxPerson.SelectedItems;
            for (int i = a-1; i >= 0; i--)
            {
                VM.FriendList.Add(list[i] as Person);
                VM.PersonList.Remove(list[i] as Person);
            }
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            int a = listboxFriend.SelectedItems.Count;
            var list = listboxFriend.SelectedItems;
            for (int i = a-1; i >= 0; i--)
            {
                VM.PersonList.Add(list[i] as Person);
                VM.FriendList.Remove(list[i] as Person);
            }

        }

        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            listboxPerson.SelectAll();
            listboxFriend.SelectAll();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            listboxFriend.UnselectAll();
            listboxPerson.UnselectAll();
        }

        public bool TrySave()
        {
            
            return DbHelper.UpdateFriendShip(VM.Person.ID, VM.FriendList);
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            string name = txbFindName.Text;
            var personview = listboxPerson.Items;
            var friendview = listboxFriend.Items;
            listboxFriend.UnselectAll();
            listboxPerson.UnselectAll();
            if (string.IsNullOrEmpty(name))
            {
                personview.Filter = null;
                friendview.Filter = null;
            }
            personview.Filter = (o) => { return (o as Person).Name.Contains(name); };
            friendview.Filter = (o) => { return (o as Person).Name.Contains(name); };





        }
    }
}
