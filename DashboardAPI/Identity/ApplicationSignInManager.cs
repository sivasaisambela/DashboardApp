﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
namespace DashboardAPI.Identity
{
    public class ApplicationSignInManager : SignInManager<ApplicationUser>
    {
        public ApplicationSignInManager(ApplicationUserManager applicationUserManager, IHttpContextAccessor httpContextAccessor, IUserClaimsPrincipalFactory<ApplicationUser>
            userClaimsPrincipalFactory, IOptions<IdentityOptions> options, ILogger<ApplicationSignInManager> logger,IAuthenticationSchemeProvider schemes):
            base(applicationUserManager,httpContextAccessor,userClaimsPrincipalFactory,options,logger,schemes)
        {
                
        }
    }
}
