using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHALANX_Equipment_Search.Models
{
    public class SerialisedEquipment
    {
        public string Id { get; set; }
        public string ExternalId { get; set; }
        public string EquipmentTypeId { get; set; }
        public int MeterReading { get; set; }
    }
}