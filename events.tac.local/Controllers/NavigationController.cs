using events.tac.local.Business;
using System.Web.Mvc;

namespace events.tac.local.Controllers
{
  public class NavigationController : Controller
  {
    public readonly NavigationBuilder _builder;

    public NavigationController() : this(new NavigationBuilder()) { }

    public NavigationController(NavigationBuilder builder)
    {
      _builder = builder;
    }

    // GET: Breadcrumb
    public ActionResult Index()
    {
      return View("~/Views/Events/Navigation/Index.cshtml", _builder.Build());
    }
  }
}
