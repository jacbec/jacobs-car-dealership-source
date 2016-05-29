using System;

namespace JacobsCarDealership
{
    class Car
    {
        //Vehicle Constructor
        public Car(string type)
        {
            //Set the type
            this.Type = type;
        }

        //Method for getting and setting Type
        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        //Method for getting and setting Condition
        public string Condition { get; set; }

        //Method for getting and setting Make
        public string Make { get; set; }
        //Method for getting and setting Model
        public string Model { get; set; }
        //Method for getting and setting Year
        public string Year { get; set; }
        //Method for getting and setting Mileage
        public int Mileage { get; set; }
        //Method for getting and setting Color
        public string Color { get; set; }

        //Method for getting and setting Doors
        private int doors;
        public int Doors
        {
            get
            {
                return doors;
            }
            set
            {
                switch (Type)
                {
                    //Set amount of doors if Type is Coupe
                    case "Coupe":
                        {
                            int maxDoors = 2;

                            if (value != maxDoors)
                            {
                                doors = maxDoors;
                            }
                            else
                            {
                                doors = value;
                            }

                            break;
                        }
                    //Set amount of doors if Type is Sedan
                    case "Sedan":
                        {
                            int maxDoors = 4;

                            if (value != maxDoors)
                            {
                                doors = maxDoors;
                            }
                            else
                            {
                                doors = value;
                            }

                            break;
                        }
                    //Set amount of doors if Type is Van
                    case "Van":
                        {
                            int maxDoors = 5;

                            if (value != maxDoors)
                            {
                                doors = maxDoors;
                            }
                            else
                            {
                                doors = value;
                            }

                            break;
                        }
                    //Set amount of doors if Type is Convertible
                    case "Convertible":
                        {
                            int minDoors = 2;
                            int maxDoors = 4;

                            if (value < minDoors)
                            {
                                doors = minDoors;
                            }
                            else if (value > maxDoors)
                            {
                                doors = maxDoors;
                            }
                            else
                            {
                                doors = value;
                            }

                            break;
                        }
                    //Set amount of doors if Type is Truck
                    case "Truck":
                        {
                            int minDoors = 2;
                            int maxDoors = 4;

                            if (value < minDoors)
                            {
                                doors = minDoors;
                            }
                            else if (value > maxDoors)
                            {
                                doors = maxDoors;
                            }
                            else
                            {
                                doors = value;
                            }

                            break;
                        }
                }
            }
        }

        //Method for getting and setting RoofType
        private string roofType;
        public string RoofType
        {
            get
            {
                return roofType;
            }
            set
            {
                switch (Type)
                {
                    //Set roof type if Type is Coupe
                    case "Coupe":
                        {
                            string defaultRoof = "Hard";

                            if (value != defaultRoof)
                            {
                                roofType = defaultRoof;
                            }
                            else
                            {
                                roofType = value;
                            }

                            break;
                        }
                    //Set roof type if Type is Sedan
                    case "Sedan":
                        {
                            string defaultRoof = "Hard";

                            if (value != defaultRoof)
                            {
                                roofType = defaultRoof;
                            }
                            else
                            {
                                roofType = value;
                            }

                            break;
                        }
                    //Set roof type if Type is Van
                    case "Van":
                        {
                            string defaultRoof = "Hard";

                            if (value != defaultRoof)
                            {
                                roofType = defaultRoof;
                            }
                            else
                            {
                                roofType = value;
                            }

                            break;
                        }
                    //Set roof type if Type is Convertible
                    case "Convertible":
                        {
                            string contractRoof = "Contractible";
                            string removeRoof = "Removable";

                            if (value == contractRoof || value == removeRoof)
                            {
                                roofType = value;
                            }
                            else if (value != contractRoof || value != removeRoof)
                            {
                                roofType = contractRoof;
                            }

                            break;
                        }
                    //Set roof type if Type is Truck
                    case "Truck":
                        {
                            string defaultRoof = "Hard";

                            if (value != defaultRoof)
                            {
                                roofType = defaultRoof;
                            }
                            else
                            {
                                roofType = value;
                            }

                            break;
                        }
                }
            }
        }

        //Method for getting and setting BedLength
        private double? bedLength;
        public double? BedLength
        {
            get
            {
                return bedLength;
            }
            set
            {
                switch (Type)
                {
                    //Set bed length if Type is Coupe
                    case "Coupe":
                        {
                            double? defaultBed = null;

                            if (value != defaultBed)
                            {
                                bedLength = defaultBed;
                            }
                            else
                            {
                                value = defaultBed;
                            }

                            break;
                        }
                    //Set bed length if Type is Sedan
                    case "Sedan":
                        {
                            double? defaultBed = null;

                            if (value != defaultBed)
                            {
                                bedLength = defaultBed;
                            }
                            else
                            {
                                bedLength = value;
                            }

                            break;
                        }
                    //Set bed length if Type is Van
                    case "Van":
                        {
                            double? defaultBed = null;

                            if (value != defaultBed)
                            {
                                bedLength = defaultBed;
                            }
                            else
                            {
                                bedLength = value;
                            }

                            break;
                        }
                    //Set bed length if Type is Convertible
                    case "Convertible":
                        {
                            double? defaultBed = null;

                            if (value != defaultBed)
                            {
                                bedLength = defaultBed;
                            }
                            else
                            {
                                bedLength = value;
                            }

                            break;
                        }
                    //Set bed length if Type is Truck
                    case "Truck":
                        {
                            double? minBed = 6;
                            double? maxBed = 8;

                            if (value == null)
                            {
                                bedLength = minBed;
                            }
                            else if (value < minBed)
                            {
                                bedLength = minBed;
                            }
                            else if (value > maxBed)
                            {
                                bedLength = maxBed;
                            } 
                            else
                            {
                                bedLength = value;
                            }

                            break;
                        }
                }
            }
        }

        //Method for getting and setting Cost
        public decimal Cost { get; set; }
    }
}
