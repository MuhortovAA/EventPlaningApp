using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CBTEventPlaningApp.Services.Models.ViewModel
{
    public class CreateEvent
    {
        [Display(Name = "Дата события", Description = "")]
        public DateTime EventCreate { get; set; }
        [Display(Name = "Количество мест", Description = "")]
        public int CountUser { get; set; }
        [Display(Name = "Название", Description = "")]
        public string Title { get; set; }
        public int UserId { get; set; }
    }
}
