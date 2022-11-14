using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.Core
{
    public static class Session
    {
        public static bool CanSave { get; set; }
        public static bool CanGetAll { get; set; }
    }
}
