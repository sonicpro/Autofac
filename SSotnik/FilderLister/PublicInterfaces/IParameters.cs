using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilderLister.PublicInterfaces
{
    // Sets Processor so that its "ShowContents" handler directed to the correct folder.
    interface IParameters
    {
        string GetPath();
    }
}
