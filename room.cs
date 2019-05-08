using System.Collections.Generic;

namespace ConsoleAdventure 
{

    public class Room 
    {
        public int? NorthExit { get; private set; }
        public int? SouthExit { get; private set; }
        public int? EastExit { get; private set; }
        public int? WestExit { get; private set; }

        public List<string> Inventory { get; private set; }

        public Room() 
        {
            Inventory = new List<string>();
        }

        public Room(List<string> inventory) {
            Inventory = inventory;
        }

        public bool Contains(string itemName) 
        {
            return Inventory.Contains(itemName);
        }

        public void Remove(string itemName) 
        {
            if (Inventory.Contains(itemName))
            {
                Inventory.Remove(itemName);
            }
        }

        public bool Put(string itemName)
        {
            Inventory.Add(itemName);

            return true;
        }

        public int GetNextRoomId(Direction Direction)
        {
            
        }
    }
}