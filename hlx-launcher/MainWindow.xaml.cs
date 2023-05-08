using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace hlx_launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void windowDrag(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void minimizeAppButton(object sender, RoutedEventArgs e)
        {
            Window mainWindow = Application.Current.MainWindow;
            mainWindow.WindowState = WindowState.Minimized;
        }

        private void exitAppButton(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /*
        private void playButtonBtn(object sender, RoutedEventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam");
            if (key != null)
        {
        string steamPath = key.GetValue("SteamPath").ToString();
        outputTextBlock.Text += "Steam path:\n" + steamPath + "\n" + "Launching steam.exe\n\n";

        string steamExePath = steamPath + "\\Steam.exe";

        if (System.IO.File.Exists(steamExePath))
        {
          Process.Start(steamExePath);
        }
        else
        {
          outputTextBlock.Text += "Steam.exe is not found.\n\n";
        }
        }
        else
        {
            outputTextBlock.Text += "Steam is not installed or not found.\n\n";
        }
        }
        */
    }
}
