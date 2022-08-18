using ADSimpleAccountManager.View;
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

namespace ADSimpleAccountManager
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

        private void TitleBarGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void LogingButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            //Make some cleaning before shuting down the application.
            Application.Current.Shutdown();
        }

        private void ToolConfigurationsClick(object sender, RoutedEventArgs e)
        {
            MainDisplay.Content = new ConfiigurationPage();
        }

        private void CompareUsersClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
