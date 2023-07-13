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
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for EventType.xaml
    /// </summary>
    public partial class EventType : Window
    {
        public EventType()
        {
            InitializeComponent();
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Window");
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Grid");
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Button");
        }
    }
}
