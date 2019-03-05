using System;
using System.Collections.Generic;
using System.Text;

namespace commandpattern2
{
    public interface IExecute
    {
        string GetCommand();
        void Execute();
    }
}
