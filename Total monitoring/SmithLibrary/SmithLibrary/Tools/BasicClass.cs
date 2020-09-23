using System;
using System.Collections.Generic;
using System.Text;

namespace SmithLibrary.Tools
{
    public static class BasicClass
    {
        public static string Root
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }
    }
}
