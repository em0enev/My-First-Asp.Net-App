namespace Library.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class LibraryUser
    {
        public string Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public virtual LibraryCard LibraryCard { get; set; }
    }
}
