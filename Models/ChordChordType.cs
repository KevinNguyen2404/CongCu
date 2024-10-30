using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class ChordChordType
    {
        public string Id { get; set; } = null!;
        public int? IdChord { get; set; }
        public int? IdChorType { get; set; }

        public virtual ChordType? IdChorTypeNavigation { get; set; }
        public virtual Chord? IdChordNavigation { get; set; }
    }
}
