using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Media;
using Nop.Services.Media;
using Nop.Web.Factories;
using SIDS.Plugin.Widgets.SIDSSwiper.Domain;
using System;
using System.Linq;

namespace SIDS.Plugin.Widgets.SIDSSwiper.Factories;

public class SlideModelFactory
{
    #region Constants and Fields
    private readonly IPictureService _pictureService;
    private readonly IProductModelFactory _productModelFactory;
    #endregion

    #region Constructors
    public SlideModelFactory(IPictureService pictureService, IProductModelFactory productModelFactory)
    {
        _pictureService = pictureService;
        _productModelFactory = productModelFactory;
    }
    #endregion

    #region Methods
    #region Public Methods
    internal async Task<IEnumerable<Slide>> PrepareSlides(List<Product> newProducts)
    {
        IEnumerable<Slide> preparedSlides = new List<Slide>();

        var productOverviewModels = await _productModelFactory.PrepareProductOverviewModelsAsync(
            newProducts,
            true,
            true);

        // Prepare slides based on new products and the provided slide settings
        foreach (var pOM in productOverviewModels)
        {
            var slide = new Slide
            {
                PictureId = pOM.PictureModels.FirstOrDefault()?.Id ?? 0,
                PictureUrl = pOM.PictureModels.FirstOrDefault()?.FullSizeImageUrl?? string.Empty,
                TitleText = pOM.Name,
                LinkUrl = pOM.SeName,
                AltText = string.Empty
            };
            preparedSlides = preparedSlides.Append(slide);
        }

        return preparedSlides;
    }
    #endregion

    #region Private Methods
    private async Task<Picture> GetProductPicture(Product product)
    {
        var pictures = await _pictureService.GetPicturesByProductIdAsync(product.Id);
        return pictures.FirstOrDefault();
    }

    //private async Task<string> MakeProductLink()
    //{
    //    // use ProductModelFactory.PrepareProductDetailsModelAsync
    //    // to get the product details model and extract the link from there
    //    var asdf = _productModelFactory.PrepareProduct

    //}
    #endregion
    #endregion
}
