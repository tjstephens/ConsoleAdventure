using System.Collections.Generic;

namespace ConsoleAdventure 
{
    public class World 
    {
        public List<Room> Rooms { get; private set; }

        public World() 
        {

        }

        public bool Load(List<Room> rooms) 
        {
            var success = false;

            Rooms = rooms;

            success = true;
            
            return success;
        }
    }
}