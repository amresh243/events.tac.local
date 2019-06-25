using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using events.tac.local.Models;
using events.tac.local.Business;

namespace events.tac.local.Controllers
{
  public class EventHomeController : Controller
  {
    private readonly CarouselProvider _provider;

    public EventHomeController() : this(new CarouselProvider()) { }

    public EventHomeController(CarouselProvider provider)
    {
      _provider = provider;
    }

    // GET: EventHome
    public ActionResult GetCarousels()
    {
      return View("~/Views/Events/Carousel.cshtml", _provider.GetCarousels());
    }
  }
}