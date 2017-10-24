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

namespace Ex11_RecursorRect
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
            foxDraw.FillColor(Colors.Yellow);
            foxDraw.DrawRectangle(0, 0, canvas.Width, canvas.Height);
            Drawer(foxDraw, 0, 0, canvas.Width, canvas.Height, 5);
        }

        public void Drawer(FoxDraw foxDraw, double startx, double starty, double endx, double endy, int depth)
        {
            foxDraw.DrawLine(startx + (endx - startx) / 3, starty, startx + (endx - startx) / 3, endy);
            foxDraw.DrawLine(startx + (endx - startx) / 1.5, starty, startx + (endx - startx) / 1.5, endy);
            foxDraw.DrawLine(startx, starty +(endy - starty) / 3, endx, starty +(endy - starty) / 3);
            foxDraw.DrawLine(startx, starty +(endy - starty) / 1.5, endx, starty +(endy - starty) / 1.5);

            depth--;

            if (depth > 0)
            {
                Drawer(foxDraw, startx + (endx - startx) / 3, starty, startx + (endx - startx) / 1.5, starty + (endy - starty) / 3, depth);
                Drawer(foxDraw, startx + (endx - startx) / 3, starty + (endy - starty) / 1.5, startx + (endx - startx) / 1.5, endy, depth);
                Drawer(foxDraw, startx, starty + (endy - starty) / 3, startx + (endx - startx) / 3, starty + (endy - starty) / 1.5, depth);
                Drawer(foxDraw, startx + (endx - startx) / 1.5, starty + (endy - starty) / 3, endx, starty + (endy - starty) / 1.5, depth);
            }
        }
    }
}
