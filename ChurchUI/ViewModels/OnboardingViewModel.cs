using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PropertyChanged;

namespace ChurchUI.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class OnboardingViewModel
    {
        public ObservableCollection<Boarding> Boardings { get; set; }
    }
}
