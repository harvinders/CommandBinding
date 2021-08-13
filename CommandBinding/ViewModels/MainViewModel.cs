using System;
using System.Collections.Generic;
using BindingCommand.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CommandBinding.ViewModels
{
    public class MainViewModel : ObservableRecipient
    {
        public List<NotificationViewModel> Notifications { get; set; }
        public MainViewModel()
        {
            Notifications = new List<NotificationViewModel>() {
                new NotificationViewModel("A"),
                new NotificationViewModel("B"),
                new NotificationViewModel("C"),
                new NotificationViewModel("D"),
            };
        }
    }
}

