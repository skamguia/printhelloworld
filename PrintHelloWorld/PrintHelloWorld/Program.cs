using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Diagnostics;
using System.Configuration;
using PrintHelloWorld.Library;
/*
** Exercise **
Write a ‘Hello World’ program
1.The program has 1 current business requirement – write “Hello World” to the 
console/screen.
2.The program should have an API that is separated from the program logic to 
eventually support mobile applications, web applications, 
console applications or windows services.
3.The program should support future enhancements for writing to a database, 
console application, etc.
a.Use common design patterns (inheritance, e.g.) to account for these future concerns.
b.Use configuration files or another industry standard mechanism 
for determining where to write the information to.
4.       Write unit tests to support the API.
*****

*/
namespace PrintHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var HelloWorld = new ConsoleMessagePrinter();
            HelloWorld.PrintMessage();
            Console.ReadLine();
        }
    }

    


}
