using BoatClients.PiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClients.PiData
{
    public class BoatPiManager
    {
        IBoatPiService boatPiService;

        public BoatPiManager(IBoatPiService boatPi)
        {
            boatPiService = boatPi;
        }

        public Task<PiCurrentTemp> GetCurrentTemp()
        {
            var ct = boatPiService.GetCurrentTemp();

            return ct;
        }

    }
}
