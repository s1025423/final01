using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Ink;
using System.Windows.Forms;
using System.Drawing;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
            mydraw = this.ink1;
            var fullFilePath = @"C:\Study\人機介面\教材\DTUI5_chap14\投影片1.JPG";

            FileInfo fi = new FileInfo(fullFilePath);


            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            image1.Source = bitmap;

            

        }
       

        

        public InkCanvas mydraw;
        

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.Ink;
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Black;
            da.Width = 1;
            mydraw.DefaultDrawingAttributes = da;
        }
             private void button2_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.Ink;
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Red;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.Ink;
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Red;
            da.Width = 1;
            mydraw.DefaultDrawingAttributes = da;
        }
            private void button4_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.Ink;
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Green;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }
            private void button5_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.Ink;
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Green;
            da.Width = 1;
            mydraw.DefaultDrawingAttributes = da;
        }

        

       

        

        

        

            private void button6_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

            private void button7_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        

            private void button8_Click(object sender, RoutedEventArgs e)
        {
            var fullFilePath = @"C:\Study\人機介面\教材\DTUI5_chap14\投影片2.JPG";

            FileInfo fi = new FileInfo(fullFilePath);


            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            image1.Source = bitmap;

     }
            private void button9_Click(object sender, RoutedEventArgs e)
        {

            var fullFilePath = @"C:\Study\人機介面\教材\DTUI5_chap14\投影片3.JPG";

            FileInfo fi = new FileInfo(fullFilePath);


            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            image1.Source = bitmap;
            
        }

        private void ink1_Gesture(object sender, InkCanvasGestureEventArgs e)
{

}
       
        }
    }


