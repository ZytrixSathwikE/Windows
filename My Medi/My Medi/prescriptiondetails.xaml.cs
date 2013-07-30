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
using System.IO;
using Windows.Storage;

namespace My_Medi
{
    public partial class prescriptiondetails : PhoneApplicationPage
    {
        public prescriptiondetails()
        {
            InitializeComponent();
        }

        private async void btnOK_Click(object sender, RoutedEventArgs e)
        {
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection(Path.Combine(ApplicationData.Current.LocalFolder.Path, "people.db"), true);

            prescription1 prescription1 = new prescription1
            {
               Temperature=watermarkTextBox.Text,
               Bp=watermarkTextBox1.Text,
               symptoms=watermarkTextBox2.Text,
               description=watermarkTextBox3.Text,
               user_id=App.userid1
             };

            await conn.InsertAsync(prescription1);
        }


    }
}