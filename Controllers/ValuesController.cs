using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class ValuesController : ApiController
    {
        [Authorize]
        public string Get()
        {
            return "O usuário logado é " + User.Identity.Name;
        }
    }
}
