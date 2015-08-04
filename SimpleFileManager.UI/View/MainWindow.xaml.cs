using System;
using System.Windows;
using SimpleFileManager.UI.ViewModel;

namespace SimpleFileManager.UI.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel windowViewModel = new MainWindowViewModel();
            DataContext = windowViewModel;            

            driveButtons.ItemsSource = windowViewModel.Drives;
        }
    }
}
