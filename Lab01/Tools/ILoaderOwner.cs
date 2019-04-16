using System.ComponentModel;

namespace Lab01.Tools
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        System.Windows.Visibility LoaderVisibility { get; set; }
        bool IsControlEnabled { get; set; }
    }
}
