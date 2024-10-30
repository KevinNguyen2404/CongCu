using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class Tone
    {
        public Tone()
        {
            SingerTones = new HashSet<SingerTone>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<SingerTone> SingerTones { get; set; }
    }
}
