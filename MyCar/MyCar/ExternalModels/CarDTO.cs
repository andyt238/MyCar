using System;

namespace Mycar.ExternalModels
{
    public class CarDTO
    {
        public Guid Id { get; set; }

        public string Producator { get; set; }

        public string Model { get; set; }

        public Guid UserId { get; set; }

        public CarDTO Car { get; set; }
    }
}