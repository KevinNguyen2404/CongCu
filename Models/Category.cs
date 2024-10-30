using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class Category
    {
        public Category()
        {
            SongCategories = new HashSet<SongCategory>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<SongCategory> SongCategories { get; set; }
    }
}
