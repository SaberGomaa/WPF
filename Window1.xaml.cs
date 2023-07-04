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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            //btn.Background = SystemColors.MenuHighlightBrush;

        }

        private void btn22_Click(object sender, RoutedEventArgs e)
        {
            l1.Content ="new label";
            //l1.Foreground = Brushes.Blue;
            l1.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 255));

        }
        //public void btn_clk()
        //{
        //    l1.SetValue(TagProperty, "label changed");
        //}
    }
}
