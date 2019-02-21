using System;
using System.Linq;
using System.Collections.Generic;
using RegistrationAPI.Models;

namespace RegistrationAPI
{
    public class CitiesDataStore
    {
        public List<Cities> Cities { get; set; }

        public CitiesDataStore(){

            Cities = new List<Cities>(){
                new Cities(){
                    id = 1,
                    name = "Ankara",
                    description = "Capital",
                    pointOfInterests = new List<PointOfInterests>(){
                        new PointOfInterests(){
                            id = 1,
                            name = "Atakule",
                            description = "Ankara Atakule",
                        },
                        new PointOfInterests(){
                            id = 2,
                            name = "Anitkabir",
                            description = "Ankara Atakule",
                        },
                        new PointOfInterests(){
                            id = 3,
                            name = "Ankamall",
                            description = "Ankara Atakule",
                        },

                    }
                },
                 new Cities(){
                    id = 2,
                    name = "Istanbul",
                    description = "Economic Capital",
                    pointOfInterests = new List<PointOfInterests>(){
                        new PointOfInterests(){
                            id = 1,
                            name = "Atakule",
                            description = "Ankara Atakule",
                        },
                        new PointOfInterests(){
                            id = 2,
                            name = "Anitkabir",
                            description = "Ankara Atakule",
                        },
                        new PointOfInterests(){
                            id = 3,
                            name = "Ankamall",
                            description = "Ankara Atakule",
                        },

                    }
                },
                 new Cities(){
                    id = 3,
                    name = "Izmir",
                    description = " Sex Capital",
                    pointOfInterests = new List<PointOfInterests>(){
                        new PointOfInterests(){
                            id = 1,
                            name = "Atakule",
                            description = "Ankara Atakule",
                        },
                        new PointOfInterests(){
                            id = 2,
                            name = "Anitkabir",
                            description = "Ankara Atakule",
                        },
                        new PointOfInterests(){
                            id = 3,
                            name = "Ankamall",
                            description = "Ankara Atakule",
                        },

                    }
                }


            };
        }
    }
}
