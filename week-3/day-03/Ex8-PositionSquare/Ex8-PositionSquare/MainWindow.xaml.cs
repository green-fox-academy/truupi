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

namespace Ex8_PositionSquare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            StartPoint(rnd.Next(200), rnd.Next(200));
            StartPoint(rnd.Next(200), rnd.Next(200));
            StartPoint(rnd.Next(200), rnd.Next(200));
        }

        public static Color RandomColorGenerator()
        {
            var randomColor = Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));
            return randomColor;
        }

        public void StartPoint(int x, int y)
        {
            var foxDraw = new FoxDraw(canvas);
            Color randomColor = Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));
            foxDraw.FillColor(randomColor);
            foxDraw.DrawRectangle(x, y, 50, 50);
        }
    }
}
