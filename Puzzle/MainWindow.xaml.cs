using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Puzzle
{
    public partial class MainWindow : Window
    {
        public static Image global_image;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_Drop(object sender, DragEventArgs e)
        {
            ((Image)sender).Source = global_image.Source;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            global_image = (Image)sender;
            DragDrop.DoDragDrop(global_image, global_image.Source, DragDropEffects.Copy);
        }
    }
}