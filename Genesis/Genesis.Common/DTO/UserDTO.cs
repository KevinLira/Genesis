using System;
using System.Collections.Generic;
namespace Genesis.Common.DTO
{
    public class UserDTO : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public DateTime? LastLogin { get; set; }
        public List<TelephoneDTO> Telephones { get; set; }

    }
}
