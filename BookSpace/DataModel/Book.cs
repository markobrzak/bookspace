using DataModel;

namespace DataModel
{
    public class Book
    {
        public string Kind { get; set; }
        public string Id { get; set; }
        public string Etag { get; set; }
        public string SelfLink { get; set; }
        public VolumeInfo VolumeInfo { get; set; }
        public UserInfo UserInfo { get; set; }
        public SaleInfo SaleInfo { get; set; }
        public AccessInfo AccessInfo { get; set; }

    }
}