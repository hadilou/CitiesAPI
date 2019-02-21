using System;
using System.Collections.Generic;

namespace RegistrationAPI.Models

{
    public class Cities
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
        public List<PointOfInterests> pointOfInterests
        {
            get;
            set;
        }
    }
}
