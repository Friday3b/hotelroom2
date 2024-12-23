using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hotelApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

      
        protected void OnPropertyChanged([CallerMemberName] string? paramName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
    }
}
