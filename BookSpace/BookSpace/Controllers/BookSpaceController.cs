using BusinessModel;
using BookSpace.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookSpace.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookSpaceController : ControllerBase
    {
        private readonly IBookSpaceBusinessLogic _bookSpaceBL;

        public BookSpaceController(IBookSpaceBusinessLogic bookSpaceBL)
        {
            _bookSpaceBL = bookSpaceBL;
        }


        [HttpGet("GetAllBookshelvesByUserId")]
        public async Task<IActionResult> GetAllBookshelvesByUserId(string userId)
        {
            return Ok(await _bookSpaceBL.GetAllBookshelvesByUserId(userId));
        }

        [HttpGet("GetBookshelfByUserIdAndShelfId")]
        public async Task<IActionResult> GetBookshelfByUserIdAndShelfId(string userId, string shelfId)
        {
            return Ok(await _bookSpaceBL.GetBookshelfByUserIdAndShelfId(userId, shelfId));
        }


        [HttpGet("GetVolumeByVolumeId")]
        public async Task<IActionResult> GetVolumeByVolumeId(string volumeId)
        {
            return Ok(await _bookSpaceBL.GetVolumeByVolumeId(volumeId));
        }

        [HttpPost("VolumeSearch")]
        public async Task<IActionResult> VolumeSearch(string searchTerm, OptionalSearchRequest? optionalSearchRequest)
        {
            return Ok(await _bookSpaceBL.VolumeSearch(searchTerm, optionalSearchRequest));
        }

        [HttpGet("GetBookshelfVolumesByUserIdAndShelfId")]
        public async Task<IActionResult> GetBookshelfVolumesByUserIdAndShelfId(string userId, string shelfId)
        {
            return Ok(await _bookSpaceBL.GetBookshelfVolumesByUserIdAndShelfId(userId, shelfId));
        }
    }
}
