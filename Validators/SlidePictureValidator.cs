using FluentValidation;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;
using SIDS.Plugin.Widgets.SIDSSwiper.Models;

namespace SIDS.Plugin.Widgets.SIDSSwiper.Validators;

/// <summary>
/// Represents slide model validator
/// </summary>
public class SlidePictureValidator : BaseNopValidator<SlidePictureModel>
{
    #region Ctor

    public SlidePictureValidator(ILocalizationService localizationService)
    {
        RuleFor(model => model.PictureId)
            .GreaterThan(0)
            .WithMessageAwait(localizationService.GetResourceAsync("Plugins.Widgets.Swiper.Picture.Required"));
    }

    #endregion
}
