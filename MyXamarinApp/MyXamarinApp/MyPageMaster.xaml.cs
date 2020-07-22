using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPageMaster : ContentPage
    {
        public ListView ListView;

        public MyPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MyPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyPageMasterMenuItem> MenuItems { get; set; }

            public MyPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MyPageMasterMenuItem>(new[]
                {
                    new MyPageMasterMenuItem { Id = 0, Title = "Main Menu",
                    TargetType=typeof(MenuPage),ImageSource="addicon.png"},
                    new MyPageMasterMenuItem { Id = 1, Title = "Custom List",
                    TargetType=typeof(SampleCustomList),ImageSource="addicon.png"},
                    new MyPageMasterMenuItem { Id = 2, Title = "Image List",
                    TargetType=typeof(SampleImageList),ImageSource="addicon.png"},
                    new MyPageMasterMenuItem { Id = 3, Title = "My Tab",
                    TargetType=typeof(MyTabbedPage),ImageSource="addicon.png"},
                    new MyPageMasterMenuItem { Id = 4, Title = "Binding List",
                    TargetType=typeof(SampleListBinding),ImageSource="addicon.png"},
                    new MyPageMasterMenuItem {Id=5,Title="Simple List",
                    TargetType=typeof(SampleListString),ImageSource="addicon.png"}
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}