using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Core
{
    // look into the Inotifypropertychange (updating the UI with binding)
    class ObservableObject : INotifyPropertyChanged
    {
        // implementing interface of Inotify
        public event PropertyChangedEventHandler PropertyChanged;

        // Caller Member name is called an ATTRIBUTE 
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            // if its not null we want to invoke it 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
