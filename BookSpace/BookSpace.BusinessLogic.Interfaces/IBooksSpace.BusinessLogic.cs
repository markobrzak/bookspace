using BusinessModel;
using BusinessModel.GlobalModels;
using System;

namespace BookSpace.BusinessLogic.Interfaces
{
    public interface IBookSpaceBusinessLogic
    {
        Task<ApiResponse<Bookshelves>> GetAllBookshelvesByUserId(string userId);
        Task<ApiResponse<Bookshelf>> GetBookshelfByUserIdAndShelfId(string userId, string shelfId);
        Task<ApiResponse<Book>> GetVolumeByVolumeId(string volumeId);
        Task<ApiResponse<Shelf>> VolumeSearch(string searchTerm, OptionalSearchRequest? optionalSearchRequest);
        Task<ApiResponse<Shelf>> GetBookshelfVolumesByUserIdAndShelfId(string userId, string shelfId);
    }
}