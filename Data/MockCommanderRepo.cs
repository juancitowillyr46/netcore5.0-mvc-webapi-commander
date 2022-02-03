using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Hello", Line= "Line", Platform="Windiws"},
                new Command{Id=0, HowTo="Hello", Line= "Line", Platform="Windiws"},
                new Command{Id=0, HowTo="Hello", Line= "Line", Platform="Windiws"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Hello", Line= "Line", Platform="Windiws"};
        }
    }
}