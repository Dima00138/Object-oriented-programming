using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CourseWork
{
    /// <summary>
    /// Interaction logic for ViewShedule.xaml
    /// </summary>
    public partial class ViewShedule : Page
    {
        public ObservableCollection<Shedule> listShedule { get; set; }
        //public List<Route> Routes { get; set; }
        OracleConnection oracleConnection;
        DataSet dataset = new DataSet();
        public ViewShedule(OracleConnection oracleConnection)
        {
            InitializeComponent();
            listShedule = new ObservableCollection<Shedule>();
            DataContext = this;
            this.oracleConnection = oracleConnection;

            using (UnitOfWork uow = new UnitOfWork(new OracleDbContext(ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString)))
            {
                var SheduleRepo = uow.Shedules;
                var RouteRepo = uow.Routes;
                listShedule = (ObservableCollection<Shedule>)SheduleRepo.GetAll();
                //Routes = (List<Route>)RouteRepo.GetAll();

            }

            //OracleCommand command = new OracleCommand("SELECT * FROM SCHEDULE", oracleConnection);
            ////oracleConnection.Open();
            ////OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM SCHEDULE", oracleConnection);
            ////adapter.Fill(dataset, "SCHEDULE");
            ////DataView dataView = dataset.Tables["SCHEDULE"].DefaultView;

            //OracleDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    listShedule.Add(new Shedule(Convert.ToString(reader["ID"]), (string)reader["ID_TRAIN"], (DateTime)reader["DATE"],
            //        Convert.ToInt32(reader["ROUTE"]), "sds", "sdsd",
            //        (short)reader["TIME_IN_WAY"], (short)reader["FREQUENCY"]));
            //}
            //reader.Close();
            //command.Dispose();
            //oracleConnection.Close();
            

            //if (File.Exists("Shedule.json"))
            //{
            //    using (FileStream fs = new FileStream("Shedule.json", FileMode.Open, FileAccess.Read))
            //    {
            //        listShedule = JsonSerializer.Deserialize<List<Shedule>>(fs);
            //    }
            //    ListShedule.ItemsSource = listShedule;
            //}
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str = Search_TextBox.Text;
            ObservableCollection<Shedule> tempShedule = new ObservableCollection<Shedule>();
            using (var uow = new UnitOfWork(new OracleDbContext(ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString)))
            {
                //var linq = await uow.Shedules.Where(a => (str.Contains(a.Id_Train) || str.Contains(a.Route.Departure_Point)
                //        || str.Contains(a.Route.Arrival_Point) || str.Contains(Convert.ToString(a.Time_In_Way))
                //        || str.Contains(Convert.ToString(a.Frequency)) || str.Trim() == "")).ToListAsync();

                var linq = uow.Shedules.GetAll().ToList().Where(sh => sh.Id_Train.Contains(str) || sh.id.Contains(str)
                        || Convert.ToString(sh.RouteId).Contains(str) || Convert.ToString(sh.Time_In_Way).Contains(str)
                        || Convert.ToString(sh.Frequency).Contains(str) || str.Trim() == "").ToList();

                foreach (Shedule sh in listShedule)
                {
                    if (sh.Id_Train.Contains(str) || sh.id.Contains(str)
                        || Convert.ToString(sh.RouteId).Contains(str) || Convert.ToString(sh.Time_In_Way).Contains(str)
                        || Convert.ToString(sh.Frequency).Contains(str) || str.Trim() == "")
                    {
                        tempShedule.Add(sh);
                    }
                }
            }
            ListShedule.ItemsSource = tempShedule;
        }

        private void ListShedule_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                Shedule shedule = (Shedule)e.Row.Item;
                string columnName = e.Column.SortMemberPath;
                string newValue = ((TextBox)e.EditingElement).Text;
                if (columnName == "id" && newValue != "")
                {
                    throw new Exception();
                }
                else if (columnName == "id")
                {
                    // удаляем запись из базы данных
                    using (UnitOfWork uow = new UnitOfWork(new OracleDbContext(ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString)))
                    {
                        uow.Shedules.Delete(shedule, shedule.id);
                        uow.Save();
                    }
                }
                else
                {
                    // обновляем запись в базе данных
                    using (UnitOfWork uow = new UnitOfWork(new OracleDbContext(ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString)))
                    {
                        uow.Shedules.Update(shedule, columnName, newValue);
                        uow.Save();
                    }
                }
            }
            catch
            {
                MessageBox.Show("ID нельзя изменять");
            }
        }
    }
}
