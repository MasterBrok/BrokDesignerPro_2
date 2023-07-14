using BrokDesignerPro_2.Controls;
using System.Windows;
using System.Windows.Input;

namespace BrokDesignerPro_2.Windows
{
    /// <summary>
    /// Interaction logic for BrokWindow.xaml
    /// </summary>
    public partial class BrokWindow : Window
    {
        public BrokWindow()
        {
            InitializeComponent();
            
        }

        private void wBrok_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void spMovies_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var movie in new Data.Data().Movies)
            {
                ccMovie element = new ccMovie() { DataContext = movie};
                spMovies.Children.Add(element);
            }
        }

        private void crpRight_Click(object sender, RoutedEventArgs e)
        {
            svItems.LineRight();

        }

        private void crpLeft_Click(object sender, RoutedEventArgs e)
        {
            svItems.LineLeft();
        }

        private void spTitleMovies_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var movie in new Data.Data().Movies)
            {
                ccMovie element = new ccMovie() { DataContext = movie };
                spTitleMovies.Children.Add(element);
            }
        }
    }
}
