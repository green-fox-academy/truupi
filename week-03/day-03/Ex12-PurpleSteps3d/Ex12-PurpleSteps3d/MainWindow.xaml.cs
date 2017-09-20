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

namespace Ex12_PurpleSteps3d
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double x = 0;
            double y = 0;
            double size = 0;
            for (int i = 0; i < 7; i++)
            {
                Drawer(x, y, size, foxDraw);
                x += size;
                y += size;
                size += 13;
            }
        }

        public void Drawer(double x, double y, double size, FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Color.FromRgb(153, 51, 255));
            foxDraw.DrawRectangle(x, y, size, size);
        }
    }
}
