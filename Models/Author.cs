using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class Author
    {
        public Author()
        {
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string? ComposerName { get; set; }
        public string? AuthorName { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
