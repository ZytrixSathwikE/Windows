using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using My_Medi.Resources;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
//using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using SQLite;
using Windows.Storage;
using System.IO;
using System.Diagnostics;
using System.Collections.ObjectModel;


namespace My_Medi
{
    public partial class MainPage : PhoneApplicationPage
    {
        
        // Constructor
        public MainPage()
        {
            
            
            InitializeComponent();
            CreateDatabase();
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
            

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();

        }

        public void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }
            
      

        // Load data for the ViewModel Items
        //protected override void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    if (!App.ViewModel.IsDataLoaded)
        //    {
        //        App.ViewModel.LoadData();
        //    }
        //}
        private async void CreateDatabase()
        {
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection(Path.Combine(ApplicationData.Current.LocalFolder.Path, "people.db"), true);
            await conn.CreateTableAsync<Person>();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/Add_appointment.xaml", UriKind.Relative));
            Popup popup = new Popup();
            popup.Height = 300;
            popup.Width = 400;
            popup.VerticalOffset = 100;
            Add_appointment control = new Add_appointment();
            popup.Child = control;
            popup.IsOpen = true;
            //control.btnOK.Click += (s, args) =>
            //{
            //    SQLiteAsyncConnection conn = new SQLiteAsyncConnection(Path.Combine(ApplicationData.Current.LocalFolder.Path, "people.db"), true);

            //    Person person = new Person
            //    {
            //        DoctorName = control.watermarkTextBox.Text,
            //        Date = DateTime.Now
            //        //Date = datepick.Value.Value
            //    };

            //    await conn.InsertAsync(person);

            //    Popup popup = new Popup();
            //    (this.Parent as Popup).IsOpen = false;
            //};
        }


       
 

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}