using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace LSRS.Controllers
{
    public class  ReserveController : Controller
    {
        //get: /Reserve/
        public IActionResult Index()
        {
            return View();
        }
           
    }
        
}