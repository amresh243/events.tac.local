using events.tac.local.Business;
using System.Web.Mvc;

namespace events.tac.local.Controllers
{
  public class EventsListController : Controller
  {
    private readonly EventsProvider _provider;

    public EventsListController() : this(new EventsProvider()) { }

    public EventsListController(EventsProvider provider)
    {
      _provider = provider;
    }

    // GET: EventsList
    public ActionResult Index(int page = 1)
    {
      return View("~/Views/Events/EventsList/Index.cshtml", _provider.GetEventsList(page - 1));
    }
  }
}
