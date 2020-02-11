using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID___Dependency_Inversion_Principle
{
    public interface IDataInput
    {
      
        public bool Exited { get; set; }

        public abstract Command PromptCommand();
        public abstract string Prompt();
        public abstract void ExecuteCommand(Command command);


    }
}
