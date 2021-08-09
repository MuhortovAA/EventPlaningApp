using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventPlaningApp.Services.Models
{
    public class CBTEvent
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime? Create { get; set; }
        public bool? Active { get; set; }
    }
}
