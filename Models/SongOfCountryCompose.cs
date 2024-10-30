using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class SongOfCountryCompose
    {
        public SongOfCountryCompose()
        {
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
