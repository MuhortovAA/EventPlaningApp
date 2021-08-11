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
        public void EditTitle(CBTDetailes detail);
        public void SaveTitle(CBTDetailes detail);
        public CBTDetailes GetDetaileById(string id);
        public List<ViewFullEvent> GetAllFullEvents();
        public List<CBTEvent> GetEvents();
        public ViewEvent GetAllInfoEvent(string id);
        public CBTEvent GetEvent(string id);
        public List<CBTDetailes> GetDetailesById(string id);

        public int SaveEvent(CreateEvent newevent);
        public int GetId(CreateEvent newevent);

        public void Save();
        


    }
}
