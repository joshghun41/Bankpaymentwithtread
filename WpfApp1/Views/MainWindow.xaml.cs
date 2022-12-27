using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.ViewModel;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var vm = new MainViewModel();
            
            vm.Cardtxtb = CardTxtb;
            this.DataContext = vm;
        }

        private void Textchanged(object sender, TextChangedEventArgs e)
        {
            Data data = new Data();
            List<Data> datas = Data.getAll();

            for (int i = 0; i < datas.Count; i++)
            {

                if (CardTxtb.Text == datas[i].CardNo)
                {

                    FullnameTxtBlock.Text = $@"
{datas[i].FullName}   
{datas[i].Cash} azn";
                }
            }

        

            if (CardTxtb.Text.StartsWith("4"))
            {
                string visa = "/Images/visa_logo_020615.jpg";
                Uri imageUri = new Uri(visa, UriKind.Relative);
                BitmapImage bitmapImage = new BitmapImage(imageUri);
                ImageBox.Source = bitmapImage;
            }
            else if (CardTxtb.Text.StartsWith("5"))
            {
                string master = "/Images/mastercard.png";
                Uri imageUri = new Uri(master, UriKind.Relative);
                BitmapImage bitmapImage = new BitmapImage(imageUri);
                ImageBox.Source = bitmapImage;
            }
            else
            {

            }

            if (CardTxtb.Text.Length > 16)
            {
                CardTxtb.Text = CardTxtb.Text.Substring(16);
            }
            if (CardTxtb.Text.Length > 15)
            {
                
                CardTxtb.Foreground = Brushes.Green;
            }
            else
            {
                CardTxtb.Foreground = Brushes.Red;
            }

           
        }

        
    }
}
