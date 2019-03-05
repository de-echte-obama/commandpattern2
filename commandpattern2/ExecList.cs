using System;
using System.Collections.Generic;
using System.Text;

namespace commandpattern2
{
    class ExecList
    {
        void ExecCmd(string req)
        {
            Invoker inv = new Invoker();
            IExecute objExecute = inv.GetCommand(req);
            objExecute.Execute();
        }

        public void Open()
        {
            ExecCmd("Open");
        }
    }
}
