using System;
using System.ComponentModel.DataAnnotations;
using mvcIntro.Entities.Shared;

namespace mvcIntro.Entities
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        [Required(ErrorMessage = "Name cannot be empty.")]
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public string ImgURL { get; set; }
        public int? Pages { get; set; }
        public long? Isbn { get; set; }
        public int? LanguageId { get; set; }
        public int? FormatId { get; set; }
        public int? CategoryId { get; set; }
    }
}
