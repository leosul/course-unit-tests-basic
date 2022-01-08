using Course.UnitTests.Basic.Core.Models;

namespace Course.UnitTests.Basic.Domain.Models
{
    public class Customer : BaseEntity
    {
        public Customer(string name, DateTime birthDate, string mobileNumber, string email, int myProperty, Address address, bool isActive)
        {
            Name = name;
            BirthDate = birthDate;
            MobileNumber = mobileNumber;
            Email = email;
            MyProperty = myProperty;
            Address = address;
            IsActive = isActive;
        }

        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string MobileNumber { get; private set; }
        public string Email { get; private set; }
        public int MyProperty { get; set; }
        public Address Address { get; private set; }
        public bool IsActive { get; private set; }
    }
}
