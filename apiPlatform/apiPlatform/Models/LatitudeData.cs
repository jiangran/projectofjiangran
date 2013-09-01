using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiPlatform.Models
{
    public class LatitudeData
    {
        public LatitudeData() { }
        public double Latitude { set; get; }
        public double Longitude { set; get; }
        public DateTime CreateTime { set; get; }
    }
}