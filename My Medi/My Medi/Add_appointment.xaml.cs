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
    public partial class Add_appointment : PhoneApplicationPage
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
                Date = datepick.ValueString,
                Time = timepick.ValueString
             };

            await conn.InsertAsync(person);

            //My_Medi.ViewModels.MainViewModel veiw = new ViewModels.MainViewModel();

            //veiw.LoadData();
            DataContext = App.ViewModel;
            App.ViewModel.Items.Clear();
            App.ViewModel.LoadData();            
            

            NavigationService.GoBack();
            
            


        }

        private void timepick_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {

        }


        private void btncancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }


    
    }

}