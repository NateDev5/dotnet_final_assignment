using System.Windows;

namespace exercise3
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

        private void main_check_Checked(object sender, RoutedEventArgs e)
        {
            main_check.Content = "Engine On";

            check_audio.IsEnabled = true;
            check_audio.IsChecked = true;

            check_wipers.IsEnabled = true;
            check_wipers.IsChecked = true;

            check_ac.IsEnabled = true;
            check_ac.IsChecked = true;
        }

        private void main_check_Unchecked(object sender, RoutedEventArgs e)
        {
            main_check.Content = "Engine Off";

            check_audio.IsEnabled = false;
            check_audio.IsChecked = false;

            check_wipers.IsEnabled = false;
            check_wipers.IsChecked = false;

            check_ac.IsEnabled = false;
            check_ac.IsChecked = false;
        }

        private void main_check_Indeterminate(object sender, RoutedEventArgs e)
        {
            main_check.IsChecked = null;
            main_check.Content = "Ignition";

            check_audio.IsEnabled = true;
            check_audio.IsChecked = true;

            check_wipers.IsEnabled = true;
            check_wipers.IsChecked = true;

            check_ac.IsEnabled = false;
            check_ac.IsChecked = false;
        }
    }
}