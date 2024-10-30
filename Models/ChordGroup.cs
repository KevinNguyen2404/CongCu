using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class ChordGroup
    {
        public ChordGroup()
        {
            ChordChordGroups = new HashSet<ChordChordGroup>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<ChordChordGroup> ChordChordGroups { get; set; }
    }
}
