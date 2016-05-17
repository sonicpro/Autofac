using System;
using System.IO;
using System.Reflection;
using FolderLister.PublicInterfaces;

namespace FolderLister
{
    class ParametersLocal : IParameters
    {
        // Returns the executing assembly location.
        public string GetPath()
        {
            string exeName = new Uri(Assembly.GetExecutingAssembly().Location).LocalPath;
            return Path.GetDirectoryName(exeName);
        }
    }
}
