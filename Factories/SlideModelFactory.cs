using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Media;
using Nop.Services.Media;
using SIDS.Plugin.Widgets.SIDSSwiper.Domain;

namespace SIDS.Plugin.Widgets.SIDSSwiper.Factories;
public class SlideModelFactory
{
    private readonly IPictureService _pictureService;

    public SlideModelFactory(IPictureService pictureService)
    {
        _pictureService = pictureService;
    }

    internal async Task<IEnumerable<Slide>> PrepareSlides(List<Product> newProducts)
    {
        IEnumerable<Slide> preparedSlides = new List<Slide>();

        // Prepare slides based on new products and the provided slide settings
        foreach (var product in newProducts)
        {
            var slide = new Slide
            {
                PictureId = (await GetProductPicture(product)).Id,
                TitleText = product.Name,
                LinkUrl = await MakeProductLink(product),
                AltText = product.Name
                
            };
            preparedSlides = preparedSlides.Append(slide);
        }

        return preparedSlides;
    }

    private async Task<Picture> GetProductPicture(Product product)
    {
        var pictures = await _pictureService.GetPicturesByProductIdAsync(product.Id);
        return pictures.FirstOrDefault();
    }
 private async Task<string> MakeProductLink(Product product)
    {
       var asdf = product
    }
}
