using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace F4MPLauncher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static double GeorgesPenisSize = 6.9d;
        private void Main(object sender, StartupEventArgs e)
        {
            // Initialize database here
            // Asyncronusly initialize connection to catalouge server

            // If token is present, validate with CA
            // On game start get session token from CA

            // If token is not present or validation failed show login with steam screen

            // Instead of having login screen the play button could just be greyed out until user has logged in


            Entry window = new Entry();
            window.Title = "F4MP Launcher";
            window.Show();
        }
    }
}
