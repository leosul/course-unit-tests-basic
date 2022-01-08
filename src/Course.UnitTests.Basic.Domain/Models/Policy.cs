using Course.UnitTests.Basic.Core.Models;

namespace Course.UnitTests.Basic.Domain.Models
{
    public class Policy : BaseEntity
    {
        public Policy(string name, string description, decimal premium, decimal capital, InsuranceType insuranceType, bool isActive)
        {
            Name = name;
            Description = description;
            Premium = premium;
            Capital = capital;
            InsuranceType = insuranceType;
            IsActive = isActive;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Premium { get; private set; }
        public decimal Capital { get; private set; }
        public InsuranceType InsuranceType { get; private set; }
        public bool IsActive { get; private set; }
    }
}
