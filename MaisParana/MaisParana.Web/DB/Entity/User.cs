using Microsoft.AspNet.Identity;

namespace MaisParana.Web.DB
{
    public class User
    {
        public string Password { get; set; }
        public string Id { get; set; }
        public string UserName { get; set; }
    }
}