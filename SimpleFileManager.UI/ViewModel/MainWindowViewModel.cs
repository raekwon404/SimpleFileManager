using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using SimpleFileManager.Model.Classes;

namespace SimpleFileManager.UI.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Properties

        public ObservableCollection<DriveInfo> Drives { get; private set; }

        #endregion

        #region Ctors

        public MainWindowViewModel()
        {
            Drives = new ObservableCollection<DriveInfo>(DriveManager.GetAllDrives());
        }

        #endregion

        #region Commands

        private ICommand _clickDriveCommand;

        #endregion

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
