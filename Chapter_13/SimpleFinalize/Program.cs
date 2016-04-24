﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFinalize
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine("***** Fun with Finalizers *****\n");
            Console.WriteLine("Hit the return key to shut down this app");
            Console.WriteLine("and force the GC to invoke Finalize()");
            Console.WriteLine("for finalizable objects created in this AppDomain.");
            
            tmp1();
            GC.Collect();
            tmp1();
            
            Console.ReadLine();
           
        }

        static void tmp1()
        {
            MyResourceWrapper rw = new MyResourceWrapper();
        }
    }
}