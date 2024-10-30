using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class ChordChordGroup
    {
        public int Id { get; set; }
        public int? IdChord { get; set; }
        public int? IdChorGroup { get; set; }

        public virtual ChordGroup? IdChorGroupNavigation { get; set; }
        public virtual Chord? IdChordNavigation { get; set; }
    }
}
