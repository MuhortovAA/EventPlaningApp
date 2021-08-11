using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CBTEventPlaningApp.Services.Models
{
	public class CBTDetailes
	{
		public int Id { get; set; }
		public int EventId { get; set; }
		[Display(Name = "Действие", Description = "")]
		public string Title { get; set; }
		[Display(Name = "Описаний", Description = "")]
		public string SubTitle { get; set; }
	}
}
