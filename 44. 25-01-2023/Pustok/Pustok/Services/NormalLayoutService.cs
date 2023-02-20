using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pustok.Models;

namespace Pustok.Services
{
    public class NormalLayoutService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly PustokContext _pustokContext;

        public NormalLayoutService(UserManager<AppUser> userManager,IHttpContextAccessor httpContextAccessor, PustokContext pustokContext)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _pustokContext = pustokContext;
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

        public async Task<List<Setting>> GetSettingsAsync()
        {
            return await _pustokContext.Settings.ToListAsync();
        }
    }
}
