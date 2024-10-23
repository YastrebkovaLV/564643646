using System.Windows;

namespace WindowAppLilechka
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void DontPressButton_Click(object sender, RoutedEventArgs e)
        {
            GreetingText.Text = "Написано же – не нажимать!";
            DontPressButton.Visibility = Visibility.Hidden;
        }
    }
}

