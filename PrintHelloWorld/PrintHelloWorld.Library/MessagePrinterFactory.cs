using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintHelloWorld.Library
{
    public class MessagePrinterFactory
    {
        public virtual IMessagePrinter CreateMessagePrinter(MessageRecipientClientType type)
        {
            IMessagePrinter printer = null;
            switch (type)
            {
                case MessageRecipientClientType.CONSOLE:
                    printer = new ConsoleMessagePrinter();
                    break;
                case MessageRecipientClientType.MOBILE:
                    printer = new MobileMessagePrinter();
                    break;
                case MessageRecipientClientType.WEB:
                    printer = new WebMessagePrinter();
                    break;
                case MessageRecipientClientType.WINDOWS_SERVICES:
                    printer = new WindowsServicesMessagePrinter();
                    break;
                default:
                    throw new NotImplementedException("The MessageRecipientClientType does not exist. Please Implement in API");
            }

            return printer;
        }
    }
}
