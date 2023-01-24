using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pustok.Models;
using Pustok.ViewModels;
using Pustok.ViewModels.MemberVMs;

namespace Pustok.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly PustokContext _pustokContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, PustokContext pustokContext, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _pustokContext = pustokContext;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(MemberLoginViewModel memberLoginVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser member = await _userManager.FindByNameAsync(memberLoginVM.Username);

            if(member == null)
            {
                ModelState.AddModelError("", "Username or password is incorrect!");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(member, memberLoginVM.Password, false, false);

            if(!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or password is incorrect!");
                return View();
            }


            return RedirectToAction("index", "home");
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(MemberRegisterViewModel memberRegisterVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser user = null;

            user = await _userManager.FindByNameAsync(memberRegisterVM.Username);

            if(user != null)
            {
                ModelState.AddModelError("Username", "Already exist!");
                return View();
            }

            //user = await _userManager.FindByEmailAsync(memberRegisterVM.Email);
            user = _pustokContext.Users.FirstOrDefault(x => x.NormalizedEmail == memberRegisterVM.Email.ToUpper());
            if (user != null)
            {
                ModelState.AddModelError("Email", "Already exist!");
                return View();
            }

            user = new AppUser
            {
                FullName = memberRegisterVM.Fullname,
                UserName = memberRegisterVM.Username,
                Email = memberRegisterVM.Email,
                IsAdmin = false
            };

            var result = await _userManager.CreateAsync(user, memberRegisterVM.Password);

            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
            }

            await _userManager.AddToRoleAsync(user, "Member");

            await _signInManager.SignInAsync(user, isPersistent: false);

            return RedirectToAction("index","home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("login", "account");
        }
    }
}
