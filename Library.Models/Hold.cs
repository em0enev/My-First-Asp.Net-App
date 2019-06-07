using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class Hold
    {
        public string Id { get; set; }

        public virtual LibraryAsset LibraryAsset { get; set; }

        public virtual LibraryCard LibraryCard { get; set; }

        public DateTime HoldPlacer { get; set; }

    }
}
