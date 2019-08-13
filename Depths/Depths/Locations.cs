using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depths
{
   
    public class Locations
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string TerrainType { get; set; }
        public int Rooms { get; set; }
        public int NumberOfContainers { get; set; }
        public bool IsIndoors { get; set; }
        public bool HasTravelingMerchant { get; set; }
        public bool HasBlacksmith { get; set; }
        public bool HasHerbalist { get; set; }
        public bool HasGeneralMerchant { get; set; }


        //Method for random generation of 
        public Locations PopulateLocation(Locations locations)
        {
            var location = locations;
            Random random = new Random();

            if (location.Name == "Cave")
            {
                Rooms = 1;
                Description = "A dark cave system";
                TerrainType = "Cave";
                IsIndoors = true;

                NumberOfContainers = random.Next(0, 10);
                
            }

            else if (location.Name =="Dungeon")
            {
                Rooms = random.Next(1, 10);
                Description = "An abandon prison from another age";
                TerrainType = "Dungeon";
                IsIndoors = true;

                NumberOfContainers = random.Next(0, 10);
            }

            else if (location.Name == "Monster Nest")
            {
                Rooms = random.Next(1, 5);
                Description = "A monster infested hole in the ground";
                TerrainType = "Monster Nest";
                IsIndoors = true;

                NumberOfContainers = random.Next(0, 3);
            }
            else if (location.Name =="Tower")
            {
                Rooms = random.Next(1, 10);
                Description = "A tall and ancient tower filled with danger";
                TerrainType = "Tower";
                IsIndoors = true;

                NumberOfContainers = random.Next(0, 10);
            }
            else if (location.Name =="Town")
            {
                Rooms = 1;
                Description = "A quant town filled with all sorts of people";
                TerrainType = "Town";
                IsIndoors = false;

                NumberOfContainers = random.Next(0, 10);
            }
            else if (location.Name =="Camp")
            {
                Rooms = 1;
                Description = "A small camp of merchants";
                TerrainType = "Camp";
                IsIndoors = false;

                NumberOfContainers = random.Next(0, 3);
            }

            else
            {
                Rooms = 0;
                Description = "The vast untamed wilderness";
                TerrainType = "Widerness";
                IsIndoors = false;
                NumberOfContainers = random.Next(0, 2);
            }

           
            return location;
        }

    }

    //Hostile

    public class Cave : Locations
    {

    }

    public class Tower:Locations
    {

    } 

    public class Dungeon:Locations
    {

    }

    public class MonsterNest:Locations
    {
       
    }

    //Friendly

    public class Town:Locations
    {
    
    }

    public class Camp:Locations
    {

    }
}
