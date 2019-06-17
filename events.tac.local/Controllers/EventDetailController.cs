using events.tac.local.Models;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace events.tac.local.Controllers
{
  public class EventDetailController : Controller
  {
    // GET: EventDetail
    public ActionResult Index()
    {
      return View("~/Views/Events/EventDetail/Index.cshtml", CreateModel());
    }

    public static EventDetail CreateModel()
    {
      var item = RenderingContext.Current.ContextItem;
      return new EventDetail()
      {

      };
    }
  }
}
