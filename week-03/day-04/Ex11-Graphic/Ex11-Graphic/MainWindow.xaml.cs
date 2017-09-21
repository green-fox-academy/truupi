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

namespace Ex11_Graphic
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
            foxDraw.DrawLine(0, canvas.Height / 3, canvas.Width, canvas.Height / 3);
            foxDraw.DrawLine(0, canvas.Height / 3 * 2, canvas.Width, canvas.Height / 3 * 2);
            foxDraw.DrawLine(canvas.Width / 3, 0, canvas.Width / 3, canvas.Height);
            foxDraw.DrawLine(canvas.Width / 3 * 2, 0, canvas.Width / 3 * 2, canvas.Height);
        }
    }
}
