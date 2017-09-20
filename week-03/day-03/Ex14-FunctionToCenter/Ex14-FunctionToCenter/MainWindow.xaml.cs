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

namespace Ex14_FunctionToCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Random rnd = new Random();

        public MainWindow()
        {

            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            int x = 0;
            int y = 0;
            int size = 10;

            for (int i = 0; i <= 1; i++)
            {
                for (x = 0; x <= canvas.Width; x += size)
                {
                    StartPoint(x, y, foxDraw);
                }
                y = 300;
            }

            y = 0;
            for (int i = 0; i <= 1; i++)
            {
                for (x = 0; x <= canvas.Height; x += size)
                {
                    StartPoint(y, x, foxDraw);
                }
                y = 300;
            }
        }

        public void StartPoint(int x, int y, FoxDraw foxDraw)
        {
            Color randomColor = Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));
            foxDraw.StrokeColor(randomColor);
            foxDraw.DrawLine(x, y, canvas.Width/2, canvas.Height/2);
        }
    }
}
