using System.Threading.Tasks;
using IdentityCoreWebAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCoreWebAPI.Controllers
{
    public class ApplicationUserController:ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManger;
        
        public ApplicationUserController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            _userManager=userManager;
            _signInManger=signInManager;
        }
        [HttpPost]
        [Route("Register")]  
        //api/ApplicationUser/Register
        public async Task<object> PostApplicationUser(ApplicationUserModel model)
        {
              var applicationUser=new ApplicationUser(){
                   UserName=model.UserName,
                   Email= model.Email,
                   FullName=model.FullName,
                 }; 

        }
    }
}