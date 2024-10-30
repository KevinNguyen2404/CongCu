using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class ListOfImage
    {
        public ListOfImage()
        {
            Chords = new HashSet<Chord>();
        }

        public int Id { get; set; }
        public string? Url { get; set; }

        public virtual ICollection<Chord> Chords { get; set; }
    }
}
