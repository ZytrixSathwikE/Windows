using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SQLite;
using Windows.Storage;
using System.IO;

namespace My_Medi
{
    public partial class Add_appointment : UserControl
    {
        public Add_appointment()
        {
            InitializeComponent();
        }
        private void DatePicker_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {

        }

       private void btnOK_Click(object sender, RoutedEventArgs e)
      {
    //        SQLiteAsyncConnection conn = new SQLiteAsyncConnection(Path.Combine(ApplicationData.Current.LocalFolder.Path, "people.db"), true);

    //        Person person = new Person
    //        {
    //            Name = "Matteo",
    //            Surname = "Pagani"
    //        };

    //        await conn.InsertAsync(person);
       }
    }
}
