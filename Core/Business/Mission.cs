using System;
using KP_API.AppStart;
using KP_API.Core.ServiceInterface;

namespace KP_API.Core.Business
{

    public class Mission
    {
        public Guid Id {get;set;}
        public string Name {get;set;}
        public Player Targer {get;set;}

        public static Mission GetRandomMission()
        {
            return IocContainer.GetInstance<IMissionService>().GetRandomMission();
        }
    }
    
}