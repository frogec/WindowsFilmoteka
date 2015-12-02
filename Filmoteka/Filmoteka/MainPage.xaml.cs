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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Filmoteka
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Frame.Navigate(typeof (Home));
            TextBlockTitle.Text = "Home";
        }

        private void ButtonHamburger_OnClick(object sender, RoutedEventArgs e)
        {
            SplitView.IsPaneOpen = !SplitView.IsPaneOpen;
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected)
            {
                Frame.Navigate(typeof (Home));
                TextBlockTitle.Text = "Home";
            }
            else if (Movies.IsSelected)
            {
                Frame.Navigate(typeof (Movies));
                TextBlockTitle.Text = "Movies";
            }
            else if (Settings.IsSelected)
            {
                Frame.Navigate(typeof(Settings));
                TextBlockTitle.Text = "Settings";
            }

        }
    }
}
