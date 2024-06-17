using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DashboardAPI.Identity
{
    public class ApplicationUserStore: UserStore<ApplicationUser>
    {
        public ApplicationUserStore(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {

        }
    }
}
