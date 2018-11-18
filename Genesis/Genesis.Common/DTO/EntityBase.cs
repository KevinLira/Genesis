using System;
namespace Genesis.Common.DTO
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }
        public Guid Guid { get; set; }
        public EntityBase()
        {
        }
    }
}
