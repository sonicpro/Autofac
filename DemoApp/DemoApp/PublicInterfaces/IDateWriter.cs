using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.PublicInterfaces
{
    /// <summary>
    ///  This interface decouples the notion of writing
    ///  a date from the actual mechanism that performs
    ///  the writing. Like with IOutput, the process
    ///  is abstracted behind an interface.
    /// </summary>
    interface IDateWriter
    {
        void WriteDate();
    }
}
