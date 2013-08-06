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
       
    }
}