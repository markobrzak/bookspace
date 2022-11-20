using AutoMapper.Configuration;
using DataModel;
using BookSpace.Services.Interface;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

using System.Security.Principal;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Win32;

namespace BookSpace.Services
{
    public class BookSpaceService : IBookSpaceService
    {
        private readonly IConfiguration? _config;
        private readonly string _userId;
        private readonly string _GoogleBooksAPIBaseAddress;

        private readonly string _GetAllBookshelvesByUserId;
        private readonly string _GetBookshelfByUserIdAndShelfId;

        private readonly string _GetVolumeByVolumeId;
        private readonly string _VolumeSearch;

        private readonly string _GetBookshelfVolumesByUserIdAndShelfId;



        public BookSpaceService(IConfiguration config)
        {
            _config = config;
            _userId = _config["USERID"];
            _GoogleBooksAPIBaseAddress = _config["GoogleBooksAPIBaseAddress"];
            _GetAllBookshelvesByUserId = _config["GoogleBooksAPIMethods:GetAllBookshelvesByUserId"];
            _GetBookshelfByUserIdAndShelfId = _config["GoogleBooksAPIMethods:GetBookshelfByUserIdAndShelfId"];

            _GetVolumeByVolumeId = _config["GoogleBooksAPIMethods:GetVolumeByVolumeId"];
            _VolumeSearch = _config["GoogleBooksAPIMethods:VolumeSearch"];

            _GetBookshelfVolumesByUserIdAndShelfId = _config["GoogleBooksAPIMethods:GetBookshelfVolumesByUserIdAndShelfId"];

        }

        public async Task<Bookshelves> GetAllBookshelvesByUserId(string userId)
        {


            HttpClient client = new HttpClient();
            var bookshelves = new Bookshelves();
            client.BaseAddress = new Uri(_GoogleBooksAPIBaseAddress);

            var response = await client.GetAsync(string.Format(_GetAllBookshelvesByUserId, userId));

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var serializedResponse = JsonConvert.DeserializeObject<Bookshelves>(content);

                if (serializedResponse == null)
                {
                    return new Bookshelves();
                }
                bookshelves = serializedResponse;

            }

            else
            {
                return null;
            }

            return bookshelves;

        }

        public async Task<Bookshelf> GetBookshelfByUserIdAndShelfId(string userId, string shelfId)
        {
            HttpClient client = new HttpClient();
            var shelf = new Bookshelf();
            client.BaseAddress = new Uri(_GoogleBooksAPIBaseAddress);

            var response = await client.GetAsync(string.Format(_GetBookshelfByUserIdAndShelfId, userId, shelfId));

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var serializedResponse = JsonConvert.DeserializeObject<Bookshelf>(content);

                if (serializedResponse == null)
                {
                    return new Bookshelf();
                }
                shelf = serializedResponse;

            }

            else
            {
                return null;
            }

            return shelf;
        }

        public async Task<Book> GetVolumeByVolumeId(string volumeId)
        {


            HttpClient client = new HttpClient();
            var book = new Book();
            client.BaseAddress = new Uri(_GoogleBooksAPIBaseAddress);

            var response = await client.GetAsync(string.Format(_GetVolumeByVolumeId, volumeId));

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var serializedResponse = JsonConvert.DeserializeObject<Book>(content);

                if (serializedResponse == null)
                {
                    return new Book();
                }
                book = serializedResponse;

            }

            else
            {
                return null;
            }

            return book;

        }

        public async Task<Shelf> VolumeSearch(string searchTerm, OptionalSearchRequest? optionalSearchRequest)
        {
            HttpClient client = new HttpClient();
            var shelf = new Shelf();
            client.BaseAddress = new Uri(_GoogleBooksAPIBaseAddress);

            if (optionalSearchRequest != null)
            {
                PropertyInfo[] props = optionalSearchRequest.GetType().GetProperties();

                foreach (PropertyInfo prop in props)
                {
                    var val = prop.GetValue(optionalSearchRequest, null);
                    var name = char.ToLower(prop.Name[0]) + prop.Name.Substring(1);

                    if (val == null || string.Compare(val.ToString(), "string") == 0) { continue; }

                    if (val is not null and not (object?)0)
                    {
                        searchTerm = searchTerm + "&" + name + "=" + val;
                    }
                }
            }

            var response = await client.GetAsync(string.Format(_VolumeSearch, searchTerm));

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var serializedResponse = JsonConvert.DeserializeObject<Shelf>(content);

                if (serializedResponse == null)
                {
                    return new Shelf();
                }
                shelf = serializedResponse;

            }

            else
            {
                return null;
            }

            return shelf;
        }

        public async Task<Shelf> GetBookshelfVolumesByUserIdAndShelfId(string userId, string shelfId)
        {
            HttpClient client = new HttpClient();
            var shelf = new Shelf();
            client.BaseAddress = new Uri(_GoogleBooksAPIBaseAddress);

            var response = await client.GetAsync(string.Format(_GetBookshelfVolumesByUserIdAndShelfId, userId, shelfId));

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var serializedResponse = JsonConvert.DeserializeObject<Shelf>(content);

                if (serializedResponse == null)
                {
                    return new Shelf();
                }
                shelf = serializedResponse;

            }

            else
            {
                return null;
            }

            return shelf;
        }
    }
}