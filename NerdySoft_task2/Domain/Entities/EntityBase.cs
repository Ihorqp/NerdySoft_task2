using System;
using System.ComponentModel.DataAnnotations;

namespace NerdySoft_task2.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get;set; }
        
        [Display(Name = "Назва (заголовок)")]
        [Required]
        public virtual string Title { get; set; }

        //[Display(Name = "Коротке описання")]
        //[Required]
        //public virtual string Subtitle { get; set; }

        [Display(Name = "Повне описання")]
        [Required]
        public virtual string Text { get; set; }

        [Display(Name = "Титульна картинка")]
        public virtual string TitleImagePath { get; set; }


        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
