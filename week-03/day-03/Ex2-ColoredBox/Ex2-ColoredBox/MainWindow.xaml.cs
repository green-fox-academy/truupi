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
using GreenFox;

namespace Ex2_ColoredBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxie = new FoxDraw(canvas);

            foxie.BackgroundColor(Colors.Black);
            foxie.StrokeColor(Colors.Red);
            foxie.DrawLine(50, 50, 150, 50);
            foxie.StrokeColor(Colors.Green);
            foxie.DrawLine(150, 50, 150, 150);
            foxie.StrokeColor(Colors.Yellow);
            foxie.DrawLine(150, 150, 50, 150);
            foxie.StrokeColor(Colors.Blue);
            foxie.DrawLine(50, 150, 50, 50);
        }
    }
}
