using events.tac.local.Helper;
using events.tac.local.Models;
using Sitecore.Data.Fields;
using Sitecore.Links;
using Sitecore.Mvc.Presentation;
using System.Collections.Generic;

namespace events.tac.local.Business
{
  public class CarouselProvider
  {
    public IEnumerable<Carousel> GetCarousels()
    {
      var db = RenderingContext.Current.ContextItem.Database;
      var homeItem = db.GetItem(Sitecore.Context.Site.StartPath);
      MultilistField carouselEntries = homeItem.Fields["Carousels"];
      var carouselItems = carouselEntries.GetItems();
      List<Carousel> carousels = new List<Carousel>();
      foreach (var cItem in carouselItems)
      {
        var address = (LookupField)cItem.Fields["Event"];
        var eventItem = address?.TargetItem;
        var active = (CheckboxField)cItem.Fields["IsActive"];
        carousels.Add(new Carousel
        {
          Image = cItem.GetMediaUrl("Image"),
          Url = (eventItem != null) ? LinkManager.GetItemUrl(eventItem) : "",
          Title = cItem.Fields["Title"].Value,
          Intro = cItem.Fields["Intro"].Value,
          IsActive = active.Checked
        });
      }

      return carousels;
    }
  }
}
