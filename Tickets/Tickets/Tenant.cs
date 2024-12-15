using System;

namespace Tickets
{
    // Base class for Tenant
    public abstract class Tenant
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        protected Tenant(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public abstract bool CanLogDiscountCriteria();
    }
}
