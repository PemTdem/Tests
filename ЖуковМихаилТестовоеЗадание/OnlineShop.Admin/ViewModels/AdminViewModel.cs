using OnlineShop.Admin.Clases;
using OnlineShop.Admin.Commands;
using OnlineShop.Admin.Models;
using OnlineShop.Admin.Views;
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
    public class AdminViewModel : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public AdminModel _adminModel;

        public ICommand OpenWindowLoadDataCommand { get; set; }

        public AdminViewModel()
        {
            OpenWindowLoadDataCommand = new Command(ExecuteMetodOpenWindow, CanExecuteMetodOpenWindow);
            _adminModel = new AdminModel();
            Brends = _adminModel.Brends.ToList();
            Assortments = _adminModel.Assortment.ToList();
        }

        private bool CanExecuteMetodOpenWindow(object obj)
        {
            return true;
        }

        private void ExecuteMetodOpenWindow(object obj)
        {
            LoadData ld = new LoadData();
            ld.ShowDialog();
        }

        private Brend _selectedBrend;
        public Brend SelectedBrend
        {
            get
            {
                return _selectedBrend;
            }
            set
            {
                if (_selectedBrend != value)
                {
                    _selectedBrend = value;

                    if (null != PropertyChanged)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("SelectedItem"));
                        SelectBrendName();
                    }
                }
            }
        }
     
        private void SelectBrendName()
        {
            AssortmentsFind = Assortments.Where(x => x.IdBrand == _selectedBrend.Id).ToList();
        }

        public List<Assortment> AssortmentsFind
        {
            get { return (List<Assortment>)GetValue(AssortmentsFindProperty); }
            set { SetValue(AssortmentsFindProperty, value); }
        }

        public static readonly DependencyProperty AssortmentsFindProperty =
            DependencyProperty.Register("AssortmentsFind", typeof(List<Assortment>), typeof(AdminViewModel), new PropertyMetadata(null));




        public List<Brend> Brends
        {
            get { return (List<Brend>)GetValue(BrendsProperty); }
            set { SetValue(BrendsProperty, value); }
        }

        public static readonly DependencyProperty BrendsProperty =
            DependencyProperty.Register("Brends", typeof(List<Brend>), typeof(AdminViewModel), new PropertyMetadata(null));

        public List<Assortment> Assortments
        {
            get { return (List<Assortment>)GetValue(AssortmentsProperty); }
            set { SetValue(AssortmentsProperty, value); }
        }

        public static readonly DependencyProperty AssortmentsProperty =
            DependencyProperty.Register("Assortments", typeof(List<Assortment>), typeof(AdminViewModel), new PropertyMetadata(null));


        

    }
}
