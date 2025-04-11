using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    // Interface inherit multiple interfaces but, can't inherit class
    //Interface can't have method with a body
    //Using Override keyword
    // Can't declare Constructor and destructor 
    interface i1
    {
        void print1();
    }
    interface i2 
    {
        void print2();
    }
    interface i3 : i1, i2
    {
        void print3();
    }
    public class InterfaceProgram : i3
    {
        public void print1()
        {
            Console.WriteLine("Interface 1");
        }
        public void print2()
        {
            Console.WriteLine("Interface 2");
        }
        public void print3()
        {
            Console.WriteLine("Interface 3");
        }

        public static void IFace(string[] args)
        {
            InterfaceProgram If = new InterfaceProgram();
            Console.WriteLine("Create Class Object");
            If.print1();
            If.print2();
            If.print3();

            i3 myinterface = new InterfaceProgram();
            Console.WriteLine("Interface i3");
            myinterface.print1();
            myinterface.print2();
            myinterface.print3();
            Console.ReadLine();
        }
    }
}
