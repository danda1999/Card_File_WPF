using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_File
{
    /// <summary>
    /// @Author Daniel Cifka
    /// @Version 1.0
    /// The class for communication with SQLite databse.
    /// This class implement interface ICommunication, where is basic description of function.
    /// </summary>
    /// <typeparam name="T">Specification type (Patient)</typeparam>
    public class CommunicationDB<T> : ICommunication<T>
    {

        public void Add(T data)
        {
            if(data != null) /// Checked if data are not null
            {
                using (PatientContext context = new PatientContext()) ///Get of context about data in database.
                {
                    ///Necessary casting to the patient type, due to direct access to its attributes
                    Patient newPatient = (Patient)Convert.ChangeType(data, typeof(Patient));
                    newPatient.patientID = context.Patients.Count() + 1; /// Specificate ID for new entity
                    if (newPatient != null) ///Check newPatien is not null
                    {
                        context.Add(newPatient); ///Add to database
                        context.SaveChanges(); ///Save change
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void Delete(T data)
        {
            if (data != null) /// Checked if data are not null
            {
                using (PatientContext context = new PatientContext()) ///Get of context about data in database.
                {
                    ///Necessary casting to the patient type, due to direct access to its attributes
                    Patient selectedPatient = (Patient)Convert.ChangeType(data, typeof(Patient)); 

                    if (selectedPatient != null) ///Check selectedPatient is not null
                    {
                        Patient user = context.Patients.Single(x => x.patientID == selectedPatient.patientID);

                        context.Remove(user); ///delete entity from storage space
                        context.SaveChanges();///Save change

                    }

                }
            }
        }

        public List<T> Read()
        {
            List<T> patients = new List<T>(); ///List for load general data
            List<Patient> list = new List<Patient>(); ///List for specific data type
            using (PatientContext context = new PatientContext())
            {
                list = context.Patients.ToList(); /// List with all data in database
                foreach(Patient patient in list)
                {
                    patients.Add((T)Convert.ChangeType(patient, typeof(T)));  ///Copy frow general list to specific type list
                }

                return patients; ///return list with specific type of entity
            }
        }

        public List<T> Search(string radiobutten,string data)
        {
            
            List<T> patients = new List<T>(); ///List for load general data
            List<Patient> list = new List<Patient>(); ///List for specific data type
            if (radiobutten != null) ///Valeu of Combobox is choosen
            {
                using (PatientContext context = new PatientContext())
                {
                    if (radiobutten.Equals("name")) /// Valeu of Combobox is name
                    {
                        list = context.Patients.Where(u => u.patientName.Equals(data)).ToList(); ///Entity with specific name
                        foreach (Patient patient in list)
                        {
                            patients.Add((T)Convert.ChangeType(patient, typeof(T))); ///Copy frow general list to specific type list
                        }
                    }
                    else if (radiobutten.Equals("surname")) /// Valeu of Combobox is surname
                    {
                        list = context.Patients.Where(u => u.patientSurname.Equals(data)).ToList(); ///Entity with specific surname
                        foreach (Patient patient in list)
                        {
                            patients.Add((T)Convert.ChangeType(patient, typeof(T)));  ///Copy frow general list to specific type list
                        }
                    }

                    return patients; ///return list with specific entitiy


                }
            } else
            {
                return this.Read(); ///App show all data in Database
            }
        }

        public void Update(T data, T newData)
        {
            if (data != null && newData != null) ///Check if all general entity is not null
            {
                ///Necessary casting to the patient type, due to direct access to its attributes
                Patient patient = (Patient)Convert.ChangeType(data, typeof(Patient));

                ///Necessary casting to the patient type, due to direct access to its attributes
                Patient newPatient = (Patient)Convert.ChangeType(newData, typeof(Patient));
                using (PatientContext context = new PatientContext())
                {
                    ///Find entity with specific ID
                    var newpatient = context.Patients.Find(patient.patientID);
                    if (newpatient!= null) //Check if find entity is not null
                    {
                        ///Update information for a specific entity
                        newpatient.patientName = newPatient.patientName;
                        newpatient.patientSurname = newPatient.patientSurname;
                        newpatient.date = newPatient.date;

                        context.SaveChanges();///Save change
                    }
                }
            }
        }
    }
}
