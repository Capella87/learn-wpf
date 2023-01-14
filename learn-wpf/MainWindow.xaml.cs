using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace learn_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri)
                {
                    UseShellExecute = true // In .NET Core, This property must be set to true
                });
                e.Handled = true;
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
                Console.WriteLine(e2.StackTrace);
                MessageBox.Show(e2.Message);
            }
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            textbox.SelectionOpacity = .5;
            txtStatus.Text = $"Selection starts at character #{textbox!.SelectionStart}\n";
            txtStatus.Text += $"Selection is {textbox.SelectionLength} character(s) long\n";
            txtStatus.Text += $"Selected text: '{textbox.SelectedText}'";
        }

        private void HelloWorldButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this, "Hello World!", "Alert");
        }
    }
}