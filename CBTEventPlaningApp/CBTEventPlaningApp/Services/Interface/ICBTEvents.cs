using CBTEventPlaningApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTEventPlaningApp.Services.Interfaces
{
    public interface ICBTEvent
    {
        public void Create();
        public void Save();
        public List<CBTEvent> GetData();
    }
}
