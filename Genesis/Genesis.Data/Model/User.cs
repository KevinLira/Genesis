using System;
using System.Collections.Generic;

namespace Genesis.Data.Model
{
    public partial class User
    {
        public User()
        {
            Telephone = new HashSet<Telephone>();
        }

        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public DateTime? LastLogin { get; set; }

        public ICollection<Telephone> Telephone { get; set; }
    }
}
