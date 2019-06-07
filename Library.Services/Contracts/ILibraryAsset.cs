using Library.Models;
using System.Collections.Generic;

namespace Library.Services.Contracts
{
    public interface ILibraryAsset
    {
        IEnumerable<LibraryAsset> GetAll();

        LibraryAsset GetById(string id);

        void Add(LibraryAsset newAsset);

        string GetAuthorOrDirector(string id);

        string GetType(string id);

        string GetTitle(string id);

        string GetIsbn(string id);
    }
}
