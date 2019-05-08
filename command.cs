namespace ConsoleAdventure 
{
    public class Command 
    {
        public string Action { get; private set; }
        public string Item { get; private set; }
        public Direction Direction { get; private set; }

        public Command(string input) 
        {
            var command = input.Split();

            Action = command[0];

            if (command.Length > 1)
            {
                if (System.Enum.TryParse(typeof(Direction), command[1], true, out var direction))
                    Direction = (Direction) direction;
                else
                    Item = command[1];
            }
        }
    }
}