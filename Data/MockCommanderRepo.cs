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
                new Command{Id=0, HowTo="Boil an egg", Line="Boil watter", Platform="Kettle and pan"},
                new Command{Id=1, HowTo="Cut bread", Line="Get a knife", Platform="knife"},
                new Command{Id=2, HowTo="Make a cup of tea", Line="Boil a tea bag", Platform="Tea and a cup"},
            };
            
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil watter", Platform="Kettle and pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}