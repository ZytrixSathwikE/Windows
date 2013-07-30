using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_Medi
{
    class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string DoctorName { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        //public string Prescription { get; set; }

        //public string Image { get; set; }

        //public string Audio { get; set; }

        //public override string ToString()
        //{
        //    return Date.ToShortDateString() + " " + Time.ToShortTimeString();
        //}
       
    }
}
