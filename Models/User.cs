using System;
using System.Collections.Generic;

namespace WebChordCore.Models
{
    public partial class User
    {
        public User()
        {
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? DienThoai { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int? IdUserGroup { get; set; }

        public virtual UserGroup? IdUserGroupNavigation { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
