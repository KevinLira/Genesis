using System;
using System.Collections.Generic;

namespace Genesis.Data.Model
{
    public partial class Telephone
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public Guid UserGuid { get; set; }
        public string Number { get; set; }

        public User UserGu { get; set; }
    }
}
