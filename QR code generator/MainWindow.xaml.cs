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
using QRCoder;
using QRCoder.Xaml;

namespace QR_code_generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string zadanyText = textboxInput.Text;
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();

            QRCodeData dataQRkodu = qRCodeGenerator.CreateQrCode(zadanyText, QRCodeGenerator.ECCLevel.M);

            XamlQRCode qrKod = new XamlQRCode(dataQRkodu);

            DrawingImage vkladnyObrazek = qrKod.GetGraphic(30);
            obrazek.Source = vkladnyObrazek;
        }

        private void textboxInput_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            textboxInput.Text = "";
        }
    }
}
