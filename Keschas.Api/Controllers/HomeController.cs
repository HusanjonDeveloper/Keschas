using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Keschas.Api.Controllers
{
    [ApiController]
    [Route("api/Controller")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult <string> Get()=>
            Ok("Hello Mario");
       
    }
}
