using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Command;

namespace WpfApp1.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public RelayCommand InsertCardCommand { get; set; }
        private Button loadbutton;

        public Button LoadButton
        {
            get { return loadbutton; }
            set { loadbutton = value; OnPropertyChanged(); }
        }
        private TextBox cardtxtb;

        public TextBox Cardtxtb
        {
            get { return cardtxtb; }
            set { cardtxtb = value; OnPropertyChanged(); }
        }
        public MainViewModel()
        {
            InsertCardCommand = new RelayCommand(x =>
            {
                LoadButton.Visibility=Visibility.Visible;
                cardtxtb.Visibility=Visibility.Visible; 

            });
        }
    }
}
