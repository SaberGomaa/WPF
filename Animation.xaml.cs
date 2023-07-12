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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Animation.xaml
    /// </summary>
    public partial class Animation : Window
    {
        public Animation()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 200;
            doubleAnimation.To = 300;
            doubleAnimation.Duration = TimeSpan.FromSeconds(3);
            doubleAnimation.FillBehavior = FillBehavior.HoldEnd;

            Rec.BeginAnimation(WidthProperty, doubleAnimation);
            Rec.BeginAnimation(HeightProperty, doubleAnimation);
        }
    }
}
