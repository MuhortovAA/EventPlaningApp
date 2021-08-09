using CBTEventPlaningApp.Services.Interface;
using CBTEventPlaningApp.Services.Models;
using CBTEventPlaningApp.Services.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTEventPlaningApp.Services.Repository
{
	public class EFRepository : IEFRepository
	{
		private ApplicationDbContext context;

		public EFRepository(ApplicationDbContext ctx)
		{
			context = ctx;
		}
		//список всех событий
		public List<CBTEvent> GetEvents() => context.CBTEvents.ToList();
		//событие и детали по нему
		public ViewEvent GetAllInfoEvent(string id) => new ViewEvent() { item = this.GetEventId(id), detailes =this.GetDetailesId(id) };
		//событие
		public CBTEvent GetEventId(string id) => context.CBTEvents.Where(e => e.Id == int.Parse(id)).First();
		//список деталий по событию
		public List<CBTDetailes> GetDetailesId(string id) => context.CBTDetailes.Where(e => e.Id == int.Parse(id)).ToList();

	}
}
