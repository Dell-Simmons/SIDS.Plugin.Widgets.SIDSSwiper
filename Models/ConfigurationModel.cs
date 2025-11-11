using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace SIDS.Plugin.Widgets.SIDSSwiper.Models;

/// <summary>
/// Represents a configuration model
/// </summary>
public record ConfigurationModel : BaseNopModel
{
    #region Properties

    public int ActiveStoreScopeConfiguration { get; set; }
    [NopResourceDisplayName("Plugins.Widgets.SIDSSwiper.NumNewProducts")]
    public int NumNewProducts { get; set; }
    public bool NumNewProducts_OverrideForStore { get; set; }
    [NopResourceDisplayName("Plugins.Widgets.SIDSSwiper.NumSameCatNumber")]
    public int NumSameCatNumber { get; set; }
    public bool NumSameCatNumber_OverrideForStore { get; set; }

    [NopResourceDisplayName("Plugins.Widgets.SIDSSwiper.ShowNavigation")]
    public bool ShowNavigation { get; set; }
    public bool ShowNavigation_OverrideForStore { get; set; }

    [NopResourceDisplayName("Plugins.Widgets.SIDSSwiper.ShowPagination")]
    public bool ShowPagination { get; set; }
    public bool ShowPagination_OverrideForStore { get; set; }

    [NopResourceDisplayName("Plugins.Widgets.SIDSSwiper.Autoplay")]
    public bool Autoplay { get; set; }
    public bool Autoplay_OverrideForStore { get; set; }

    [NopResourceDisplayName("Plugins.Widgets.SIDSSwiper.AutoplayDelay")]
    public int AutoplayDelay { get; set; }
    public bool AutoplayDelay_OverrideForStore { get; set; }

    [NopResourceDisplayName("Plugins.Widgets.SIDSSwiper.LazyLoading")]
    public bool LazyLoading { get; set; }
    public bool LazyLoading_OverrideForStore { get; set; }

    public SlidesSearchModel SlidesSearchModel { get; set; } = new();
    public SlidePictureModel AddSlideModel { get; set; } = new();

    #endregion
}