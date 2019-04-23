using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLRSharp
{
    public class InvokeClass
    {
        public static int TestMethod(string TestParam)
        {
            MessageBox.Show("C# DLL Injected Successfully With CLR Hosting!");
            return 0;
        }
    }
}
