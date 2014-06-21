using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Linq;
using System.Linq.Expressions;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using Windows.UI.Xaml.Shapes;

namespace Adorners
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            tbRenderSize.Text = string.Format("W:{0} H:{1}", imgTest.RenderSize.Width, imgTest.RenderSize.Height);

            tbRealSize.Text = string.Format("W: {0}, H: {1}", imgTest.DesiredSize.Width, imgTest.Height);

            var ttv = imgTest.TransformToVisual(Window.Current.Content);
            Point screenCoords = ttv.TransformPoint(new Point(0, 0));


            tbAbsolutePosition.Text = string.Format("X: {0}, Y: {1}", screenCoords.X,screenCoords.Y);

            //imgTest = new Rectangle();
            //imgTest.Width = imgTest.Width;
            //imgTest.Height = imgTest.Height;
            //imgTest.Opacity = 0.5;
            //imgTest.Fill = new SolidColorBrush(Colors.Yellow);
            //imgTest.Stroke = new SolidColorBrush(Colors.Red);
            //imgTest.StrokeThickness = 5;
            
            
            //imgTest.SetValue(Canvas.TopProperty, imgTest.GetValue(Canvas.TopProperty));
            //imgTest.SetValue(Canvas.LeftProperty,imgTest.GetValue(Canvas.LeftProperty));
            
            //paintArea.Children.Add(imgTest);

            _posMarkerSmall = new Rectangle();
            _posMarkerSmall.Width = 40;
            _posMarkerSmall.Height = 40;
            _posMarkerSmall.Opacity = 0.5;
            _posMarkerSmall.Fill = new SolidColorBrush(Colors.Red);
            _posMarkerSmall.Stroke = new SolidColorBrush(Colors.Yellow);
            _posMarkerSmall.StrokeThickness = 2;
            _posMarkerSmall.Name = "leftTop";

            _posMarkerSmall2 = new Rectangle();
            _posMarkerSmall2.Width = 40;
            _posMarkerSmall2.Height = 40;
            _posMarkerSmall2.Opacity = 0.5;
            _posMarkerSmall2.Fill = new SolidColorBrush(Colors.Blue);
            _posMarkerSmall2.Stroke = new SolidColorBrush(Colors.Yellow);
            _posMarkerSmall2.StrokeThickness = 2;
            _posMarkerSmall2.Name = "bottomLeft";

            _posMarkerSmall3 = new Rectangle();
            _posMarkerSmall3.Width = 40;
            _posMarkerSmall3.Height = 40;
            _posMarkerSmall3.Opacity = 0.5;
            _posMarkerSmall3.Fill = new SolidColorBrush(Colors.White);
            _posMarkerSmall3.Stroke = new SolidColorBrush(Colors.Yellow);
            _posMarkerSmall3.StrokeThickness = 2;
            _posMarkerSmall3.Name = "bottomRight";

            _posMarkerSmall4 = new Rectangle();
            _posMarkerSmall4.Width = 40;
            _posMarkerSmall4.Height = 40;
            _posMarkerSmall4.Opacity = 0.5;
            _posMarkerSmall4.Fill = new SolidColorBrush(Colors.SlateBlue);
            _posMarkerSmall4.Stroke = new SolidColorBrush(Colors.Yellow);
            _posMarkerSmall4.StrokeThickness = 2;
            _posMarkerSmall4.Name = "rightTop";



            imgTest.ManipulationCompleted += _posMarker_ManipulationCompleted;

            imgTest.ManipulationDelta += _posMarker_ManipulationDelta;

            imgTest.ManipulationStarted += _posMarker_ManipulationStarted;

            _posMarkerSmall.PointerEntered += posMarkerSmall_PointerEntered;

            _posMarkerSmall2.PointerEntered += posMarkerSmall_PointerEntered;

            _posMarkerSmall3.PointerEntered += posMarkerSmall_PointerEntered;

            _posMarkerSmall4.PointerEntered += posMarkerSmall_PointerEntered;

            imgTest.PointerEntered += posMarker_PointerEntered;

            imgTest.PointerExited += posMarker_PointerExited;

            _posMarkerSmall.PointerExited += posMarkerSmall_PointerExited;

            _posMarkerSmall2.PointerExited += posMarkerSmall_PointerExited;

            _posMarkerSmall3.PointerExited += posMarkerSmall_PointerExited;

            _posMarkerSmall4.PointerExited += posMarkerSmall_PointerExited;




            _posMarkerSmall.ManipulationStarted += _posMarkerSmall_ManipulationStarted;
            _posMarkerSmall2.ManipulationStarted += _posMarkerSmall_ManipulationStarted;
            _posMarkerSmall3.ManipulationStarted += _posMarkerSmall_ManipulationStarted;
            _posMarkerSmall4.ManipulationStarted += _posMarkerSmall_ManipulationStarted;

            _posMarkerSmall.ManipulationCompleted += _posMarkerSmall_ManipulationCompleted;

            _posMarkerSmall2.ManipulationCompleted += _posMarkerSmall_ManipulationCompleted;


            _posMarkerSmall3.ManipulationCompleted += _posMarkerSmall_ManipulationCompleted;


            _posMarkerSmall4.ManipulationCompleted += _posMarkerSmall_ManipulationCompleted;



            imgTest.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;

            _posMarkerSmall.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;
            _posMarkerSmall2.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;
            _posMarkerSmall3.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;
            _posMarkerSmall4.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;


            _posMarkerSmall.ManipulationDelta += posMarkerSmall_ManipulationDelta;
            _posMarkerSmall2.ManipulationDelta += posMarkerSmall_ManipulationDelta;
            _posMarkerSmall3.ManipulationDelta += posMarkerSmall_ManipulationDelta;
            _posMarkerSmall4.ManipulationDelta += posMarkerSmall_ManipulationDelta;


           
          

            paintArea.Children.Add(_posMarkerSmall2);
            paintArea.Children.Add(_posMarkerSmall);
            
            paintArea.Children.Add(_posMarkerSmall3);
            paintArea.Children.Add(_posMarkerSmall4);

            SetHanldePositions();
        
        }

        void _posMarker_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
          

            foreach (var child in paintArea.Children)
            {

                if (child is Rectangle)
                {
                    var currentRect = child as Rectangle;

                   
                        if (currentRect.Name.Contains("top") || currentRect.Name.Contains("bottom") || currentRect.Name.Contains("left") || currentRect.Name.Contains("right"))
                        {
                            currentRect.Visibility = Visibility.Collapsed;
                        }
                    
                }

            }
        }

        void _posMarker_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var _Rectangle = sender as Image;

            _mainTransform = (_Rectangle.RenderTransform as CompositeTransform)
                             ?? (_Rectangle.RenderTransform = new CompositeTransform()) as CompositeTransform;

            _mainTransform.TranslateX += e.Delta.Translation.X;
            _mainTransform.TranslateY += e.Delta.Translation.Y;



        }

     
        void _posMarker_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            Canvas.SetLeft(imgTest, _mainTransform.TranslateX + (double)imgTest.GetValue(Canvas.LeftProperty));
            Canvas.SetTop(imgTest, _mainTransform.TranslateY + (double)imgTest.GetValue(Canvas.TopProperty));

            imgTest.RenderTransform = null;


            SetHanldePositions();



            foreach (var child in paintArea.Children)
            {

                if (child is Rectangle)
                {
                    var currentRect = child as Rectangle;


                    if (currentRect.Name.Contains("top") || currentRect.Name.Contains("bottom") || currentRect.Name.Contains("left") || currentRect.Name.Contains("right"))
                    {
                        currentRect.Visibility = Visibility.Visible;
                        currentRect.RenderTransform = null;
                    }

                }

            }
        }


        private void SetHanldePositions()
        {

            
            _posMarkerSmall.SetValue(Canvas.TopProperty, ((double)imgTest.GetValue(Canvas.TopProperty)) - _posMarkerSmall.Width / 2);
            _posMarkerSmall.SetValue(Canvas.LeftProperty, ((double)imgTest.GetValue(Canvas.LeftProperty)) - _posMarkerSmall.Height / 2);

            //Right, top
            _posMarkerSmall4.SetValue(Canvas.TopProperty, ((double)imgTest.GetValue(Canvas.TopProperty)) - _posMarkerSmall.Width / 2);
            _posMarkerSmall4.SetValue(Canvas.LeftProperty, ((double)imgTest.GetValue(Canvas.LeftProperty)) + imgTest.ActualWidth - _posMarkerSmall.Height / 2);

            //bottom,left
            _posMarkerSmall2.SetValue(Canvas.TopProperty, ((double)imgTest.GetValue(Canvas.TopProperty)) + imgTest.ActualHeight - _posMarkerSmall2.Height / 2);
            _posMarkerSmall2.SetValue(Canvas.LeftProperty, ((double)imgTest.GetValue(Canvas.LeftProperty)) - _posMarkerSmall2.Width / 2);



            //bottom,right
            _posMarkerSmall3.SetValue(Canvas.TopProperty, ((double)imgTest.GetValue(Canvas.TopProperty)) + imgTest.ActualHeight - _posMarkerSmall.Width / 2);
            _posMarkerSmall3.SetValue(Canvas.LeftProperty, ((double)imgTest.GetValue(Canvas.LeftProperty)) + imgTest.ActualWidth - _posMarkerSmall.Height / 2);


        

            paintArea.UpdateLayout();
        }

        void _posMarkerSmall_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {

            //var ttv = imgTest.TransformToVisual(Window.Current.Content);
            //Point screenCoords = ttv.TransformPoint(new Point(0, 0));

            
            //var test = imgTest.GetValue(Canvas.LeftProperty);
            //var test2 = imgTest.GetValue(Canvas.TopProperty);


            Canvas.SetLeft(imgTest,  _transformMarker.TranslateX + (double) imgTest.GetValue(Canvas.LeftProperty));
            Canvas.SetTop(imgTest,  _transformMarker.TranslateY + (double) imgTest.GetValue(Canvas.TopProperty));

            imgTest.RenderTransform = null;
         

            SetHanldePositions();

         

            foreach (var child in paintArea.Children)
            {

                if (child is Rectangle)
                {
                    var currentRect = child as Rectangle;

                  
                        if (currentRect.Name.Contains("top") || currentRect.Name.Contains("bottom") || currentRect.Name.Contains("left") || currentRect.Name.Contains("right"))
                        {
                            currentRect.Visibility = Visibility.Visible;
                            currentRect.RenderTransform = null;
                        }
                    
                }

            }

            
        }

        private void _posMarkerSmall_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
            var rect = (Rectangle) sender;

            foreach (var child in paintArea.Children)
            {

                if (child is Rectangle)
                {
                    var currentRect = child as Rectangle;

                    if (currentRect.Name != rect.Name)
                    {
                        if (currentRect.Name.Contains("top") || currentRect.Name.Contains("bottom") || currentRect.Name.Contains("left") || currentRect.Name.Contains("right"))
                        {
                            currentRect.Visibility = Visibility.Collapsed;
                        }
                    }
                }
                
            }

            
        }

        void posMarkerSmall_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var _Rectangle = sender as Rectangle;
            
            _transform = (_Rectangle.RenderTransform as CompositeTransform)
                         ?? (_Rectangle.RenderTransform = new CompositeTransform()) as CompositeTransform;



            _transformMarker = (imgTest.RenderTransform as CompositeTransform)
                               ?? (imgTest.RenderTransform = new CompositeTransform()) as CompositeTransform;

            

            _transform.TranslateX += e.Delta.Translation.X;
            _transform.TranslateY += e.Delta.Translation.Y;

          


            switch (_Rectangle.Name)
            {
                case "bottomLeft":

                    _transformMarker.TranslateX += e.Delta.Translation.X;
                     //_TransformMarker.TranslateY -= e.Delta.Translation.Y;
                    imgTest.Width -= e.Delta.Translation.X;
                    imgTest.Height -= -e.Delta.Translation.Y;
                    
                    break;
                case "bottomRight":
                    imgTest.Width += e.Delta.Translation.X;
                    imgTest.Height += e.Delta.Translation.Y;
                    break;
                case "leftTop":
                      _transformMarker.TranslateX += e.Delta.Translation.X;
                     _transformMarker.TranslateY += e.Delta.Translation.Y;
                    imgTest.Width -= e.Delta.Translation.X;
                    imgTest.Height -= e.Delta.Translation.Y;

                    break;
                case "rightTop":
                     // _TransformMarker.TranslateX -= e.Delta.Translation.X;
                     _transformMarker.TranslateY += e.Delta.Translation.Y;
                     imgTest.Width += e.Delta.Translation.X;
                    imgTest.Height -= e.Delta.Translation.Y;
                     
                    break;


            }

          

        }

        void posMarker_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Window.Current.CoreWindow.PointerCursor = currentCoreCursor;
        }

        void posMarker_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            currentCoreCursor = Window.Current.CoreWindow.PointerCursor;
            Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.SizeAll, 2);
        }

        private CoreCursor currentCoreCursor = null;
        private Rectangle _posMarker;
        private Rectangle _posMarkerSmall;
        private Rectangle _posMarkerSmall2;
        private Rectangle _posMarkerSmall3;
        private Rectangle _posMarkerSmall4;
        private CompositeTransform _transform;
        private CompositeTransform _transformMarker;
        private CompositeTransform _mainTransform;

        void posMarkerSmall_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Window.Current.CoreWindow.PointerCursor = currentCoreCursor;
        }

        void posMarkerSmall_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            currentCoreCursor = Window.Current.CoreWindow.PointerCursor;

            var rect = (Rectangle) sender;

            switch (rect.Name)
            {
                case "bottomLeft":
                    Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.SizeNortheastSouthwest, 2);
                    break;
                case "bottomRight":
                    Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.SizeNorthwestSoutheast, 2);
                    break;
                case "leftTop":
                    Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.SizeNorthwestSoutheast, 2);
                    break;
                case "rightTop":
                    Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.SizeNortheastSouthwest, 2);
                    break;


            }


           
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

    }
}
