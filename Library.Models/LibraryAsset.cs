using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public abstract class LibraryAsset
    {
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public decimal Cost { get; set; }

        public string ImageUrl { get; set; }

        public int NumberOfCopies { get; set; }
    }
}
