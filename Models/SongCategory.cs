using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class SongCategory
    {
        public int Id { get; set; }
        public int? IdSong { get; set; }
        public int? IdCategory { get; set; }

        public virtual Category? IdCategoryNavigation { get; set; }
        public virtual Song? IdSongNavigation { get; set; }
    }
}
