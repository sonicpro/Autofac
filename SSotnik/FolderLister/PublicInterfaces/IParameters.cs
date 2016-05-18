﻿using System;

namespace FolderLister.PublicInterfaces
{
    // Sets Processor so that its "ShowContents" handler directed to the correct folder.
    public interface IParameters
    {
        string GetPath();
    }
}
