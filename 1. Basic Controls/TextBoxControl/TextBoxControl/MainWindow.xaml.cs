using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextBoxControl
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

        private void tbxSelectionOn_Changed(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                txtStatus.Text = $"Selection starts at character #{textBox.SelectionStart} {Environment.NewLine}";
                txtStatus.Text += $"Selection is {textBox.SelectionLength} Character(s) Long {Environment.NewLine}";
                txtStatus.Text += $"Selected Text: {textBox.SelectedText}";
            }
        }
    }
}