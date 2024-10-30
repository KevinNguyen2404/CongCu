using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class Chord
    {
        public Chord()
        {
            ChordChordGroups = new HashSet<ChordChordGroup>();
            ChordChordTypes = new HashSet<ChordChordType>();
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? KeyNo { get; set; }
        public int? IdListOfImage { get; set; }

        public virtual ListOfImage? IdListOfImageNavigation { get; set; }
        public virtual ICollection<ChordChordGroup> ChordChordGroups { get; set; }
        public virtual ICollection<ChordChordType> ChordChordTypes { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
