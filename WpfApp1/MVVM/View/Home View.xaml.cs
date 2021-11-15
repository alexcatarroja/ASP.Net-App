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
    /// Interaction logic for Home_View.xaml
    /// </summary>
    public partial class Home_View : UserControl
    {
        public Home_View()
        {
            InitializeComponent();

            string filePath = @"C:\Users\Accat\source\repos\C#\Projects\WpfApp1\WpfApp1\Images\Data.txt";
            string formaT;
            int store_ = 0;
            int lastdex = 0;
            List<string> lines = File.ReadAllLines(filePath).ToList();

            lastdex = lines.Count;
            store_ = lastdex - 1;
            formaT = "$" + lines[store_] + ".00";
            Block.Content = formaT;
        }

    }
}
