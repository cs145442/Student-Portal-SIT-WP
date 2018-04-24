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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace testapp
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

       

        private void buttona_Click(object sender, RoutedEventArgs e)
        {
            string temp = tbx.Text; 

            if(temp == "")
            {
                tba.Text = "enter ur name"; //tba is the name of textblock

            }
            else
            {

                tba.Text = temp; //tbx is name of the textbox
                buttonb.Visibility = Windows.UI.Xaml.Visibility.Visible; 
            }
        }

        private void buttonb_Click(object sender, RoutedEventArgs e)
        {
            if(lcd.IsChecked == true)
                tba.Text = "you selected lcd";
            else if(led.IsChecked == true)
                tba.Text += "you selected led";

        }

        private void cmb1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tba.Text = "combobox tapped"; 
        }
    }
}
