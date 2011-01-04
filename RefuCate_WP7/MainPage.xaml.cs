﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace RefuCate_WP7
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            if (chk_save.IsChecked == true)
            {
                Utils.SaveUserSettings((App.Current.RootVisual as PhoneApplicationFrame).DataContext as Settings);
            }
            else
            {
                Utils.ClearUserSettings();
            }
            NavigationService.Navigate(new Uri("/CapturePage.xaml", UriKind.Relative));
        }
    }
}
