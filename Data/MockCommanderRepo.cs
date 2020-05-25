using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kitchen"},
                new Command{Id=1, HowTo="Add Ketchup", Line="Ketchup x10", Platform="Kitchen"},
                new Command{Id=2, HowTo="Eat", Line="Fill mouth", Platform="Human"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kitchen"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}