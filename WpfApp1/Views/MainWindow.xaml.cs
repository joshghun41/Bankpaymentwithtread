using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var vm = new MainViewModel();
            vm.LoadButton=load_databtn;
            vm.Cardtxtb = CardTxtb;
            this.DataContext = vm;
        }

        private void Textchanged(object sender, TextChangedEventArgs e)
        {
            if (CardTxtb.Text.StartsWith("4840"))
            {
                string visa = "/Images/visa_logo_020615.jpg";
                Uri imageUri = new Uri(visa, UriKind.Relative);
                BitmapImage bitmapImage = new BitmapImage(imageUri);
                ImageBox.Source = bitmapImage;
            } 
            else
            {
                ImageBox.Source=null;
            }
        }
    }
}
