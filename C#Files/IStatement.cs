using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBank
{
    internal interface IStatement
    {
        void Post();
        string GetStatement();
        string Prompt { get; }

    }
}
