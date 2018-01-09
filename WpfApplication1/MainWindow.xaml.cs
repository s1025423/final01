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
        }

        public InkCanvas mydraw;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var fullFilePath = @"C:\Study\th.jpg";

            FileInfo fi = new FileInfo(fullFilePath);

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            image1.Source = bitmap;
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.Ink;
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Black;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.Ink;
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Yellow;
            da.Width = 5;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.Ink;
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Red;
            da.Width = 1;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.Ink;
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Green;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.Ink;
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Blue;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.Ink;
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Purple;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.Ink;
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Gray;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.Select;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            mydraw.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }
    }
}
