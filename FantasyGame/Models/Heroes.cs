using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame.Models
{
    public class Heroes
    {
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Phylo { get; set; }
        public string Weapon { get; set; }
        public int AttackPower { get; set; }

        public void SetCharacters(string characterType)
        {

            switch (characterType)
            {
                case "Wizard":
                    Name = "Gandalf";
                    Branch = "Wizard";
                    Phylo = "Human";
                    Weapon = "Magic Wand"; break;
                case "Dwarf":
                    Name = "Thorin";
                    Branch = "Warrior";
                    Phylo = "Dwarf";
                    Weapon = "Broad Axe"; break;
                case "Elf":
                    Name = "Legolas";
                    Branch = "Archer";
                    Phylo = "Elf";
                    Weapon = "Bow and Arrow"; break;
            }

        }

        public void Attack()
        {
            switch (Branch)
            {
                case "Wizard": AttackPower = 50; break;
                case "Warrior": AttackPower = 30; break;
                case "Archer": AttackPower = 10; break;
                default: AttackPower = 5; break;
            }
        }
    }
}
