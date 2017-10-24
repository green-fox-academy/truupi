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

namespace Ex13_Checkerboard
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
            Checkerboard(foxDraw);
        }

        public void Checkerboard(FoxDraw foxDraw)
        {
            bool color = true;
            double x = 0;
            double y = 0;
            double size = 30;

            for (int i = 0; i < 10; i++)
            {
                x = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (color)
                    {
                        foxDraw.FillColor(Colors.Black);
                        color = false;
                    }
                    else if (!color)
                    {
                        foxDraw.FillColor(Colors.White);
                        color = true;
                    }    

                    Drawer(x, y, size, foxDraw);
                    x += size;
                }
                y += size;
                if (color)
                {
                    color = false;
                }
                else if (!color)
                {
                    color = true;
                }
            }
        }

        public void Drawer(double x, double y, double size, FoxDraw foxDraw)
        {
            foxDraw.DrawRectangle(x, y, size, size);
        }
    }
}
