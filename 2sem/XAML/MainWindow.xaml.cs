using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using Xceed.Wpf.Toolkit;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Controls.Primitives;
using CourseWork.XAML;
using ModernWpf;

namespace CourseWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OracleConnection oracleConnection;
        string[] theme =
        {"Light",
            "Dark"};
        public MainWindow()
        {
            InitializeComponent();

            oracleConnection = new OracleConnection(ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString);

            MainPage.Navigate(new ViewShedule(oracleConnection));
        }

        private void View_Shedule_Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new ViewShedule(oracleConnection));
        }

        private void Shedule_Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new CreateShedule(oracleConnection));
        }

        private void Eng_loc_button_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri("Dictionary-eng.xaml", UriKind.RelativeOrAbsolute);
            Application.Current.Resources.MergedDictionaries.RemoveAt(Application.Current.Resources.MergedDictionaries.Count-1);
            Application.Current.Resources.MergedDictionaries.Add(dict);
        }

        private void Rus_loc_button_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri("Dictionary-ru.xaml", UriKind.RelativeOrAbsolute);
            Application.Current.Resources.MergedDictionaries.RemoveAt(Application.Current.Resources.MergedDictionaries.Count - 1);
            Application.Current.Resources.MergedDictionaries.Add(dict);
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (Theme.IsOn)
            {
                ThemeManager.Current.ApplicationTheme = ApplicationTheme.Dark;
            }
            else
            {
                ThemeManager.Current.ApplicationTheme = ApplicationTheme.Light;
            }
        }

        private void CustomControl1_B_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            CustomControl1_B.Width += 10;
            Ellipse ee = sender as Ellipse;
            if (ee != null)
            {
                ee.Fill = new SolidColorBrush(Colors.Green);
            }
        }
    }
}
