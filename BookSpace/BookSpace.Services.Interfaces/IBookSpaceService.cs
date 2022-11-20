using DataModel;
using System;

namespace BookSpace.Services.Interface
{
    public interface IBookSpaceService
    {
        Task<Bookshelves> GetAllBookshelvesByUserId(string userId);
        Task<Bookshelf> GetBookshelfByUserIdAndShelfId(string userId, string shelfId);
        Task<Book> GetVolumeByVolumeId(string volumeId);
        Task<Shelf> VolumeSearch(string searchTerm, OptionalSearchRequest optionalSearchRequest);
        Task<Shelf> GetBookshelfVolumesByUserIdAndShelfId(string userId, string shelfId);
    }
}