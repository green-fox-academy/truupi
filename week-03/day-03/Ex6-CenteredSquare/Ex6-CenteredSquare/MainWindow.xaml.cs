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

namespace Ex6_CenteredSquare
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

            foxDraw.BackgroundColor(Colors.Black);
            foxDraw.StrokeColor(Colors.Green);
            double halfwidth = canvas.Width / 2;
            double halfheigth = canvas.Height / 2;
            double side = 50;
            foxDraw.DrawLine(halfwidth - side, halfheigth - side, halfwidth + side, halfheigth - side);
            foxDraw.DrawLine(halfwidth + side, halfheigth - side, halfwidth + side, halfheigth + side);
            foxDraw.DrawLine(halfwidth + side, halfheigth + side, halfwidth - side, halfheigth + side);
            foxDraw.DrawLine(halfwidth - side, halfheigth + side, halfwidth - side, halfheigth - side);
        }
    }
}
