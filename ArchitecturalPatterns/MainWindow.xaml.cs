using ArchitecturalPatterns.Views;
using System;
using System.Collections.Generic;
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

namespace ArchitecturalPatterns
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

        private MvcView _mvc = new MvcView();
        private MvpView _mvp = new MvpView();
        private MvvmView _mvvm = new MvvmView();

        private void ToggleButton_MVC_Click(object sender, RoutedEventArgs e)
        {
            Frame_Main.Navigate(_mvc);
            ToggleButton_MVC.IsChecked = true;
            ToggleButton_MVP.IsChecked = false;
            ToggleButton_MVVM.IsChecked = false;
        }

        private void ToggleButton_MVP_Click(object sender, RoutedEventArgs e)
        {

            Frame_Main.Navigate(_mvp);
            ToggleButton_MVC.IsChecked = false;
            ToggleButton_MVP.IsChecked = true;
            ToggleButton_MVVM.IsChecked = false;
        }

        private void ToggleButton_MVVM_Click(object sender, RoutedEventArgs e)
        {
            Frame_Main.Navigate(_mvvm);
            ToggleButton_MVC.IsChecked = false;
            ToggleButton_MVP.IsChecked = false;
            ToggleButton_MVVM.IsChecked = true;
        }
    }
}
