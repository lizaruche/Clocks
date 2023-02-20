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
using System.Timers;
using System.Windows.Threading;

namespace Clocks
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer timer = new Timer(1000);
        public MainWindow()
        {
            InitializeComponent();

            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Enabled = true;
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _ = Dispatcher.Invoke(DispatcherPriority.Normal, (Action)(() =>
              {
                  secondHand.Angle = DateTime.Now.Second * 6;
                  minuteHand.Angle = DateTime.Now.Minute * 6;
                  hourHand.Angle = (DateTime.Now.Hour * 30) + (DateTime.Now.Minute * 0.5);
              }));
        }
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            for (int i = 0; i < 60; ++i)
            {
                Rectangle marker = new Rectangle();
                if (i % 5 == 0)
                {
                    TextBlock num = new TextBlock();
                    int curNum = i == 0 ? 12 : i / 5;

                    num.Text = curNum.ToString();
                    num.TextAlignment = TextAlignment.Center;
                    num.RenderTransformOrigin = new Point(1, 1);
                    num.Foreground = Brushes.White;
                    num.FontSize = 4;

                    num.RenderTransform = new ScaleTransform(2, 2);

                    double r = 34;
                    double angle = Math.PI * curNum * 30.0 / 180.0;
                    double x = Math.Sin(angle) * r + 50, y = -Math.Cos(angle) * r + 50;

                    Canvas.SetLeft(num, x);
                    Canvas.SetTop(num, y);

                    cnv.Children.Add(num);

                    marker.Width = 1.5;
                    marker.Height = 6;
                    marker.Fill = new SolidColorBrush(Color.FromArgb(0xe0, 0xff,
                    0xff, 0xff));
                    marker.Stroke = new SolidColorBrush(Color.FromArgb(0x80, 0x33,
                    0x33, 0x33));
                    marker.StrokeThickness = 0.5;
                }
                else
                {
                    marker.Width = 0.5;
                    marker.Height = 3;
                    marker.Fill = new SolidColorBrush(Color.FromArgb(0x80, 0xff,
                    0xff, 0xff));
                }
                TransformGroup transforms = new TransformGroup();

                transforms.Children.Add(new TranslateTransform(-(marker.Width / 2),
                marker.Width / 2 - 40 - marker.Height));
                transforms.Children.Add(new RotateTransform(i * 6));
                transforms.Children.Add(new TranslateTransform(50, 50));

                marker.RenderTransform = transforms;

                cnv.Children.Add(marker);
            }
        }
    }
}
