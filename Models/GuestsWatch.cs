using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class GuestsWatch
    {
        public string Id { get; set; } = null!;
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
    }
}
