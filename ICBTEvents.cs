using EventPlaningApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventPlaningApp.Services.Interfaces
{
    public interface ICBTEvent
    {
        void Create();
        void Save();
        List<CBTEvent> GetData();
    }
}
