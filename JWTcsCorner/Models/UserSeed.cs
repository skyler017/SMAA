using smaAPI.Models;

namespace smaAPI.SeedData
{
    // We are not taking data from data base so we get data from constant
    public class UserSeed
    {
        public static List<User> Users = new()
            {
                    new User(){ Username="naeem",Password="naeem_admin",Permission = RoleSeed.Roles[(int)Tier.Admin]},
                    new User(){ Username="neeem",Password="neeem_user",Permission = RoleSeed.Roles[(int)Tier.User] }
            };
    }
}