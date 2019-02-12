//NAME: Cole Weston
//DATE: 2/12/2019
//FILE NAME: main.cs
//PURPOSE: Main function for project
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
using System.Windows.Forms;
namespace paintbysadness
{   
    class Main //Thanks Stack Overflow https://stackoverflow.com/questions/6156550/replacing-the-wpf-entry-point
    {
       // <TextBox HorizontalAlignment = "Left" Height="18" TextWrapping="Wrap" Text="TextBox" VerticalAlignment="Top" Width="46"/>

        
        public class EntryPoint { //made an entry point for the program (changed in properties)
            [STAThread] //no clue but it won't work without it
            public static void Main(string[] args) {
                

                var app = new App();
                //Creating DYNAMICALLY (ASK DR. ERICSON)
                /*
                TextBlock textBlock = new TextBlock();
                textBlock.Name = "textblock1";
                textBlock.Text = "HELLO FROM MAIN";
                textBlock.Height = 18;
                textBlock.Width = 20;
                textBlock.Foreground = new SolidColorBrush(Colors.White);
                textBlock.Background = new SolidColorBrush(Colors.Black); */

                


                app.InitializeComponent();
                System.Windows.Forms.MessageBox.Show("Hello from Main! I hated making this. There is no programming god, but the code devil is real.");
                app.Run();



            }
        }
    }
}
