using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTEventPlaningApp.Services.Models.ViewModel
{
	public class ViewEvent
	{
		public CBTEvent item { get; set; }
		public List<CBTDetailes> detailes { get; set; }
	}
}
