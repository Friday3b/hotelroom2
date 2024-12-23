using hotelApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace hotelApp.ViewModels
{
    public class MainPageModel :BaseViewModel , INotifyPropertyChanged
    {
        private Page? _currentPage;


        public Page? CurrentPage { get => _currentPage; set { _currentPage = value; OnPropertyChanged(); } }

        public MainPageModel()
        {
            _currentPage = App.Container.GetInstance<SelectCondition>();
            _currentPage.DataContext = App.Container.GetInstance<SelectConditionModel>();
        }

        

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? paramName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));


    }
}
