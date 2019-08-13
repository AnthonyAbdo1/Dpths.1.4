using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depths
{
    public class Player
    {

        //Basic Stats
        private int _hp;
        private int _energy;
        private int _mentalPower;
        private int _defence;
        private int _attack;
        public int Level { get; set; }

        //Advanced Stats
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Endurance { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Willpower { get; set; }
        public int Personality { get; set; }

        //Equipment Stats 

        public Weapon PlayerWeapon { get; set; }
        public Armor PlayerArmor { get; set; }

        // Inventory Stats
        public List<Items> Inventory { get; set; }
        public int Gold { get; set; }

        //Other Stats
        public Locations PlayerLocation { get; set; }

        //Initialized Stats
        public int HP
        {
            get { _hp = Endurance * Convert.ToInt16(1.1); return _hp; }
        }

        public int Energy
        {
            get { _energy = Endurance * Agility / Convert.ToInt16(1.1); return _energy; }
        }

        public int MentalPower
        {
            get { _mentalPower = Intelligence * Willpower / Convert.ToInt16(1.1); return _mentalPower; }
        }

        public int Defence
        {
            get { _defence = Endurance * Convert.ToInt16(1.1) + PlayerArmor.ArmorStrength; return _defence; }
        }

        public int Attack
        {
            get { _attack = Strength * Convert.ToInt16(1.1) + PlayerWeapon.WeaponDamage; return _attack; }
        }

        //Inventory and equipment actions
        public void AddToInventory(Player player, List<Items> items)
        {
            foreach (Items item in items) {
                player.Inventory.Add(item);
            }
        }

        public void EquipWeapon(Player player, Weapon weapon)
        {
            player.PlayerWeapon = weapon;
            player.Inventory.Remove(weapon);
        }

        //Search actions
        public void Search(Player player)
        {

            Random random = new Random();
            Locations location = new Locations();
            GameItemCollection gameItemCollection = new GameItemCollection();

            List<Locations> randomLocations = new List<Locations>()
            {
                new Cave(){Name = "Cave"},
                new Dungeon(){Name = "Dungeon"},
                new MonsterNest(){Name = "Monster Nest"},
                new Tower(){Name = "Tower"},
                new Town(){Name = "Town"},
                new Camp(){Name = "Camp"},
                new Locations(){Name ="Wilderness"}
            };

            var randomWeapon = new Random();
            randomWeapon.Next(0, 2);
            var lowLevelWeaponList = gameItemCollection.lowLevelWeapons.ToList();

            var randomNumber = random.Next(1, 100);

            if (randomNumber > 0 && randomNumber < 5)
            {
                var currentLocation = randomLocations.ElementAt(0);
                location.PopulateLocation(currentLocation);
                player.PlayerLocation = currentLocation;
                
            }

            else if (randomNumber > 5 && randomNumber < 10)
            {
                var currentLocation = randomLocations.ElementAt(1);
                location.PopulateLocation(currentLocation);
                player.PlayerLocation = currentLocation;
            }

            else if (randomNumber > 10 && randomNumber < 15)
            {
                var currentLocation = randomLocations.ElementAt(2);
                location.PopulateLocation(currentLocation);
                player.PlayerLocation = currentLocation;
            }

            else if (randomNumber > 15 && randomNumber < 20)
            {
                var currentLocation = randomLocations.ElementAt(3);
                location.PopulateLocation(currentLocation);
                player.PlayerLocation = currentLocation;
            }

            else if (randomNumber > 20 && randomNumber < 25)
            {
                Random randomMerchantGenerator = new Random();
                var merchGen = randomMerchantGenerator.Next(1, 10);

                if(merchGen > 0 && merchGen < 3)
                {
                    location.HasBlacksmith = true;
                    location.HasGeneralMerchant = true;
                    location.HasHerbalist = true;
                }

                var currentLocation = randomLocations.ElementAt(4);
                location.PopulateLocation(currentLocation);
                player.PlayerLocation = currentLocation;
            }

            else if (randomNumber > 25 && randomNumber < 30)
            {
                Random randomMerchantGenerator = new Random();
                var merchGen = randomMerchantGenerator.Next(1, 10);

                if (merchGen > 0 && merchGen < 3)
                {
                    location.HasTravelingMerchant = true;
                }

                var currentLocation = randomLocations.ElementAt(5);
                location.PopulateLocation(currentLocation);
                player.PlayerLocation = currentLocation;
            }

            else
            {
                var currentLocation = randomLocations.ElementAt(6);
                location.PopulateLocation(currentLocation);
                player.PlayerLocation = currentLocation;
               
            }

           
        }
    }
}
   