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

namespace AutoShcool.Pages
{
    /// <summary>
    /// Interaction logic for ProfPage.xaml
    /// </summary>
    public partial class ProfPage : Page
    {
        public ProfPage()
        {
            InitializeComponent();
        }

        private void AccNav(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new AccStud());
        }

        private void ExNAv(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }
    }
}
