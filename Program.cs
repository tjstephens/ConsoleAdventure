using System;
using System.Collections.Generic;

namespace ConsoleAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var world = new World();
            
            var gameOver = false;
            var player = new Player();
            var currentRoom = new Room(new List<string>() { "box" });

            while(player.IsAlive && !gameOver) 
            {
                Console.Write("Command: ");
                var input = Console.ReadLine();
                var command = new Command(input);

                switch(command.Action) 
                {
                    case "inventory":
                        if (player.Inventory.Count > 0)
                        {
                            Console.WriteLine("You are carrying:");
                            foreach(var item in player.Inventory)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else 
                        {
                            Console.WriteLine("You aren't currently carrying anything.");
                        }
                        break;
                    case "get":
                    case "take":
                        if (currentRoom.Contains(command.Item))
                        {
                            var playerTookItem = player.Take(command.Item);
                            if (playerTookItem)
                            {
                                currentRoom.Remove(command.Item);
                                Console.WriteLine($"You picked up {command.Item}");
                            }
                            else
                            {
                                Console.WriteLine($"You cannot pick that up.");
                            }
                        }

                        break;
                    case "drop":
                        var itemCanGoHere = currentRoom.Put(command.Item);
                        if (itemCanGoHere) 
                        {
                            player.Drop(command.Item);
                            Console.WriteLine($"You dropped {command.Item}");
                        }
                        else 
                        {
                            Console.WriteLine($"That item cannot go here.");
                        }
                        break;
                    case "look":
                        if (currentRoom.Inventory.Count > 0) 
                        {
                            Console.WriteLine("In the room, you see:");
                            foreach(var item in currentRoom.Inventory)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else 
                        {
                            Console.WriteLine("You don't see anything.");
                        }
                        break;
                    case "die":
                        player.Die();
                        Console.WriteLine($"You have died. You have {player.Lives} lives left.");
                        break;
                    case "quit":
                        gameOver = true;
                        break;
                    case "move":
                    case "go":
                        currentRoom = world.Move(currentRoom, command.Direction);
                        break;
                    default:
                        Console.WriteLine("I don't understand.");
                        break;
                }
            }

            Console.WriteLine("Game over.");
        }
    }
}
