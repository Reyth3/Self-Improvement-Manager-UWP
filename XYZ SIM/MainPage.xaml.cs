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
using XYZ_SIM.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XYZ_SIM
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = GlobalContext.Current;
        }

        private void NavigationViewItemSelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            HamburgerMenuItem item = args.SelectedItem as HamburgerMenuItem;
            if (item.DestinationPage != null)
                frameView.Navigate(item.DestinationPage);
            else item.DestinationAction?.Invoke();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            navigation.SelectedItem = GlobalContext.Current.NavigationItems.First();
        }
    }
}
