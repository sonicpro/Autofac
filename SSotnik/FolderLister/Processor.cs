using System;
using System.Collections.Generic;
using System.IO;
using FolderLister.PublicInterfaces;

namespace FolderLister
{
    public class Processor : IProcessor
    {
        IParameters _parameters;

        #region Constructors

        public Processor(IParameters parameters)
        {
            _parameters = parameters;
        }

        #endregion

        #region Implementation

        public IList<string> ShowContents()
        {
            return Directory.GetFiles(_parameters.GetPath());
        }

        #endregion
    }
}
