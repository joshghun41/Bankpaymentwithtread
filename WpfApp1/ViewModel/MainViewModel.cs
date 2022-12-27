using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public RelayCommand TransferMoneyCommand { get; set; }
        private ObservableCollection<Data> datas;

        public ObservableCollection<Data> Datas
        {
            get { return datas; }
            set { datas = value;OnPropertyChanged(); }
        }


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
            Datas = new ObservableCollection<Data>();
            var datas = Data.getAll();
           
            TransferMoneyCommand = new RelayCommand(t =>
            {
                
            });

        }
    }
}
