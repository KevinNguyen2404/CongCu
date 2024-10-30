using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class Song
    {
        public Song()
        {
            SongCategories = new HashSet<SongCategory>();
            SongSingers = new HashSet<SongSinger>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }
        public int? IdChord { get; set; }
        public int? IdAuthor { get; set; }
        public int? IdCountryComposes { get; set; }
        public int? IdGroupOfSingers { get; set; }
        public int? IdUser { get; set; }
        public bool? Activity { get; set; }
        public string? Url { get; set; }
        public string? Tag { get; set; }
        public DateTime? Date { get; set; }
        public string? Link { get; set; }

        public virtual Author? IdAuthorNavigation { get; set; }
        public virtual Chord? IdChordNavigation { get; set; }
        public virtual SongOfCountryCompose? IdCountryComposesNavigation { get; set; }
        public virtual GroupOfSinger? IdGroupOfSingersNavigation { get; set; }
        public virtual User? IdUserNavigation { get; set; }
        public virtual ICollection<SongCategory> SongCategories { get; set; }
        public virtual ICollection<SongSinger> SongSingers { get; set; }
    }
}
