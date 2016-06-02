using System;

namespace BoatClients.PiModels
{
    public class PiLocation
    {
        public DateTime Date { get; set; }
        public string DeviceId { get; set; }
        public Guid Id { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public decimal Speed { get; set; }
        public decimal Track { get; set; }
    }
}
