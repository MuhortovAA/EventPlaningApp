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
        //
        public List<ViewFullEvent> GetAllFullEvents()
        {
            var listevents = new List<ViewFullEvent>();
            foreach (var item in context.CBTEvents)
            {
                var subtitle = context.CBTDetailes.Where(e => e.EventId == item.Id && e.Title == "Тема").FirstOrDefault();
                var eventView = new ViewFullEvent() { Id = item.Id, UserId = item.UserId, CountUser = item.CountUser, EventCreate = item.EventCreate, SubTitle = subtitle?.SubTitle ?? "тема не найдена" };
                listevents.Add(eventView);
            }
            return listevents;
        }
        //
        public CBTDetailes GetDetaileById(string id) => context.CBTDetailes.Where(d => d.Id == int.Parse(id)).First();

        //список всех событий
        public List<CBTEvent> GetEvents() => context.CBTEvents.ToList();
        //событие и детали
        public ViewEvent GetAllInfoEvent(string id) => new ViewEvent() { item = this.GetEvent(id), detailes = this.GetDetailesById(id) };

        public CBTEvent GetEvent(string id) => context.CBTEvents.Where(e => e.Id == int.Parse(id)).First();
        /// <summary>
        /// Список деталей по событию
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CBTDetailes> GetDetailesById(string id) => context.CBTDetailes.Where(e => e.EventId == int.Parse(id)).ToList();

        public int SaveEvent(CreateEvent newevent)
        {
            context.CBTEvents.Add(new CBTEvent() { CountUser = newevent.CountUser, UserId = newevent.UserId, EventCreate = newevent.EventCreate });
            this.Save();

            var id = this.GetId(newevent);
            context.CBTDetailes.Add(new CBTDetailes() { EventId = id, Title = "Тема", SubTitle = newevent.Title });
            this.Save();

            return id;
        }
        /// <summary>
        /// сохранить детали по событию
        /// </summary>
        /// <param name="detail"></param>
        public void SaveTitle(CBTDetailes detail)
        {
            context.CBTDetailes.Add(new CBTDetailes() { EventId = detail.EventId, Title = detail.Title, SubTitle = detail.SubTitle });
            this.Save();
        }

        public void EditTitle(CBTDetailes detail)
        {
            context.CBTDetailes.Update(new CBTDetailes() { EventId = detail.EventId, Title = detail.Title, SubTitle = detail.SubTitle, Id = detail.Id });
            this.Save();
        }


        //
        public void Save() => context.SaveChanges();

        public int GetId(CreateEvent newevent) => context.CBTEvents.Where(e => e.UserId == newevent.UserId && e.CountUser == newevent.CountUser && e.EventCreate == newevent.EventCreate).First().Id;
    }
}
