using CBTEventPlaningApp.Services.Models;
using CBTEventPlaningApp.Services.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTEventPlaningApp.Services.Interface
{
	public interface IEFRepository
	{
		public List<CBTEvent> GetEvents();
		public ViewEvent GetAllInfoEvent(string id);
		public CBTEvent GetEventId(string id);
		public List<CBTDetailes> GetDetailesId(string id);




	}
}
