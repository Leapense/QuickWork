using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for DateMaker.xaml
    /// </summary>
    public partial class DateMaker : Page
    {
        
        public DateMaker()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string life_style = Settings.your_life_stylish;
            try
            {
                SqlConnection conn = new SqlConnection("Server=tcp:quickwork-alarmdbserver.database.windows.net,1433;Initial Catalog=QuickWork_db_alarm;Persist Security Info=False;User ID=cjhool;Password=whwoguscjswo0#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                conn.Open();
                //String sql = "CREATE TABLE [dbo].[Alarm] ([Dates] [date] Not null, [Description] varchar(500) not null);";
                SqlCommand cmd = new SqlCommand(@"insert into dbo.Alarm (Dates, Description, Name, Style)
                                                  values (@Dates, @Description, @Name, @Style)", conn);

                cmd.Parameters.Add(new SqlParameter("Dates", Date.SelectedDate));
                cmd.Parameters.Add(new SqlParameter("Description", Desc.Text));
                cmd.Parameters.Add(new SqlParameter("Name", Environment.UserDomainName));
                cmd.Parameters.Add(new SqlParameter("Style", life_style));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        
    }
}
