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

namespace CS160
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

        List<Project> projectList = new List<Project>();

        private void Tab1project1cbbox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> projectType = new List<string> { "", "New User", "Server Maintenance", "PC Maintenance", "Network Maintenance", "Other" };
            
            var comboBox = sender as ComboBox;
            tab1project1cbbox.ItemsSource = projectType;
            tab1project1cbbox.SelectedIndex = 0;
        }

        private void Tab1visit1cbbox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> visitType = new List<string> { "", "Bagels/Treats", "Exec Mtg", "Lunch", "Repair", "Upgrade", "Other" };
            var comboBox = sender as ComboBox;
            tab1visit1cbbox.ItemsSource = visitType;
            tab1visit1cbbox.SelectedIndex = 0;
        }

        private void Tab2task1cbbox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> taskType = new List<string> { "", "AV", "Backups", "Client Reports", "Documentation", "Farmers Calls", "Ivanti", "Patches", "Restore Tests", "Sales/Marketing", "Sweeps", "Xtraction", "Other" };
            var comboBox = sender as ComboBox;
            tab2task1cbbox.ItemsSource = taskType;
            tab2task1cbbox.SelectedIndex = 0;
        }

        private void Tab2admin1cbbox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> adminType = new List<string> { "", "Breaks", "Meetings", "PTO", "Training", "Other" };
            var comboBox = sender as ComboBox;
            tab2admin1cbbox.ItemsSource = adminType;
            tab2admin1cbbox.SelectedIndex = 0;
        }

        private void Tab1client1cbbox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> clients = new List<string> { "", "LDSBC", "BYU", "Other" };

            var comboBox = sender as ComboBox;
            tab1client1cbbox.ItemsSource = clients;
            tab1client6cbbox.ItemsSource = clients;
            tab1client1cbbox.SelectedIndex = 0;
            tab1client6cbbox.SelectedIndex = 0;
        }

        private void employeecbbox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> employeeList = new List<string> { "", "Alex", "Hayden", "Justin", "Mike", "Arthur", "Other" };
            mainemployeecbbox.ItemsSource = employeeList;
            mainemployeecbbox.SelectedIndex = 0;
            tab3employeecbbox.ItemsSource = employeeList;
            tab3employeecbbox.SelectedIndex = 0;
            tab3employeecbbox_Copy.ItemsSource = employeeList;
            tab3employeecbbox_Copy.SelectedIndex = 0;
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            maindatagrid = sender as DataGrid;
            maindatagrid.ItemsSource = projectList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            projectList.Add(new Project(Convert.ToString(tab1project1cbbox.SelectedItem), Convert.ToString(tab1client1cbbox.SelectedItem), tab1hours1cbbox.Text, 0, tab1note1txbx.Text));
            maindatagrid.ItemsSource = projectList;
        }
    }
}