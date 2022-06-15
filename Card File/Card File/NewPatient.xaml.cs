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
using System.Windows.Shapes;

namespace Card_File
{
    /// <summary>
    /// @Author Daniel Cifka
    /// @Version 1.0
    /// Interaction logic for NewPatient.xaml
    /// This is child window, where user add new patient in Card File and Close this window
    /// </summary>
    public partial class NewPatient : Window
    {

        public ICommunication<Patient> dB; /// Instance for communication with SQLite database.
        public NewPatient()
        {
            InitializeComponent();
            this.dB = new CommunicationDB<Patient>();
        }

        private void Add_Patient(object sender, RoutedEventArgs e) ///Event for Button click
        {
            if (datePicker.SelectedDate.HasValue) //Check value of DataPicker
            {
                String newName = NameTxt.Text;
                String newSurname = SurnameTxt.Text;

                if (newName.Length != 0 && newSurname.Length != 0)
                {  ///Check the other two attributes

                    dB.Add(new Patient() { patientName = newName, patientSurname = newSurname, date = datePicker.SelectedDate.Value }); ///Add new Patient into the Database
                } else
                {
                    MessageBox.Show("You must set Name or Surname");
                }

                this.Close(); ///Close window for add patient
            } else
            {
                MessageBox.Show("You must choose some date.");
            }
        }
    }
}
