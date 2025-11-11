using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace SIDS.Plugin.Widgets.SIDSSwiper.Models;

/// <summary>
/// Represents a slide model
/// </summary>
public record SlidePictureModel : BaseNopModel
{
    #region Properties

    [UIHint("Picture")]
    [NopResourceDisplayName("Plugins.Widgets.SIDSSwiper.Picture")]
    public int PictureId { get; set; }

    [NopResourceDisplayName("Plugins.Widgets.SIDSSwiper.TitleText")]
    public string TitleText { get; set; }

    [NopResourceDisplayName("Plugins.Widgets.SIDSSwiper.LinkUrl")]
    public string LinkUrl { get; set; }

    [NopResourceDisplayName("Plugins.Widgets.SIDSSwiper.AltText")]
    public string AltText { get; set; }

    #endregion
}
