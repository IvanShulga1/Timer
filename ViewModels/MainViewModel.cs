using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Timer.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        Stopwatch _stopwatch;

        private int? _hours;
        public int? Hours
        {
            get => _hours;
            set
            {
                OnPropertyChanged(nameof(Hours));
                if (value > 0)
                {
                    _hours = value;
                }
            }
        }

        private int? _minutes;
        public int? Minutes
        {
            get => _minutes;
            set
            {
                if (value > 0)
                {
                    _minutes = value;
                }
                OnPropertyChanged(nameof(Minutes));
            }
        }

        private int? _seconds;
        public int? Seconds
        {
            get => _seconds;
            set
            {
                if (value > 0)
                {
                    _seconds = value;
                }
                OnPropertyChanged(nameof(Seconds));
            }
        }
    }
}
