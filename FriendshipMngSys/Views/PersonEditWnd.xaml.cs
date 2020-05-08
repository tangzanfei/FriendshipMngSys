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
    /// PersonEditWnd.xaml 的交互逻辑
    /// </summary>
    public partial class PersonEditWnd : Window
    {
        public PersonEditWnd()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public bool IsReadOnly 
        {
            get
            {
                return !girdData.IsEnabled;
            }
            set 
            {
                girdData.IsEnabled = !value;
            }
        }
        public Person Person
        {
            get { return VM.Person; }
            set 
            {
                if (value==null)
                {
                    VM.Person = new Person();
                }
                else
                {
                    VM.Person = value;
                }
            }
        }



        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
