using BoatClients.PiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClients.PiData
{
    public interface IBoatPiService
    {
        Task<List<PiLocation>> GetLocationsAsync();

        Task<List<PiTemperature>> GetTemperaturesAsync();

        Task<PiCurrentTemp> GetCurrentTemp();
    }
}
