using System;
using System.Collections.Generic;
using System.Text;

namespace commandpattern2
{
    class SaveFile : IExecute
    {
        public string GetCommand()
        {
            return "Save";
        }

        public void Execute()
        {
            Console.WriteLine("file saved");
        }
    }
}
