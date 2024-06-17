using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace DashboardAPI.Identity
{
    public class ApplicationUserManager:UserManager<ApplicationUser>
    {
        public ApplicationUserManager(ApplicationUserStore applicationsUserStore,IOptions<IdentityOptions> options,IPasswordHasher<ApplicationUser> passwordHasher,
              IEnumerable<IUserValidator<ApplicationUser>> userValidators,IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators,ILookupNormalizer lookupNormalizer
            ,IdentityErrorDescriber identityErrorDescriber,IServiceProvider service,ILogger<ApplicationUserManager> logger) : base(applicationsUserStore, options, passwordHasher, userValidators,passwordValidators,lookupNormalizer, identityErrorDescriber,service, logger)
        {
                
        }
    }
}
