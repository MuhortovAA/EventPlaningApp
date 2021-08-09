using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTEventPlaningApp.Services.Models
{
	public class CBTDetailes
	{
		public int Id { get; set; }
		public int EventId { get; set; }
		public string Title { get; set; }
		public string SubTitle { get; set; }
	}
}
