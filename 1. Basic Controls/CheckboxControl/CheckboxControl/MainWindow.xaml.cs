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

namespace CheckboxControl
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

        private void AllFeaturesOn_Checked(object sender, RoutedEventArgs e)
        {
            bool newVal = (CbAllFeatures.IsChecked == true);
            cbFeatureABC.IsChecked = newVal;
            cbFeatureXYZ.IsChecked = newVal;    
            cbFeatureWWW.IsChecked = newVal;    
        }

        private void CbFeatureOn_Checked(object sender, RoutedEventArgs e)
        {
            CbAllFeatures.IsChecked = null;
            if((cbFeatureXYZ.IsChecked == true) &&
               (cbFeatureABC.IsChecked == true) &&
               (cbFeatureWWW.IsChecked == true))
            {
                CbAllFeatures.IsChecked=true;
            }
            if ((cbFeatureXYZ.IsChecked == false) &&
                (cbFeatureABC.IsChecked == false) &&
                (cbFeatureWWW.IsChecked == false))
            {
                CbAllFeatures.IsChecked=false;
            }
        }
    }
}