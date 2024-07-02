using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;


namespace Csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Type t = typeof(Program);

            MemberInfo[] members = t.GetMembers();
            foreach (MemberInfo member in members)
            {
                Debug.WriteLine("Member = " + members);
            }
        }
    }
}
