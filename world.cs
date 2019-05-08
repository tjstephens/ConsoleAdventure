using System.Collections.Generic;

namespace ConsoleAdventure 
{
    public class World 
    {
        private int[,] map = new int[,] 
        {
            {1,1,1},
            {1,1,1},
            {1,1,1}
        };

        public List<Room> Rooms { get; private set; }

        public World() 
        {
            for(var x = 0; x <= map.GetUpperBound(0); x++) 
            {
                for(var y = 0; y <= map.GetUpperBound(1); y++)
                {
                    var room = new Room();
                    Rooms.Add(room);
                }
            }

        }

        public bool Load(List<Room> rooms) 
        {
            var success = false;

            Rooms = rooms;

            success = true;

            return success;
        }

        public Room Move(Room room, Direction direction)
        {
            Room nextRoom = null;
            var nextRoomId = room.GetNextRoomId(direction);

            if (nextRoom != null)
            {
                // Get room by ID.
            }

            return nextRoom;
        }
    }
}