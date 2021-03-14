using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Timer.Models
{
    public class TimerModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private Guid _guidId;
        public Guid GuidId { get => _guidId; set {_guidId = value; OnPropertyChanged(nameof(GuidId));} }

        private bool _isPlayed;
        public bool IsPlayed { get => _isPlayed; set { _isPlayed = value; OnPropertyChanged(nameof(IsPlayed)); } }
    }
}
