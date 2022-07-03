using System.Windows.Controls;

namespace QuickWork.Views.Pages
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        public static string your_life_stylish = "";
        public Settings()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            your_life_stylish = "Game";
        }

        private void RadioButton_Checked_1(object sender, System.Windows.RoutedEventArgs e)
        {
            your_life_stylish = "Work";
        }

        private void RadioButton_Checked_2(object sender, System.Windows.RoutedEventArgs e)
        {
            your_life_stylish = "Study";
        }

        private void RadioButton_Checked_3(object sender, System.Windows.RoutedEventArgs e)
        {
            your_life_stylish = "Other";
        }
    }
}