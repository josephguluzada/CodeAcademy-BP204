using Microsoft.AspNetCore.Identity;
using Pustok.Models;

namespace Pustok.Services
{
    public class NormalLayoutService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public NormalLayoutService(UserManager<AppUser> userManager,IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<AppUser> GetUser()
        {
            AppUser appUser = null;

            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                appUser = await _userManager.FindByNameAsync(_httpContextAccessor.HttpContext.User.Identity.Name);

                return appUser;
            }
            return null;
        }
    }
}
