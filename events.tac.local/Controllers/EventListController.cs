using events.tac.local.Models;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace events.tac.local.Controllers
{
  public class EventListController : Controller
  {
    // GET: EventList
    public ActionResult Index()
    {
      return View("~/Views/Events/EventList/Index.cshtml", CreateModel());
    }

    public static EventList CreateModel()
    {
      var item = RenderingContext.Current.ContextItem;
      return new EventList()
      {
        
      };
    }
  }
}
