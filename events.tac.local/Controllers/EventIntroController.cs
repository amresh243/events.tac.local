﻿using events.tac.local.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using System;
using System.Web;
using System.Web.Mvc;

namespace events.tac.local.Controllers
{
  public class EventIntroController : Controller
  {
    // GET: EventIntro
    public ActionResult Index()
    {
      return View("~/Views/Events/EventIntro/Index.cshtml", CreateModel());
    }

    public static EventIntro CreateModel()
    {
      var item = RenderingContext.Current.ContextItem;
      return new EventIntro()
      {
        ContentHeading = new HtmlString(FieldRenderer.Render(item, "ContentHeading")),
        ContentBody = new HtmlString(FieldRenderer.Render(item, "ContentBody")),
        EventImage = new HtmlString(FieldRenderer.Render(item, "EventImage", "mw=400")),
        Highlights = new HtmlString(FieldRenderer.Render(item, "Highlights")),
        ContentIntro = new HtmlString(FieldRenderer.Render(item, "ContentIntro")),
        StartDate = Sitecore.DateUtil.ParseDateTime(item.Fields["StartDate"].Value, DateTime.Now),
        Duration = new HtmlString(FieldRenderer.Render(item, "Duration")),
        DifficultyLevel = new HtmlString(FieldRenderer.Render(item, "DifficultyLevel"))
      };
    }
  }
}
