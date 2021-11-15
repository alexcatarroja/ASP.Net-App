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
using System.IO;

namespace WpfApp1.MVVM.View
{
    /// <summary>
    /// Interaction logic for DiscoveryView.xaml
    /// </summary>
    public partial class DiscoveryView : UserControl
    {

        public DiscoveryView()
        {
            InitializeComponent();
        }

        private static string userLogin;


        private void Button_Click(object sender, RoutedEventArgs e)
        {



            // initial values
            string content1 = MonthlySalary.Text;
            string content2 = "0";


            // change to float 
           double monthlySalary = double.Parse(content1);
           double savingsSpent = double.Parse(content2);

            // declare variables
            double wants = 0;
            double needs = 0;
            double savings = 0;

            // math
            savings = monthlySalary * .20;
            wants = monthlySalary * .30;
            needs = monthlySalary * .50;

            //output
            Savings.Content = "Savings: " + savings;
            Wants.Content = "Wants: " + wants;
            Necessities.Content = "Needs " + needs;


            string filePath = @"C:\Users\Accat\source\repos\C#\Projects\WpfApp1\WpfApp1\Images\Data.txt";


            List<string> lines = File.ReadAllLines(filePath).ToList();


            lines.Add(wants.ToString());

            File.WriteAllLines(filePath, lines);
        }


    }
}
