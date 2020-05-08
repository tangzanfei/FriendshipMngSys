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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //var list = SQLiteHelper.GetTableBySQL("select * from Persons");
            
            Views.PersonEditWnd wnd = new Views.PersonEditWnd();
            if (wnd.ShowDialog()??false)
            {
                //点击了确认
                var p = wnd.Person;
                FriendshipMngSys.BLL.PersonBLL personBll= new BLL.PersonBLL();
                DBPerson db = ModelConvertHelper.ModelToDB(p);
                personBll.Add(db);
                VM.PersonList.Add(p);
            }
            else
            {
                //点击了取消
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FriendshipMngSys.BLL.PersonBLL personBll = new BLL.PersonBLL();
            var pernsonList = personBll.GetModelList("");
            List<Person> pensonList = new List<Person>();
            foreach (var p in pernsonList)
            {
                pensonList.Add(ModelConvertHelper.DBToModel(p));
            }
            VM.PersonList = new System.Collections.ObjectModel.ObservableCollection<Person>(pensonList);
        }
    }
}
