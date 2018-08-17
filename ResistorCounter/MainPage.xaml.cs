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

namespace ResistorCounter
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void ButtonResistor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("ResitorPage.xaml", UriKind.Relative));
        }

        private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("SendReportBugs.xaml", UriKind.Relative));
        }
    }
}
