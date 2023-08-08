using System.Security.Claims;
using CampingApp.DataTransferObjects.requests;
using CampingApp.Entities;
using CampingApp.Mvc.Models;
using CampingApp.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CampingApp.Mvc.Controllers
{
    [AllowAnonymous]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var users = _userService.GetUsersDisplayResponses();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateUser(int id)
        {
            var user = await _userService.GetUserForUpdateAsync(id);
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UpdateUserRequestDto updateUserRequestDto)
        {
            if (ModelState.IsValid)
            {
                await _userService.UpdateUserAsync(updateUserRequestDto);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(CreateNewUserRequestDto createNewUserRequestDto)
        {
            await _userService.CreateUserAsync(createNewUserRequestDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteUser(int id)
        {
            var deletingUser = await _userService.GetUserByIdAsync(id);
            await _userService.DeleteUserAsync(deletingUser);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Login(string? targetPage)
        {
            ViewBag.ReturnUrl = targetPage!;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLogin, string? targetPage)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.ValidateUser(userLogin.UserName, userLogin.Password);
                if (user != null)
                {
                    Claim[] claims = new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim(ClaimTypes.Email,user.Email),
                        new Claim(ClaimTypes.Role, user.Role)
                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);

                    if (!string.IsNullOrEmpty(targetPage) && Url.IsLocalUrl(targetPage))
                    {
                        return Redirect(targetPage);
                    }
                    return Redirect("/");
                }
                ModelState.AddModelError("Login","Username or Password Invalid");
            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
