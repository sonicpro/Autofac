using System;
using System.Collections.Generic;

namespace FolderLister.PublicInterfaces
{
    interface IProcessor
    {
        IList<string> ShowContents();
    }
}
