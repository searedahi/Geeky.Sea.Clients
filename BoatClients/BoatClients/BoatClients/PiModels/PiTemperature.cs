using System;

namespace BoatClients.PiModels
{
    public class PiTemperature
    {
        public DateTime Date { get; set; }
        public string DeviceId { get; set; }
        public Guid Id { get; set; }
        public int SensorReading { get; set; }
    }
}
