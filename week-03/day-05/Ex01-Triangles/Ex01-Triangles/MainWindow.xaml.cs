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

namespace Ex01_Triangles
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
            Drawer(foxDraw, 0, 0, canvas.Width, canvas.Height, 8);
        }

        public void Drawer(FoxDraw foxDraw, double startx, double starty, double endx, double endy, int depth)
        {
            foxDraw.DrawLine(startx, starty, endx, starty);
            foxDraw.DrawLine(startx, starty, startx + (endx - startx) / 2, endy);
            foxDraw.DrawLine(endx, starty, startx + (endx - startx) / 2, endy);

            depth--;

            if (depth > 0)
            {
                Drawer(foxDraw, startx, starty, startx + (endx - startx) / 2, starty + (endy - starty) / 2, depth);
                Drawer(foxDraw, startx + (endx - startx) / 2, starty, endx, starty + (endy - starty) / 2, depth);
                Drawer(foxDraw, startx + (endx - startx) / 4, starty + (endy - starty) / 2, startx + (endx - startx) / 4 * 3, endy, depth);
            }
        }
    }
}
