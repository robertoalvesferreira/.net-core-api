using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ResApiCore.Business;
using ResApiCore.Model;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ResApiCore.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private ILoginBusiness _loginBusiness;

       

        public LoginController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;

        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post([FromBody]User user)
        {
            if (user == null) return BadRequest();
            return _loginBusiness.FindByLogin(user);
        }

    

    }
}
