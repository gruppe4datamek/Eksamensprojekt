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
    public sealed partial class DenRødeTråd : Page
    {
        public DenRødeTråd()
        {
            this.InitializeComponent();
        }

        private void Popup1_OnClick(object sender, RoutedEventArgs e)
        {
            this.Popup1.IsOpen = !this.Popup1.IsOpen;
        }

        private void MainPage_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void HamburgerButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.mySplitView.IsPaneOpen = !this.mySplitView.IsPaneOpen;
        }

        public void LadDerVæreLyd(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LadDerVaereLys));
        }

        public void Skælv(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Skælv));
        }

        public void MusikalskeStrømme(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MusikalskeStroemme));

        }

        public void Fandrenge_fanpiger(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Fandrenge__Fanpiger));
        }

        public void ElektriskIntimitet(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ElektriskIntimitet));
        }

        public void DenFedeLyd(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(JagtenPaaDenFedeLyd));
        }
        private void DanseFeber(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DanseFeber));
        }
    }
}
//TEst
