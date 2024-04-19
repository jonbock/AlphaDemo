using AlphaDemoWebApi.Service.Interface.Logging;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AlphaDemoWebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogItem iLogItem;

        public HomeController(ILogItem _ILogItem)
        {
            iLogItem = _ILogItem;
        }

        public async Task<ActionResult> Index()
        {
            ViewBag.Title = "Home Page";

            //var result = await iLogItem.GetErrorLog();

            return View();
        }
    }
}
