using System.Collections.ObjectModel;

namespace DependencyInjectionMVVMSample
{
    public interface IMainViewModel
    {
        ObservableCollection<IContactModel> ContactList { get; set; }
        void GetAllContact();
    }
}