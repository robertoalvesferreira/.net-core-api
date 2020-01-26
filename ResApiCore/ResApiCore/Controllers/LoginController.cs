using Microsoft.AspNetCore.Mvc;
using ResApiCore.Business;
using ResApiCore.Model;
using System.Collections.Generic;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ResApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {

        private ILoginBusiness _loginBusiness;

       

        public LoginController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;

        }
        //[AllowAnonymous]
        [HttpPost]
        public object Post([FromBody]User user)
        {
            if (user == null) return BadRequest();
            return _loginBusiness.FindByLogin(user);
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }


    }
}
