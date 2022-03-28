using System;

namespace mvcIntro.Entities.Shared
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}