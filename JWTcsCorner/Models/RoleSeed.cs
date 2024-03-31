using smaAPI.Models;

namespace smaAPI.SeedData
{
    public static class RoleSeed
    {
        public static List<Role> Roles = new()
            {
                    new Role(){ tier = Tier.Admin},
                    new Role(){ tier = Tier.User }
            };
    }
}
