using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Depths
{
    public partial class MainForm : Form
    {
        GameItemCollection itemsCollection = new GameItemCollection();

        Player player = new Player()
        {

            Strength = 5,
            Speed = 5,
            Agility = 5,
            Endurance = 5,
            Intelligence = 5,
            Willpower = 5,
            Personality = 5,

            PlayerWeapon = new Weapon()
            {

                Name = "Fists",
                Description = "Your bare hands",
                WeaponDamage = 1

            },
            PlayerArmor = new Armor()
            {
                ArmorStrength = 1,
                ArmorType = "No Armor",
                Name = "Not Equiped"

            },

            Inventory = new List<Items>()
            {
                new Items() { Name = "Stick"},
                new Items() { Name = "Rock"}
            },

            Gold = 0,

            Level = 1,

            PlayerLocation = new Locations()

        };
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayerHealthLbl.Text = player.HP.ToString();
            PlayerDefenceLbl.Text = player.Defence.ToString();
            PlayerAttackLbl.Text = player.Attack.ToString();
            PlayerEnergyLbl.Text = player.Energy.ToString();
            PlayerMentalPowerLbl.Text = player.MentalPower.ToString();
            ArmorNameLbl.Text = player.PlayerArmor.Name;
            ArmorRatingLbl.Text = player.PlayerArmor.ArmorStrength.ToString();
            WeaponDamageLbl.Text = player.PlayerWeapon.WeaponDamage.ToString();
            WeaponNameLbl.Text = player.PlayerWeapon.Name;
            PlayerLevelLbl.Text = player.Level.ToString();
            PlayerGoldLbl.Text = player.Gold.ToString();

            foreach (Items item in player.Inventory)
            {
                PlayerInventoryBox.Items.Add(item.Name);
                
            }
        }

        //Player Basic Stats
        private void PlayerMentalPowerLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlayerEnergyLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlayerLevelLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlayerAttackLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlayerDefenceLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlayerHealthLbl_Click(object sender, EventArgs e)
        {

        }

        //Player Equipment Stats
        private void ArmorNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void ArmorRatingLbl_Click(object sender, EventArgs e)
        {

        }

        private void WeaponDamageLbl_Click(object sender, EventArgs e)
        {

        }

        private void WeaponNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlayerGoldLbl_Click(object sender, EventArgs e)
        {

        }

        //Player Inventory
        private void PlayerInventoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        //Event Display Box
         private void EventDisplayBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Player Action Buttons

        private void SearchBtn_Click(object sender, EventArgs e)
        {
           
      
            player.Search(player);


            
        }
    }
}
