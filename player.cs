using System.Collections.Generic;

namespace ConsoleAdventure 
{
    public class Player
    {
        public int Lives { get; private set; }

        public List<string> Inventory { get; private set; }

        public bool IsAlive { 
            get {
                return Lives > 0;
            }
        }

        public Player() {
            Lives = 3;
            Inventory = new List<string>();
        }

        public void Die() {
            Lives--;
        }

        public bool Take(string itemName) 
        {
            Inventory.Add(itemName);

            return true;
        }

        public void Drop(string itemName)
        {
            Inventory.Remove(itemName);
        }
    }
}