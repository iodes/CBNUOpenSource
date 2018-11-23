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

namespace Attendance
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        UserManager manager = new UserManager();

        bool Attendance = false;

        string genderSelection = "Male";


        public MainWindow()
        {
            InitializeComponent();

            ////////////
            userList.ItemsSource = manager.Users;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            manager.Users.Add(new User
            {
                Name = userName.Text,
                Sex = genderSelection,
                IsAttended = Attendance
            });
            
            //MessageBox.Show(myUser.Name);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Attendance = true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (gender.SelectedIndex)
            {
                case 0: genderSelection = "Male"; break;

                case 1: genderSelection = "Female"; break;
            }
        }
    }
}
