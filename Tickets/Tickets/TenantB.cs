namespace Tickets
{
    public class TenantB : Tenant
    {
        public TenantB(string name) : base(name) { }
        public override bool CanLogDiscountCriteria() => false;
    }
}
