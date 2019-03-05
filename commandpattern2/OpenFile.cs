using System;
using System.Collections.Generic;
using System.Text;

namespace commandpattern2
{
    class OpenFile : IExecute
    {
        public string GetCommand()
        {
            return "Open";
        }

        public void Execute()
        {
            Console.WriteLine("file opened");
        }
    }
}
