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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Eksamensprojekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Skælv : Page
    {
        public Skælv()
        {
            this.InitializeComponent();
        }
        private void HamburgerButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.mySplitView.IsPaneOpen = !this.mySplitView.IsPaneOpen;
        }

        private void MainPage_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        public void Popup1_OnClick(object sender, RoutedEventArgs e)
        {
            this.Popup1.IsOpen = !this.Popup1.IsOpen;
        }


        public void LadDerVæreLys(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LadDerVaereLys));
        }

        public void Dansefeber(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DanseFeber));
        }

        public void MusikalskeStrømme(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MusikalskeStroemme));

        }

        public void Fandrenge_Fanpiger(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Fandrenge__Fanpiger));
        }

        public void DenRødeTråd(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DenRødeTråd));
        }

        public void ElektriskIntimitet(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ElektriskIntimitet));
        }

        public void DenFedeLyd(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(JagtenPaaDenFedeLyd));
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
