namespace Abp.MultiTenancy
{
    public static class MultiTenancyConsts
    {
        /// <summary>
        /// Default tenant id: 1.
        /// </summary>
        public const int DefaultTenantId = 1;

        /// <summary>
        /// Always resolve TenantId with ITenantResolver.ResolveTenantId() even though user is already logged in 
        /// </summary>
        public const bool AlwaysResolveTenantId = true;
    }
}