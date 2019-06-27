using MilitarySymbolExplorer.Wpf.Extensions;
using MilitarySymbolExplorer.Wpf.Infrastructure;
using MilitarySymbolExplorer.Wpf.Symbology;
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
            var sym = new Symbol();
            Console.WriteLine(sym);
        }
    }
    enum Test
    {
        [StringAttribute("011")] A = 011,
        [StringAttribute("03")] B = 03,
        C = 4
    }
}
