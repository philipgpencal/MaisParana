using System.Web.Mvc;
using MaisParana.Web.DB;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Owin.Security;
using System.Web;
using MaisParana.Web.Models;
using Microsoft.AspNet.Identity.Owin;
using System.Linq;

namespace MaisParana.Web.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            return RedirectToAction("Index", "Dashboard");
        }
        
    }
}
