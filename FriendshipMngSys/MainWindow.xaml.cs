using FriendshipMngSys.DBUtility;
using FriendshipMngSys.Model;
using FriendshipMngSys.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FriendshipMngSys
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var pernsonList =DbHelper.PersonBLL.GetModelList("");
            List<Person> pensonList = new List<Person>();
            foreach (var p in pernsonList)
            {
                pensonList.Add(ModelConvertHelper.DBToModel(p));
            }
            VM.PersonList = new System.Collections.ObjectModel.ObservableCollection<Person>(pensonList);
        }



        private void MenuItemAddPerson_Click(object sender, RoutedEventArgs e)
        {
            //var list = SQLiteHelper.GetTableBySQL("select * from Persons");
            
            PersonEditWnd wnd = new PersonEditWnd();
            wnd.Owner = this;
            if (wnd.ShowDialog()??false)
            {
                //点击了确认
                var p = wnd.Person;
                DBPerson db = ModelConvertHelper.ModelToDB(p);
                DbHelper.PersonBLL.Add(db);
                VM.PersonList.Add(p);
            }
            else
            {
                //点击了取消
            }

        }

        private void MenuItemEditPerson_Click(object sender, RoutedEventArgs e)
        {
            var p = VM.SelectedPerson;
            
            PersonEditWnd wnd = new PersonEditWnd();
            wnd.Owner = this;
            wnd.Person = (Person)p.Copy();
            if (wnd.ShowDialog() ?? false)
            {
                //点击了确认

                int index=VM.PersonList.IndexOf(p);
                VM.PersonList[index] = p = wnd.Person;
                DBPerson db = ModelConvertHelper.ModelToDB(p);
                DbHelper.PersonBLL.Update(db);

            }
            else
            {
                //点击了取消
            }

        }

        private void MenuItemDelPerson_Click(object sender, RoutedEventArgs e)
        {
            var p = VM.SelectedPerson;

            PersonEditWnd wnd = new PersonEditWnd();
            wnd.Owner = this;
            wnd.Person = (Person)p.Copy();
            wnd.IsReadOnly = true;
            if (wnd.ShowDialog() ?? false)
            {
                //点击了确认
                VM.PersonList.Remove(p);


                if(DbHelper.PersonBLL.Delete(p.ID))
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }


            }
            else
            {
                //点击了取消
            }

        }

        private void listView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MenuItemEditPerson_Click(sender, e);
        }
    }
}
