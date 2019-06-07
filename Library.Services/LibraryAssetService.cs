using Library.Data;
using Library.Models;
using Library.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Library.Services
{
    public class LibraryAssetService : ILibraryAsset
    {
        private LibraryContext context;

        public LibraryAssetService(LibraryContext context)
        {
            this.context = context;
        }
        public void Add(LibraryAsset newAsset)
        {
            this.context.Add(newAsset);
            this.context.SaveChanges();
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return this.context.LibraryAssets
                .Include(a => a.Status)
                .ToList();
        }

        public string GetAuthorOrDirector(string id)
        {
            if (IsBook(id))
            {
                return context.Books
                    .Find(id)
                    .Author;
            }
            else
            {
                return this.context.Videos
                    .Find(id)
                    .Director;
            }
        }

        public LibraryAsset GetById(string id)
        {
            return this.context
                .LibraryAssets
                .Find(id);
        }

        public string GetIsbn(string id)
        {
            if (IsBook(id))
            {
                return context.Books
                    .Find(id)
                    .ISBN;
            }

            return string.Empty;
        }

        public string GetTitle(string id)
        {
            return GetById(id)
                .Title;
        }

        public string GetType(string id)
        {
            return GetById(id)
                .GetType()
                .ToString();
        }

        private bool IsBook(string id)
        {
            return this.context.LibraryAssets
                .OfType<Book>()
                .Where(x => x.Id == id)
                .Any();
        }
    }
}
