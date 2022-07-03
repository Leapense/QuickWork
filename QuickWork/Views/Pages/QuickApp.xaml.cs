using Microsoft.Win32;
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

namespace QuickWork.Views.Pages
{
    /// <summary>
    /// Interaction logic for QuickApp.xaml
    /// </summary>
    public partial class QuickApp : Page
    {
        public QuickApp()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // load executable file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Executable Files (*.exe)|*.exe";
            Wpf.Ui.Controls.Card card = new Wpf.Ui.Controls.Card();
            if(ofd.ShowDialog() == true)
            {
                card.Content = ofd.FileName;
            }
            QuickArea.Children.Add(card);
        }
    }
}
