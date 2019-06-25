using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Resources.Media;

namespace events.tac.local.Helper
{
  public static class SitecoreHelper
  {
    public static string GetMediaUrl(this Item item, string tagName)
    {
      var db = RenderingContext.Current.ContextItem.Database;
      string mediaTag = item.Fields[tagName].Value;
      string mediaID = mediaTag.Substring(mediaTag.IndexOf("{"), 38);
      return MediaManager.GetMediaUrl(db.GetItem(new ID(mediaID)));
    }
  }
}