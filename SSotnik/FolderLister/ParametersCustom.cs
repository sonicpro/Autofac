using System;
using FolderLister.PublicInterfaces;

namespace FolderLister
{
    // This IParameters implementation gets the reqired folder name in a constructor.
    class ParametersCustom : IParameters
    {
        private string _customPath;

        public ParametersCustom(string customPath)
        {
            _customPath = customPath;
        }

        public string GetPath()
        {
            return _customPath;
        }
    }
}
