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
using WpfApp_BubblingAndTunnelingEvents.ViewModel;

namespace WpfApp_BubblingAndTunnelingEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ModelViewMV();
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"Sender is {sender}");
        }

        private void StackPanel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"Sender is {sender}");
        }

        private void StackPanel_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"The sender is {sender}");
        }

        private void Button_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"The sender is {sender}");
        }
    }
}
