using OnlineShop.Admin.Commands;
using OnlineShop.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace OnlineShop.Admin.ViewModels
{
    public class LoadDataViewModel : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand LoadDataCommand { get; set; }


        public LoadDataViewModel()
        {
            LoadDataCommand = new Command(ExecuteMetodLoadData, CanExecuteMetodLoadData);
        }

        private bool CanExecuteMetodLoadData(object obj)
        {
            return true;
        }

        private void ExecuteMetodLoadData(object obj)
        {
            string path = (string)obj;
            LoadDataModel ldm = new LoadDataModel(path);
            var lp = ldm.listPrice;
        }
    }
}
