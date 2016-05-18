using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.PublicInterfaces;

namespace DemoApp
{
    /// <summary>
    /// This implementation of the IOutput interface
    /// is actually how we write to the Console. Technically
    /// we could also implement IOutput to write to Debug
    /// or Trace... or anywhere else.
    /// </summary>
    class ConsoleOutput : IOutput
    {
#region Implementaion
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
#endregion
    }
}
