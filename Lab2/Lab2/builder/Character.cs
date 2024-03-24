using System.Collections.Generic;

namespace Builder
{
    public class Character
    {
        private string name;
        private string physique;
        public List<string> inventory;

        public Character()
        {
            this.inventory = new List<string>();
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetPhysique()
        {
            return physique;
        }

        public void SetPhysique(string physique)
        {
            this.physique = physique;
        }

        public List<string> GetInventory()
        {
            return inventory;
        }

        public void SetInventory(List<string> inventory)
        {
            this.inventory = inventory;
        }

        public void AddInventoryItem(string item)
        {
            this.inventory.Add(item);
        }
    }
}

