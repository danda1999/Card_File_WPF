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
using System.Data;
using System.Windows.Markup;
using System.Threading;

namespace Card_File
{
    /// <summary>
    /// @Author Daniel Cifka
    /// @Version 1.0
    /// Interaction logic for MainWindow.xaml
    /// This is Main window, where user can see all patients in database, search specific patient according to name or surname,
    /// editing information about patients, delete patients from database and open window for add new patient.
    /// </summary>
    public partial class MainWindow : Window
    {

        public ICommunication<Patient> dB; /// Instance for communication with SQLite database.

        public MainWindow()
        {
            InitializeComponent();
            dB = new CommunicationDB<Patient>();
        }

        /// <summary>
        /// Event which did after launch app
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            patientDataGrid.ItemsSource = dB.Read(); ///show all data from database in the DataGrid

        }

        /// <summary>
        /// Event for delete patient from database
        /// </summary>
        private void Delete_Patient(object sender, RoutedEventArgs e)
        {
            dB.Delete((Patient)patientDataGrid.SelectedItem); /// Method for delete patient where I get select item from DataGrid
            patientDataGrid.ItemsSource = dB.Read(); ///show all data from database in the DataGrid

        }

        /// <summary>
        /// Event for search specific patien
        /// </summary>
        private void Search_Patient(object sender, RoutedEventArgs e)
        {

            ComboBoxItem ComboItem = (ComboBoxItem)ChooseCMB.SelectedItem; ///Choice according to which we will look
            if (ComboItem != null) { ///Check if choice is not null
                string choose = ComboItem.Name; 
                var name = SearchText.Text;
                if (name.Length != 0) ///Check if name don't have lenght 0
                {

                    patientDataGrid.ItemsSource = dB.Search(choose, name); ///Call method for search in CommunicationDB
                    SearchText.Text = ""; 
                }
            } else
            {
                MessageBox.Show("No patient search was selected"); ///Messege if user not choose some choice
            }
            

        }

        /// <summary>
        /// Event for editing some patient
        /// </summary>
        private void Editate_Patient(object sender, RoutedEventArgs e)
        {
            if (Calendare.SelectedDate.HasValue) ///Check if date is not null
            {
                Patient patient = (Patient)patientDataGrid.SelectedItem; ///Casting the selection to the patient type.

                ///Call method for update information about specific patient
                dB.Update(patient, new Patient() { patientName = NameTxb.Text , patientSurname = SurnameTxb.Text, date = Calendare.SelectedDate.Value});
                patientDataGrid.ItemsSource = dB.Read(); ///show all data from database in the DataGrid
            }

        }

        /// <summary>
        /// Event for open window for add patient.
        /// </summary>
        private void Add_Patient(object sender, RoutedEventArgs e)
        {
            NewPatient newPatient = new NewPatient(); ///Create instant for window add patient
            newPatient.Closed += new EventHandler(window1_Closed); ///add EventHandler for close window
            newPatient.Show(); ///Show add patient window
            
            
        }

        /// <summary>
        /// EventHadler for refresh DataGrind on Main window
        /// </summary>
        void window1_Closed(object sender, EventArgs e)
        {
            patientDataGrid.ItemsSource = dB.Read(); ///show all data from database in the DataGrid
        }
    }
}
