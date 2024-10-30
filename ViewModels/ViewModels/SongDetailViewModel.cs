using WebChordCore.Models;

namespace WebChordCore.ViewModels
{
    public class SongDetailViewModel
    {
        public Song Song { get; set; }
        public string AuthorName { get; set; }
        public string SingerName { get; set; }
        public string CategoryName { get; set; }
        public string ChordName { get; set; }
    }
}
