using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Card_File
{
    /// <summary>
    /// @Author Daniel Cifka
    /// @Version 1.0
    /// This class represents an instance of individual patients.
    /// The class also represents the individual tables stored in the Database.
    /// The attributes of the class are stored in the database as columns of the appropriate table. 
    /// </summary>
    public class Patient
    {

        [Key]
        /**
         *Attribute patientID is primary key in database.
         *This number is generated automatically.
         */
        public int patientID { get; set; }

        /**
         * Name of patient
         */
        public string patientName { get; set; }

        /**
         * Surname of patient
         */
        public string patientSurname { get; set; }

        /**
         * BirthDate of patient
         */
        public DateTime date { get; set; }


    }
}
