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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double result;
                if (opr.SelectedIndex == 0) //덧셈
                {
                    result = double.Parse(textleft.Text) + double.Parse(textright.Text);

                 
                }else if(opr.SelectedIndex == 1) //뺄셈
                {
                    result = double.Parse(textleft.Text) - double.Parse(textright.Text);

                  
                }
                else if(opr.SelectedIndex == 2) //곱셈
                {
                    result = double.Parse(textleft.Text) * double.Parse(textright.Text);

                   
                }
                else if(opr.SelectedIndex == 3) //나눗셈
                {
                    result = double.Parse(textleft.Text) + double.Parse(textright.Text);

                   
                }
                MessageBox.Show(result.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
