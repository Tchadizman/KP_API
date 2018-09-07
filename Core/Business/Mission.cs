using System;

namespace KP_API.Core.Business
{

    public class Mission
    {
        public Guid Id {get;set;}
        public string Name {get;set;}
        public Player Targer {get;set;}
    }
    
}