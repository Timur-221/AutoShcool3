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
    /// Interaction logic for AccStud.xaml
    /// </summary>
    public partial class AccStud : Page
    {
        public AccStud()
        {
            InitializeComponent();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            timeButtonPanel.Children.Clear();

            if (datePicker.SelectedDate.HasValue)
            {
                DateTime selectedDate = datePicker.SelectedDate.Value;

                for (int hour = 6; hour < 20; hour++)
                {
                    Button timeButton = new Button();
                    timeButton.Content = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, hour, 0, 0).ToString("HH:mm");
                    timeButton.Margin = new Thickness(5);
                    timeButton.Click += TimeButton_Click;

                    timeButtonPanel.Children.Add(timeButton);
                }
            }
        }

        private void TimeButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            string selectedTime = clickedButton.Content.ToString();

            MessageBox.Show("Записаны на " + selectedTime);
        }

        private void TerNav(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PDDPage());
        }

        private void ProfNav(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new ProfPage());
        }
    }
}
