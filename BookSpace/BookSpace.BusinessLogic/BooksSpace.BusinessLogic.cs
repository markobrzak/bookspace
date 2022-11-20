using BusinessModel.GlobalModels;
using BookSpace.BusinessLogic.Interfaces;
using BookSpace.Services;
using BookSpace.Services.Interface;
using AutoMapper;
using System.Security.Principal;
using BusinessModel;
using System;


namespace BookSpace.BusinessLogic
{

    public class BookSpaceBusinessLogic : IBookSpaceBusinessLogic
    {

        private readonly IBookSpaceService _bookSpaceService;
        private readonly IMapper _mapper;

        public BookSpaceBusinessLogic(IBookSpaceService ebooksService, IMapper mapper)
        {
            _bookSpaceService = ebooksService;
            _mapper = mapper;
        }
        public async Task<ApiResponse<Bookshelves>> GetAllBookshelvesByUserId(string userId)
        {
            var result = new ApiResponse<Bookshelves>();

            var serviceResult = await _bookSpaceService.GetAllBookshelvesByUserId(userId);

            if (serviceResult == null)
            {
                result.Success = false;
                result.Message = new ApiMessage { Type = MessageType.Error, Text = "Error getting data from service method GetAllBookshelvesByUserId." };
                return result;
            }
            var mappedResult = _mapper.Map<Bookshelves>(serviceResult);

            result.Data = mappedResult;

            return result;
        }


        public async Task<ApiResponse<Bookshelf>> GetBookshelfByUserIdAndShelfId(string userId, string shelfId)
        {
            var result = new ApiResponse<Bookshelf>();

            var serviceResult = await _bookSpaceService.GetBookshelfByUserIdAndShelfId(userId, shelfId);

            if (serviceResult == null)
            {
                result.Success = false;
                result.Message = new ApiMessage { Type = MessageType.Error, Text = "Error getting data from service method GetBookshelfByUserIdAndShelfId." };
                return result;
            }
            var mappedResult = _mapper.Map<Bookshelf>(serviceResult);

            result.Data = mappedResult;

            return result;
        }


        public async Task<ApiResponse<Book>> GetVolumeByVolumeId(string volumeId)
        {
            var result = new ApiResponse<Book>();

            var serviceResult = await _bookSpaceService.GetVolumeByVolumeId(volumeId);

            if (serviceResult == null)
            {
                result.Success = false;
                result.Message = new ApiMessage { Type = MessageType.Error, Text = "Error getting data from service method GetVolumeByVolumeId." };
                return result;
            }
            var mappedResult = _mapper.Map<Book>(serviceResult);

            result.Data = mappedResult;

            return result;
        }

        public async Task<ApiResponse<Shelf>> VolumeSearch(string searchTerm, OptionalSearchRequest optionalSearchRequest)
        {
            var result = new ApiResponse<Shelf>();

            var mappedRequest = _mapper.Map<DataModel.OptionalSearchRequest>(optionalSearchRequest);

            var serviceResult = await _bookSpaceService.VolumeSearch(searchTerm, mappedRequest);

            if (serviceResult == null)
            {
                result.Success = false;
                result.Message = new ApiMessage { Type = MessageType.Error, Text = "Error getting data from service method VolumeSearch." };
                return result;
            }
            var mappedResult = _mapper.Map<Shelf>(serviceResult);


            result.Data = mappedResult;

            return result;
        }


        public async Task<ApiResponse<Shelf>> GetBookshelfVolumesByUserIdAndShelfId(string userId, string shelfId)
        {
            var result = new ApiResponse<Shelf>();

            var serviceResult = await _bookSpaceService.GetBookshelfVolumesByUserIdAndShelfId(userId, shelfId);

            if (serviceResult == null)
            {
                result.Success = false;
                result.Message = new ApiMessage { Type = MessageType.Error, Text = "Error getting data from service method GetBookshelfVolumesByUserIdAndShelfId." };
                return result;
            }
            var mappedResult = _mapper.Map<Shelf>(serviceResult);

            result.Data = mappedResult;

            return result;
        }
    }

}