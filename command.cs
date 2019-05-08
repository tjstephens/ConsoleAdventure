namespace ConsoleAdventure 
{
    public class Command 
    {
        public string Action { get; private set; }
        public string Item { get; private set; }

        public Command(string input) 
        {
            var command = input.Split();

            Action = command[0];

            if (command.Length > 1)
                Item = command[1];
        }
    }
}