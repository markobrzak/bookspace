using AutoMapper;

namespace Mapper
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            {
                CreateMap<DataModel.Bookshelf, BusinessModel.Bookshelf>().ReverseMap()
                    .ForMember(dest => dest.Kind, m => m.MapFrom(source => source.Kind))
                    .ForMember(dest => dest.Id, m => m.MapFrom(source => source.Id))
                    .ForMember(dest => dest.Title, m => m.MapFrom(source => source.Title))
                    .ForMember(dest => dest.Access, m => m.MapFrom(source => source.Access))
                    .ForMember(dest => dest.Updated, m => m.MapFrom(source => source.Updated))
                    .ForMember(dest => dest.Created, m => m.MapFrom(source => source.Created))
                    .ForMember(dest => dest.VolumeCount, m => m.MapFrom(source => source.VolumeCount))
                    .ForMember(dest => dest.VolumesLastUpdated, m => m.MapFrom(source => source.VolumesLastUpdated))
                    ;

                CreateMap<DataModel.Bookshelves, BusinessModel.Bookshelves>().ReverseMap()
                    .ForMember(dest => dest.Kind, m => m.MapFrom(source => source.Kind))
                    .ForMember(dest => dest.Items, m => m.MapFrom(source => source.Items))
                    ;
            }

            {
                CreateMap<DataModel.SearchInfo, BusinessModel.SearchInfo>().ReverseMap()
                    .ForMember(dest => dest.TextSnippet, m => m.MapFrom(source => source.TextSnippet))
                    ;
            }

            {

                CreateMap<DataModel.DownloadAccess, BusinessModel.DownloadAccess>().ReverseMap()
                    .ForMember(dest => dest.Kind, m => m.MapFrom(source => source.Kind))
                    .ForMember(dest => dest.VolumeId, m => m.MapFrom(source => source.VolumeId))
                    .ForMember(dest => dest.Restricted, m => m.MapFrom(source => source.Restricted))
                    .ForMember(dest => dest.DeviceAllowed, m => m.MapFrom(source => source.DeviceAllowed))
                    .ForMember(dest => dest.JustAcquired, m => m.MapFrom(source => source.JustAcquired))
                    .ForMember(dest => dest.MaxDownloadDevices, m => m.MapFrom(source => source.MaxDownloadDevices))
                    .ForMember(dest => dest.DownloadsAcquired, m => m.MapFrom(source => source.DownloadsAcquired))
                    .ForMember(dest => dest.Nonce, m => m.MapFrom(source => source.Nonce))
                    .ForMember(dest => dest.Source, m => m.MapFrom(source => source.Source))
                    .ForMember(dest => dest.ReasonCode, m => m.MapFrom(source => source.ReasonCode))
                    .ForMember(dest => dest.Message, m => m.MapFrom(source => source.Message))
                    .ForMember(dest => dest.Signature, m => m.MapFrom(source => source.Signature))
                    ;

                CreateMap<DataModel.Epub, BusinessModel.Epub>().ReverseMap()
                    .ForMember(dest => dest.IsAvailable, m => m.MapFrom(source => source.IsAvailable))
                    .ForMember(dest => dest.DownloadLink, m => m.MapFrom(source => source.DownloadLink))
                    .ForMember(dest => dest.AcsTokenLink, m => m.MapFrom(source => source.AcsTokenLink))
                    ;

                CreateMap<DataModel.Pdf, BusinessModel.Pdf>().ReverseMap()
                    .ForMember(dest => dest.IsAvailable, m => m.MapFrom(source => source.IsAvailable))
                    .ForMember(dest => dest.DownloadLink, m => m.MapFrom(source => source.DownloadLink))
                    .ForMember(dest => dest.AcsTokenLink, m => m.MapFrom(source => source.AcsTokenLink))
                    ;

                CreateMap<DataModel.AccessInfo, BusinessModel.AccessInfo>().ReverseMap()
                    .ForMember(dest => dest.Country, m => m.MapFrom(source => source.Country))
                    .ForMember(dest => dest.Viewability, m => m.MapFrom(source => source.Viewability))
                    .ForMember(dest => dest.Embeddable, m => m.MapFrom(source => source.Embeddable))
                    .ForMember(dest => dest.PublicDomain, m => m.MapFrom(source => source.PublicDomain))
                    .ForMember(dest => dest.TextToSpeechPermission, m => m.MapFrom(source => source.TextToSpeechPermission))
                    .ForMember(dest => dest.Epub, m => m.MapFrom(source => source.Epub))
                    .ForMember(dest => dest.Pdf, m => m.MapFrom(source => source.Pdf))
                    .ForMember(dest => dest.WebReaderLink, m => m.MapFrom(source => source.WebReaderLink))
                    .ForMember(dest => dest.AccessViewStatus, m => m.MapFrom(source => source.AccessViewStatus))
                    .ForMember(dest => dest.QuoteSharingAllowed, m => m.MapFrom(source => source.QuoteSharingAllowed))
                    .ForMember(dest => dest.DownloadAccess, m => m.MapFrom(source => source.DownloadAccess))
                    ;
            }

            {

                CreateMap<DataModel.RetailPrice, BusinessModel.RetailPrice>().ReverseMap()
                    .ForMember(dest => dest.Amount, m => m.MapFrom(source => source.Amount))
                    .ForMember(dest => dest.CurrencyCode, m => m.MapFrom(source => source.CurrencyCode))
                    ;

                CreateMap<DataModel.ListPrice, BusinessModel.ListPrice>().ReverseMap()
                    .ForMember(dest => dest.Amount, m => m.MapFrom(source => source.Amount))
                    .ForMember(dest => dest.CurrencyCode, m => m.MapFrom(source => source.CurrencyCode))
                    ;


                CreateMap<DataModel.SaleInfo, BusinessModel.SaleInfo>().ReverseMap()
                    .ForMember(dest => dest.Country, m => m.MapFrom(source => source.Country))
                    .ForMember(dest => dest.Saleability, m => m.MapFrom(source => source.Saleability))
                    .ForMember(dest => dest.IsEbook, m => m.MapFrom(source => source.IsEbook))
                    .ForMember(dest => dest.ListPrice, m => m.MapFrom(source => source.ListPrice))
                    .ForMember(dest => dest.RetailPrice, m => m.MapFrom(source => source.RetailPrice))
                    .ForMember(dest => dest.BuyLink, m => m.MapFrom(source => source.BuyLink))
                    ;
            }

            {
                CreateMap<DataModel.Dimensions, BusinessModel.Dimensions>().ReverseMap()
                    .ForMember(dest => dest.Height, m => m.MapFrom(source => source.Height))
                    .ForMember(dest => dest.Width, m => m.MapFrom(source => source.Width))
                    .ForMember(dest => dest.Thickness, m => m.MapFrom(source => source.Thickness))
                    ;

                CreateMap<DataModel.Identity, BusinessModel.Identity>().ReverseMap()
                     .ForMember(dest => dest.Type, m => m.MapFrom(source => source.Type))
                     .ForMember(dest => dest.Identifier, m => m.MapFrom(source => source.Identifier))
                     ;

                CreateMap<DataModel.PanelizationSummary, BusinessModel.PanelizationSummary>().ReverseMap()
                    .ForMember(dest => dest.ContainsEpubBubbles, m => m.MapFrom(source => source.ContainsEpubBubbles))
                    .ForMember(dest => dest.ContainsImageBubbles, m => m.MapFrom(source => source.ContainsImageBubbles))
                    ;

                CreateMap<DataModel.ReadingModes, BusinessModel.ReadingModes>().ReverseMap()
                    .ForMember(dest => dest.Text, m => m.MapFrom(source => source.Text))
                    .ForMember(dest => dest.Image, m => m.MapFrom(source => source.Image))
                    ;

                CreateMap<DataModel.ImageLinks, BusinessModel.ImageLinks>().ReverseMap()
                    .ForMember(dest => dest.SmallThumbnail, m => m.MapFrom(source => source.SmallThumbnail))
                    .ForMember(dest => dest.Thumbnail, m => m.MapFrom(source => source.Thumbnail))
                    .ForMember(dest => dest.Small, m => m.MapFrom(source => source.Small))
                    .ForMember(dest => dest.Medium, m => m.MapFrom(source => source.Medium))
                    .ForMember(dest => dest.Large, m => m.MapFrom(source => source.Large))
                    .ForMember(dest => dest.ExtraLarge, m => m.MapFrom(source => source.ExtraLarge))
                    ;

                CreateMap<DataModel.VolumeInfo, BusinessModel.VolumeInfo>().ReverseMap()
                    .ForMember(dest => dest.Title, m => m.MapFrom(source => source.Title))
                    .ForMember(dest => dest.Subtitle, m => m.MapFrom(source => source.Subtitle))
                    .ForMember(dest => dest.Authors, m => m.MapFrom(source => source.Authors))
                    .ForMember(dest => dest.Publisher, m => m.MapFrom(source => source.Publisher))
                    .ForMember(dest => dest.PublishedDate, m => m.MapFrom(source => source.PublishedDate))
                    .ForMember(dest => dest.IndustryIdentifiers, m => m.MapFrom(source => source.IndustryIdentifiers))
                    .ForMember(dest => dest.ReadingModes, m => m.MapFrom(source => source.ReadingModes))
                    .ForMember(dest => dest.PageCount, m => m.MapFrom(source => source.PageCount))
                    .ForMember(dest => dest.Dimensions, m => m.MapFrom(source => source.Dimensions))
                    .ForMember(dest => dest.PrintType, m => m.MapFrom(source => source.PrintType))
                    .ForMember(dest => dest.MainCategory, m => m.MapFrom(source => source.MainCategory))
                    .ForMember(dest => dest.Categories, m => m.MapFrom(source => source.Categories))
                    .ForMember(dest => dest.AverageRating, m => m.MapFrom(source => source.AverageRating))
                    .ForMember(dest => dest.RatingsCount, m => m.MapFrom(source => source.RatingsCount))
                    .ForMember(dest => dest.MaturityRating, m => m.MapFrom(source => source.MaturityRating))
                    .ForMember(dest => dest.AllowAnonLogging, m => m.MapFrom(source => source.AllowAnonLogging))
                    .ForMember(dest => dest.ContentVersion, m => m.MapFrom(source => source.ContentVersion))
                    .ForMember(dest => dest.PanelizationSummary, m => m.MapFrom(source => source.PanelizationSummary))
                    .ForMember(dest => dest.ImageLinks, m => m.MapFrom(source => source.ImageLinks))
                    .ForMember(dest => dest.Language, m => m.MapFrom(source => source.Language))
                    .ForMember(dest => dest.PreviewLink, m => m.MapFrom(source => source.PreviewLink))
                    .ForMember(dest => dest.InfoLink, m => m.MapFrom(source => source.InfoLink))
                    .ForMember(dest => dest.CanonicalVolumeLink, m => m.MapFrom(source => source.CanonicalVolumeLink))
                    ;
            }

            {
                CreateMap<DataModel.Book, BusinessModel.Book>().ReverseMap()
                    .ForMember(dest => dest.Kind, m => m.MapFrom(source => source.Kind))
                    .ForMember(dest => dest.Id, m => m.MapFrom(source => source.Id))
                    .ForMember(dest => dest.Etag, m => m.MapFrom(source => source.Etag))
                    .ForMember(dest => dest.SelfLink, m => m.MapFrom(source => source.SelfLink))
                    .ForMember(dest => dest.VolumeInfo, m => m.MapFrom(source => source.VolumeInfo))
                    .ForMember(dest => dest.SaleInfo, m => m.MapFrom(source => source.SaleInfo))
                    .ForMember(dest => dest.AccessInfo, m => m.MapFrom(source => source.AccessInfo))
                    ;


                CreateMap<DataModel.Shelf, BusinessModel.Shelf>().ReverseMap()
                    .ForMember(dest => dest.Kind, m => m.MapFrom(source => source.Kind))
                    .ForMember(dest => dest.TotalItems, m => m.MapFrom(source => source.TotalItems))
                    .ForMember(dest => dest.Items, m => m.MapFrom(source => source.Items))
                    ;
            }

            {
                CreateMap<DataModel.OptionalSearchRequest, BusinessModel.OptionalSearchRequest>().ReverseMap()
                    .ForMember(dest => dest.Download, m => m.MapFrom(source => source.Download))
                    .ForMember(dest => dest.Filter, m => m.MapFrom(source => source.Filter))
                    .ForMember(dest => dest.LangRestrict, m => m.MapFrom(source => source.LangRestrict))
                    .ForMember(dest => dest.LibraryRestrict, m => m.MapFrom(source => source.LibraryRestrict))
                    .ForMember(dest => dest.MaxResults, m => m.MapFrom(source => source.MaxResults))
                    .ForMember(dest => dest.OrderBy, m => m.MapFrom(source => source.OrderBy))
                    .ForMember(dest => dest.Partner, m => m.MapFrom(source => source.Partner))
                    .ForMember(dest => dest.PrintType, m => m.MapFrom(source => source.PrintType))
                    .ForMember(dest => dest.Projection, m => m.MapFrom(source => source.Projection))
                    .ForMember(dest => dest.Source, m => m.MapFrom(source => source.Source))
                    .ForMember(dest => dest.StartIndex, m => m.MapFrom(source => source.StartIndex))
                    ;
            }

        }

    }

}
