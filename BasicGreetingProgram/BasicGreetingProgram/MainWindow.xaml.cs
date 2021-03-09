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

namespace BasicGreetingProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void LoginClick(object sender, RoutedEventArgs e)
        {
            if (TextBox_loginName.Text !="")
            {
                //Greet the user
                foreach(Control control in this.RootGrid.Children)
                {
                    control.Visibility = Visibility.Collapsed;
                }
                Label_Greeting.Content += TextBox_loginName.Text;
                Label_Greeting.Visibility = Visibility.Visible;
            }
            else
            {
                //Tell the user to enter the name
                Label_NoName.Visibility = Visibility.Visible;
            }
        }
    }
}
