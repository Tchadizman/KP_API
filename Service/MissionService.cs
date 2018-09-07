using KP_API.Core.Business;
using KP_API.Core.ServiceInterface;

namespace KP_API.Service
{
    public class MissionService : IMissionService
    {
        public Mission GetRandomMission()
        {
            //pour test, initialiser une BDD ensuiste
            return new Mission(){
                Id = new System.Guid(),
                Name = "Test Mission",
            };
        }
    }
}