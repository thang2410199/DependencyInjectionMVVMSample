namespace DependencyInjectionMVVMSample
{
    public class ContactModel : IContactModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}