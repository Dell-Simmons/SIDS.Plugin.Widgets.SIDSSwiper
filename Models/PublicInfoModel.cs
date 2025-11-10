using Nop.Web.Framework.Models;

namespace SIDS.Plugin.Widgets.SIDSSwiper.Models;

/// <summary>
/// Represents a slider model on the site
/// </summary>
public record PublicInfoModel : BaseNopModel
{
    #region Properties

    public bool ShowNavigation { get; set; }
    public bool ShowPagination { get; set; }
    public bool Autoplay { get; set; }
    public int AutoplayDelay { get; set; }
    public List<PublicSlideModel> Slides { get; set; } = new();

    #endregion
}