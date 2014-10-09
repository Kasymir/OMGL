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
using System.Drawing;

namespace codeChromatique
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void setColor(String c)
        {
            color.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(c));
            lbl.Content = c;
        }

        private void setColor(byte a, byte r, byte g, byte b)
        {
            color.Background = new SolidColorBrush(Color.FromArgb(a, r, g, b));
            lbl.Content = r + " " + g + " " + b;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //setColor((Color)ColorConverter.ConvertFromString("#FFDFD991"));
            setColor("#DFD992");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            byte[] colorRGB = new byte[4];
            lba.Content = HexConverter((Color)ColorConverter.ConvertFromString("#DFD992"));
            //colorRGB = RGBConverter();
            a.Content = colorRGB[0];
            R.Content = colorRGB[1];
            G.Content = colorRGB[2];
            B.Content = colorRGB[3];

            setColor(colorRGB[0], colorRGB[1], colorRGB[2], (byte)(colorRGB[3] + 1));
        }

        private static String HexConverter(Color c)
        {
            String rtn = String.Empty;
            try
            {
                rtn = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            }
            catch (Exception ex)
            {
                //doing nothing
            }
            return rtn;
        }
        private static byte[] RGBConverter(Color c)
        {
            byte[] rtn = new byte[4];
            try
            {
                rtn[0] = (byte)c.A;
                rtn[1] = (byte)c.R;
                rtn[2] = (byte)c.G;
                rtn[3] = (byte)c.B;
            }
            catch (Exception ex)
            {
                //doing nothing
            }
            return rtn;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lbl.Content = color.Background;
        }

    }
}
