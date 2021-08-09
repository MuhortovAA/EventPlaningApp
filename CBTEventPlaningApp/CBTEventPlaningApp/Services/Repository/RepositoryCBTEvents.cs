using CBTEventPlaningApp.Services.Interfaces;
using CBTEventPlaningApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTEventPlaningApp.Services.Repository
{
    public class RepositoryCBTEvents : ICBTEvent
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

		public List<CBTEvent> GetData()
		{
            var items = new List<CBTEvent>() {

                    //new CBTEvent() {
                    //    Id = 1,
                    //    Create = DateTime.Now,
                    //    //Active = true,
                    //    UserId = 1 },
                    //new CBTEvent() {
                    //    Id = 2,
                    //    Create = DateTime.Now,
                    //    //Active = true,
                    //    UserId = 1 }
                 };
            return items;
        }
	}
}
