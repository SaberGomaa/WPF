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
    /// Interaction logic for BindingToEmployeeList.xaml
    /// </summary>
    public partial class BindingToEmployeeList : Window
    {
        public Employee Emp { get; set; }
        public BindingToEmployeeList()
        {
            InitializeComponent();
            
           //Emp= EmployeeList.Emps[1];

            //ID.DataContext = Emp;
            //Name.DataContext = Emp;
            //Age.DataContext = Emp;
            //Jop.DataContext = Emp;

            //EmpPanal.DataContext = Emp;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(index.Text);
            Emp = EmployeeList.Emps[x];
            EmpPanal.DataContext = Emp;

        }
    }
}
