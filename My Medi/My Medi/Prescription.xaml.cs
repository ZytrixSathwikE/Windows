using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

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



        }

        

        private void Gird1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/prescriptiondetails.xaml", UriKind.Relative));
        }
    }
}