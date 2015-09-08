using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintHelloWorld.Library
{
    public class ConsoleMessagePrinter : Message, IMessagePrinter
    {


        public void PrintMessage()
        {
            Console.WriteLine(msg);
        }
    }
}
