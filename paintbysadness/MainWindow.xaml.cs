//NAME: Cole Weston
//DATE: 1/30/2019
//FILE NAME: paintbysadness.csproj
//PURPOSE: Allows user to paint sad little trees in multiple colors and sizes.

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

namespace paintbysadness
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            happy_little_trees.DefaultDrawingAttributes.Color = Colors.Black;
            happy_little_trees.DefaultDrawingAttributes.Height = 20;
            happy_little_trees.DefaultDrawingAttributes.Width = 20;

        }
        //Color Toggle
        private void RED_Click(object sender, RoutedEventArgs e)
        {
            happy_little_trees.DefaultDrawingAttributes.Color = Color.FromRgb(230, 20, 20);
        }
        private void BLUE_Click(object sender, RoutedEventArgs e)
        {
            happy_little_trees.DefaultDrawingAttributes.Color = Color.FromRgb(60,10,255);
        }
        private void GREEN_Click(object sender, RoutedEventArgs e)
        {
            happy_little_trees.DefaultDrawingAttributes.Color = Colors.Green;
        }
        private void BLACK_Click(object sender, RoutedEventArgs e)
        {
            happy_little_trees.DefaultDrawingAttributes.Color = Colors.Black;
        }
        //Eraser Selection
        private void ERASER_Click(object sender, RoutedEventArgs e)
        {
            happy_little_trees.DefaultDrawingAttributes.Color = Colors.White;
        }
        //Clear Button
        private void CLEAR_Click(object sender, RoutedEventArgs e)
        {
            happy_little_trees.Strokes.Clear();
        }
        //Thickness Toggle
        private void SMALL_Click(object sender, RoutedEventArgs e)
        {
            happy_little_trees.DefaultDrawingAttributes.Height = 20;
            happy_little_trees.DefaultDrawingAttributes.Width = 20;
        }
        private void MEDIUM_Click(object sender, RoutedEventArgs e)
        {
            happy_little_trees.DefaultDrawingAttributes.Height = 30;
            happy_little_trees.DefaultDrawingAttributes.Width = 30;
        }
        private void LARGE_Click(object sender, RoutedEventArgs e)
        {
            happy_little_trees.DefaultDrawingAttributes.Height = 40;
            happy_little_trees.DefaultDrawingAttributes.Width = 40;
        }
    }

}

