using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;
using TRMDataManager.Library.DataAccess;
using TRMDataManager.Library.Models;
using AuthorizeAttribute = System.Web.Mvc.AuthorizeAttribute;

namespace TRMDataManager.Controllers
{
    [Authorize]

    public class UserController : ApiController
    {

        [HttpGet]
        // GET: User/Details/5
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();

            return data.GetUserById(userId).First();

        }
    }
}
