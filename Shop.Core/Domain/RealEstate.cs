using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class RealEstate
    {
        public Guid Guid { set; get; }
        public string Address { set; get; }
        public float SizeSqrtM { get; set; }
        public int RoomCount { get; set; }

        public int Floor { get; set; }
        public string BuildingType { get; set; }
        public DateTime BuildInYear { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    
    }
}
