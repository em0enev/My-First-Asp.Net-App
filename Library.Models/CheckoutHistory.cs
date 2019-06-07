using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class CheckoutHistory
    {
        public int Id { get; set; }

        public LibraryAsset LibraryAsset { get; set; }

        public LibraryCard LibraryCard { get; set; }

        public DateTime ChekedOut { get; set; }

        public DateTime? ChekedIn { get; set; }

    }
}
