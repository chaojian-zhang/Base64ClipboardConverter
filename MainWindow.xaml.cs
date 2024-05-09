using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Base64ClipboardConverter
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

        private void Window_Activated(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                BitmapSource source = Clipboard.GetImage();
                ImageControl.Source = source;
            }
        }
        private static BitmapImage ConvertToBigmapImage(BitmapSource bitmapSource)
        {
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            MemoryStream memoryStream = new MemoryStream();
            BitmapImage image = new BitmapImage();

            encoder.Frames.Add(BitmapFrame.Create(bitmapSource));
            encoder.Save(memoryStream);

            memoryStream.Position = 0;
            image.BeginInit();
            image.StreamSource = memoryStream;
            image.EndInit();

            memoryStream.Close();
            return image;
        }
    }
}