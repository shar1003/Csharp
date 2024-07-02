using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;


namespace Sampleproject
{
    public class Program
    {
        public static void Reflection(string[] args)
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