using Lab01.ViewModels;
using System.Windows.Controls;

namespace Lab01.UserWindow
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : UserControl
    {
        public UserWindow()
        {
            InitializeComponent();
            DataContext = new UserWindowViewModel();
        }
    }
}

