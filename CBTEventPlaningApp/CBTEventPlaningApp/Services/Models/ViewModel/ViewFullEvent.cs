using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTEventPlaningApp.Services.Models.ViewModel
{
    public class ViewFullEvent
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CountUser { get; set; }
        public DateTime EventCreate { get; set; }
        public string SubTitle { get; set; }
    }
}
