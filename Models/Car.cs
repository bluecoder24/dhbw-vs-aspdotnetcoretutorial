using System;

namespace dhbw_vs_aspdotnetcoretutorial.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public double PurchasePrice { get; set; }
        public DateTime FirstRegistration { get; set;}
    }
}
