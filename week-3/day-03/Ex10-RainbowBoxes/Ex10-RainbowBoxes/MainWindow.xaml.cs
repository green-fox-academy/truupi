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

namespace Ex10_RainbowBoxes
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
            var foxDraw = new FoxDraw(canvas);

            for (int i = 250; i > 0; i -= 5)
            {
                RectangleDrawer(i, foxDraw, RandomColorGenerator());
            }
        }

        public Color RandomColorGenerator()
        {
            var randomColor = Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));
            return randomColor;
        }

        public void RectangleDrawer(double size, FoxDraw foxDraw, Color color)
        {
            double halfwidth = canvas.Width / 2;
            double halfheigth = canvas.Height / 2;
            foxDraw.FillColor(color);
            foxDraw.DrawRectangle(halfwidth - size / 2, halfheigth - size / 2, size, size);
        }
    }
}
