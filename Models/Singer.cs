using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class Singer
    {
        public Singer()
        {
            SingerTones = new HashSet<SingerTone>();
            SongSingers = new HashSet<SongSinger>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<SingerTone> SingerTones { get; set; }
        public virtual ICollection<SongSinger> SongSingers { get; set; }
    }
}
