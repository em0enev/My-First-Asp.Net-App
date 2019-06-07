using Library.Models;
using Library.Models.Catalog;
using Library.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class CatalogController : Controller
    {
        private ILibraryAsset libraryAsset;
        public CatalogController(ILibraryAsset libraryAsset)
        {
            this.libraryAsset = libraryAsset;
        }

        public IActionResult Index()
        {
            var assetModels = libraryAsset.GetAll();

            var listingResult = assetModels
                .Select(result => new AssetIndexListingModel
                {
                    Id = result.Id,
                    Title = result.Title,
                    ImageUrl = result.ImageUrl,
                    AuthorOrDirector = libraryAsset.GetAuthorOrDirector(result.Id),
                    NumberOfCopies = result.NumberOfCopies.ToString(),
                    Type = libraryAsset.GetType(result.Id)
                });

            var model = new AssetIndexModel()
            {
                Assets = listingResult
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(string title, string url, string author, string type)
        {
            var book = new Book()
            {
                Title = title,
                ImageUrl = url,
                Author = author,
                Cost = 10m,
                NumberOfCopies = 1,
                ISBN = "dsasd1ds",
                Status = new Status()
            };

            libraryAsset.Add(book);

            return Redirect("/Catalog");
        }
    }
}
