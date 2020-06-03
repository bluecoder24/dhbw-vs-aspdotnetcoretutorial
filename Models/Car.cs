using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dhbw_vs_aspdotnetcoretutorial.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public double PurchasePrice { get; set; }
        public DateTime FirstRegistration { get; set;}
    }
}
