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

namespace Drawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point startPoint;
        private Shape currentShape;
        private SolidColorBrush currentBrush = Brushes.Black;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(canvas);

            if (currentShape != null)
            {
                canvas.Children.Add(currentShape);
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && currentShape != null)
            {
                Point currentPoint = e.GetPosition(canvas);

                if (currentShape is Rectangle)
                {
                    DrawRectangle(startPoint, currentPoint, (Rectangle)currentShape);
                }
                // ...
                // TODO
                
            }
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            currentShape = null;
        }

        private void DrawRectangle(Point start, Point end, Rectangle rectangle)
        {
            // TODO
        }

        private void DrawEllipse(Point start, Point end, Ellipse ellipse)
        {
            // TODO
        }

        private void DrawLine(Point start, Point end, Line line)
        {
            // TODO
        }


        private void RectangleButton_Click(object sender, RoutedEventArgs e)
        {
            currentShape = new Rectangle
            {
                Stroke = currentBrush,
                StrokeThickness = 1
            };
        }

        private void CircleButton_Click(object sender, RoutedEventArgs e)
        {
            currentShape = new Ellipse
            {
                Stroke = currentBrush,
                StrokeThickness = 1
            };
        }

        private void LineButton_Click(object sender, RoutedEventArgs e)
        {
            currentShape = new Line
            {
                Stroke = currentBrush,
                StrokeThickness = 1
            };
        }
    }

}

