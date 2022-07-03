using System.Data.SqlClient;
using System;
using System.Windows.Controls;
using System.Windows;

namespace QuickWork.Views.Pages
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string life = Settings.your_life_stylish;
            schedulelist.Items.Clear();
            if(life == null)
            {
                Showing.Content = "You need to select your life for more sightful.";
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Server=tcp:quickwork-alarmdbserver.database.windows.net,1433;Initial Catalog=QuickWork_db_alarm;Persist Security Info=False;User ID=cjhool;Password=whwoguscjswo0#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    
                    string sql = "select Dates,Description,Name from [dbo].[Alarm] where Name like N'" + Environment.UserDomainName + "';";
                    
                    using(SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                //MessageBox.Show(reader.GetDateTime(0).ToString());
                                var dates = new DateTime();
                                dates = reader.GetDateTime(0);
                                string dateformat = dates.ToString("MM/dd/yyyy");
                                schedulelist.Items.Add(dateformat + "       " + reader.GetString(1) + "       " + reader.GetString(2));
                            }
                        }
                        conn.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}