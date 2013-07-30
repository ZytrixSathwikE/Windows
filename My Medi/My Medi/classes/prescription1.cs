using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_Medi
{
    class prescription1
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Temperature { get; set; }
        public string Bp { get; set; }
        public string symptoms { get; set; }
        public string description { get; set; }
        public string imagepath { get; set; }
        public string audiopath { get; set; }
        public int user_id { get; set; }

        //[ForeginKey (PersonID),REFERENCES People(Id) ON DELETE CASCADE]
        //public string DoctorName { get; set; }
        //public string DoctorName { get; set; }
        //public string DoctorName { get; set; }
        //public string DoctorName { get; set; }
        //public string DoctorName { get; set; }
        //public string DoctorName { get; set; }
        //public string DoctorName { get; set; }
        //[forigenkey,persontable]
        //public int ID { get; set; }


    }
}
