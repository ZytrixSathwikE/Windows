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
//using System.Windows.Controls.Primitives;
using System.Windows.Controls.Primitives;

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

       private async void btnOK_Click(object sender, RoutedEventArgs e)
      {
          SQLiteAsyncConnection conn = new SQLiteAsyncConnection(Path.Combine(ApplicationData.Current.LocalFolder.Path, "people.db"), true);

          Person person = new Person
          {
              DoctorName = watermarkTextBox.Text,
              Date = datepick.Value.Value
          };

          await conn.InsertAsync(person);

          Popup popup = new Popup();
           (this.Parent as Popup).IsOpen = false;
          
       }
    }
}
