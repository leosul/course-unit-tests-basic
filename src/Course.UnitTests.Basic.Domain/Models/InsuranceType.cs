﻿using Course.UnitTests.Basic.Core.Models;

namespace Course.UnitTests.Basic.Domain.Models
{
    public class InsuranceType : BaseEntity
    {
        public InsuranceType(string name, string description, bool isActive)
        {
            Name = name;
            Description = description;
            IsActive = isActive;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsActive { get; private set; }
    }
}
