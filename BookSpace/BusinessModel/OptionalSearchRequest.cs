namespace BusinessModel
{
    public class OptionalSearchRequest
    {
        public string? Download { get; set; }
        public string? Filter { get; set; }
        public string? LangRestrict { get; set; }
        public string? LibraryRestrict { get; set; }
        public int? MaxResults { get; set; }
        public string? OrderBy { get; set; }
        public string? Partner { get; set; }
        public string? PrintType { get; set; }
        public string? Projection { get; set; }
        public string? Source { get; set; }
        public int? StartIndex { get; set; }
    }
}