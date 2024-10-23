using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WindowAppLilechka
{
    public partial class Window3 : Window
    {
        private Random random = new Random();

        public Window3()
        {
            InitializeComponent();
        }

        private void ChaseButton_Click(object sender, RoutedEventArgs e)
        {
            double left = random.Next(0, (int)(MainCanvas.ActualWidth - ChaseButton.ActualWidth));
            double top = random.Next(0, (int)(MainCanvas.ActualHeight - ChaseButton.ActualHeight));
            Canvas.SetLeft(ChaseButton, left);
            Canvas.SetTop(ChaseButton, top);
        }
    }
}
