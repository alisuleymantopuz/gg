using Microsoft.Extensions.DependencyInjection;

namespace gg.core
{
    public static class GroupServiceCollectionExtensions
    {
        public static IServiceCollection AddGroupBusiness(this IServiceCollection services)
        {
            services.AddSingleton<IGroupsService, InMemoryGroupsService>();
            services.AddSingleton<IGroupIdGenerator, GroupIdGenerator>();
            return services;
        }
    }
}
