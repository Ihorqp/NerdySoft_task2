using System;
using System.ComponentModel.DataAnnotations;

namespace NerdySoft_task2.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заповніть назву оголошення")]
        [Display(Name = "Назва")]
        public override string Title { get; set; }

        //[Display(Name = "Описанея оголошення")]
        //public override string Subtitle { get; set; }

        [Required(ErrorMessage = "Заповніть текст оголошення")]
        [Display(Name = "Повне описання оголошення")]
        public override string Text { get; set; }

    }
}
