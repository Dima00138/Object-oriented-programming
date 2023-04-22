using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CourseWork.XAML
{
    /// <summary>
    /// Interaction logic for CreateShedule.xaml
    /// </summary>
    public partial class CreateShedule : Page
    {
        OracleConnection oracleConnection;
        List<Shedule> sheduleL = new();
        string lastAction = "";
        Shedule? lastShedule;
        Route r;
        short freq = 4;

        public CreateShedule(OracleConnection oracleConnection)
        {
            InitializeComponent();
            this.oracleConnection = oracleConnection;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Trains.Text == null || Time_TextBox.Text == ""
               || From.Text == null || To.Text == null)
            {
                return;
            }
            lastAction = "add";
            r = new Route(To.Text, From.Text);
            lastShedule = new Shedule("12", Trains.Text, DatePick.DisplayDate, r, 2, freq);
            sheduleL.Add(lastShedule);
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            if (lastAction == "add")
            {
                lastAction = "rem";
                sheduleL.Remove(lastShedule);
            }
            if (lastAction == "rem")
            {
                lastAction = "add";
                sheduleL.Add(lastShedule);
            }
        }

        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            if (lastAction == "add")
            {
                lastAction = "add";
                sheduleL.Remove(lastShedule);
            }
            if (lastAction == "rem")
            {
                lastAction = "rem";
                sheduleL.Add(lastShedule);
            }
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {

            //using (FileStream fs = new FileStream("Shedule.json", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    JsonSerializer.Serialize(fs, sheduleL);
            //}
            //oracleConnection.Open();
            //string insertQuery = "INSERT INTO SCHEDULE (\"ID\", ID_TRAIN, \"DATE\", ROUTE, TIME_IN_WAY, FREQUENCY)" +
            //    " VALUES (:\"id\", :idtrain, :\"date\", :route, :tiw, :freq)";
            //OracleCommand command = new OracleCommand(insertQuery, oracleConnection);
            //command.Parameters.Add(":\"id\"", Convert.ToInt32(lastShedule.id) + (int)DateTime.Now.Ticks);
            //command.Parameters.Add(":idtrain", lastShedule.Id_Train);
            //command.Parameters.Add(":\"date\"", lastShedule.Date);
            //command.Parameters.Add(":route",1);
            //command.Parameters.Add(":tiw", lastShedule.Time_In_Way);
            //command.Parameters.Add(":freq", lastShedule.Frequency);
            //command.ExecuteNonQuery();
            //command.Dispose();
            //oracleConnection.Close();
            using (UnitOfWork uow = new UnitOfWork(new OracleDbContext(ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString)))
            {
                //uow.Routes.Create(r);
                uow.Shedules.Create(lastShedule);
                uow.Save();
            }
        }

        private void RadioBut_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            string str = pressed.Content.ToString();
            if (str == "daily")
            {
               freq = 1;
            }else if (str == "even days")
            {
                freq = 2;
            }else if (str == "odd days") 
            { 
                freq = 3;
            }else if (str == "once")
            {
                freq = 4;
            }
        }
    }
}
