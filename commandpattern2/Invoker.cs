using System;
using System.Collections.Generic;
using System.Text;

namespace commandpattern2
{
    class Invoker
    {
        List<IExecute> cmdList = new List<IExecute>();

        public Invoker()
        {
            cmdList.Add(new SaveFile());
            cmdList.Add(new OpenFile());
        }
        
        public IExecute GetCommand(string strCommand)
        {
            foreach (IExecute element in cmdList)
            {
                if (strCommand == element.GetCommand())
                {
                    return element;
                }
            }
            return null;
        }
    }
}
