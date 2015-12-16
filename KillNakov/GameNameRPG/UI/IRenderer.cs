using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.UI
{
    public interface IRenderer
    {
        void WriteLine(string message, params object[] parameters);
        void Write(string message, params object[] parameters);
        void Clear();

    }
}
