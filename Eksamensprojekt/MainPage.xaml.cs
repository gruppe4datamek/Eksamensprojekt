using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Eksamensprojekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.mySplitView.IsPaneOpen = !this.mySplitView.IsPaneOpen;
        }

        private void Rum1_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LadDerVaereLys));
        }
        private void Rum2_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DanseFeber));
        }
        private void Rum3_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Skælv));
        }
        private void Rum4_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MusikalskeStroemme));
        }

        private void Rum5_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Fandrenge__Fanpiger));
        }

        private void Rum6_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DenRødeTråd));
        }
    }
}
