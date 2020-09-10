using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace F4MPLauncher
{
    public partial class Entry : Window
    {
        public Entry()
        {
            Debug.WriteLine("Entry startup");

            InitializeComponent();
        }

        private void Minimise_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Minimising");
            this.WindowState = WindowState.Minimized;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Close");
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Allows window to be moved without the titlebars
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Playclick");
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            webBrowser.Navigate("https://f4mp.net");
            webBrowser.Visibility = Visibility.Visible;
        }
    }
}
