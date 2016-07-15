using System.Collections.Generic;

namespace DependencyInjectionMVVMSample
{
    public interface IContactService
    {
        List<IContactModel> GetAll();
    }
}