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
    public partial class Prescription : PhoneApplicationPage
    {
        public Prescription()
        {
            InitializeComponent();
        }

        int index = 0;
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {

            string selectedIndex = "";
            if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
            {
                index = int.Parse(selectedIndex);
                DataContext = App.ViewModel.Items[index];
            }
            base.OnNavigatedTo(e);

            //(App.Current as App).userid = App.ViewModel.Items[index].Lineone;
            App.userid1 = App.ViewModel.Items[index].Lineone;

        }
       

        

        private void Gird1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/prescriptiondetails.xaml", UriKind.Relative));

            
        }

        private async void btnOK_Click(object sender, RoutedEventArgs e)
        {

            SQLiteAsyncConnection conn = new SQLiteAsyncConnection(Path.Combine(ApplicationData.Current.LocalFolder.Path, "people.db"), true);
            //string[] per = new string[10];
 
            var per=App.ViewModel.Items[index];
            per.LineFive = watermarkTextBox.Text;
            per.Linesix = watermarkTextBox1.Text;
            per.Lineseven = watermarkTextBox2.Text;
            per.Lineeight = watermarkTextBox3.Text;
            Person person = new Person()

            {
                ID=per.Lineone,
                DoctorName=per.Linetwo,
                Date=per.Linethree,
                Time=per.LineFour,
                Temperature=per.LineFive,
                Bp=per.Linesix,
                symptoms=per.Lineseven,
                description=per.Lineeight

            };
           
            await conn.UpdateAsync(person);


            NavigationService.GoBack();
            
        }
    }
}