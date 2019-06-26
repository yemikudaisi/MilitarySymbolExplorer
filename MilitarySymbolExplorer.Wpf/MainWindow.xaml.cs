using MilitarySymbolExplorer.Wpf.Extensions;
using MilitarySymbolExplorer.Wpf.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MilitarySymbolExplorer.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine(Test.A.GetString());
            Console.WriteLine(Test.B.GetString());
            Console.WriteLine(Test.C.GetString());
        }
    }
    enum Test
    {
        [StringAttribute("011")] A = 011,
        [StringAttribute("03")] B = 03,
        C = 4
    }
}
