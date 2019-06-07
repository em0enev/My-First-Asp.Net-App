using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class Checkout
    {
        public string Id { get; set; }

        public LibraryAsset LibraryAsset { get; set; }

        public LibraryCard LibraryCard { get; set; }

        public DateTime Since { get; set; }

        public DateTime Until { get; set; }
    }
}
