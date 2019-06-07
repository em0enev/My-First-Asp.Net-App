using System;
using System.Collections.Generic;

namespace Library.Models
{
    public class LibraryCard
    {
        public string Id { get; set; }

        public decimal Fees { get; set; }

        public DateTime Created { get; set; }
        public LibraryUser Owner { get; set; }
        public string OwnerId { get; set; }

        public virtual ICollection<Checkout> Checkouts { get; set; }
    }
}
