using System;
using System.Collections.Generic;
using System.Linq;
namespace RegistrationAPI.Models
{
    public class PointOfInterests
    {

        public int id
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public string description
        {
            get;
            set;
        }
        public int  numberOfPointsOfInterests
        {
            get
            {
                return pointsOfInterest.Count;
            }
        }

        public ICollection<PointOfInterests> pointsOfInterest = new List<PointOfInterests>();

       
    }
}
