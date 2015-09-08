using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintHelloWorld.Library
{
    public class MessageWriterFactory
    {
        public virtual IMessageWriter CreateMessageWriter(ClientStoreType type)
        {
            IMessageWriter writer = null;
            switch (type)
            {
                case ClientStoreType.DATABASE:
                    writer = new DatabaseWriter();
                    break;
                default:
                    throw new NotImplementedException("The ClientStoreType does not exist. Please Implement in API");
            }
            return writer;
        }
    }
}
