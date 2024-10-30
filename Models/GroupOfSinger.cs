using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class GroupOfSinger
    {
        public GroupOfSinger()
        {
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? NumberOfMembers { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
