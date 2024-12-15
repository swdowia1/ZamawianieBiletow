namespace Tickets
{
    public class TenantA : Tenant
    {
        public TenantA(string name) : base(name) { }
        public override bool CanLogDiscountCriteria() => true;
    }
}
