using System.Windows;
using System.Windows.Media;

namespace WindowAppLilechka
{
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            SetTrafficLightColor(Colors.Red);
        }

        private void YellowButton_Click(object sender, RoutedEventArgs e)
        {
            SetTrafficLightColor(Colors.Yellow);
        }

        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {
            SetTrafficLightColor(Colors.Green);
        }

        private void SetTrafficLightColor(Color color)
        {
            RedLight.Fill = new SolidColorBrush(Colors.Gray);
            YellowLight.Fill = new SolidColorBrush(Colors.Gray);
            GreenLight.Fill = new SolidColorBrush(Colors.Gray);

            if (color == Colors.Red)
                RedLight.Fill = new SolidColorBrush(Colors.Red);
            else if (color == Colors.Yellow)
                YellowLight.Fill = new SolidColorBrush(Colors.Yellow);
            else if (color == Colors.Green)
                GreenLight.Fill = new SolidColorBrush(Colors.Green);
        }
    }
}
