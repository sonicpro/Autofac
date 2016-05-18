using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.PublicInterfaces
{
    // This interface helps decouple the concept of
    // "writing output" from the Console class.
    // We don't really "care" how to Write operation
    // happens, just that we can write.
    interface IOutput
    {
        void Write(string content);
    }
}
