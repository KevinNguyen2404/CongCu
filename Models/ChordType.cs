using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class ChordType
    {
        public ChordType()
        {
            ChordChordTypes = new HashSet<ChordChordType>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<ChordChordType> ChordChordTypes { get; set; }
    }
}
