
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BindingCommand.ViewModels
{
    public partial class NotificationViewModel : ObservableObject
    {
        public NotificationViewModel(string value)
        {
            SaveCommand = new RelayCommand(Save);
            Value = value;
        }

        public RelayCommand SaveCommand
        {
            get;
            private set;
        }
        public string Value { get; }

        private void Save()
        {
        }
    }
}
