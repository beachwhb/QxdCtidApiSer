using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace QxdCtidApiSer.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : QxdCtidApiSerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}