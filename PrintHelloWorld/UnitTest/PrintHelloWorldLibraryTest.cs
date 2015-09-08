using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintHelloWorld.Library;

namespace UnitTest
{
    [TestClass]
    public class PrintHelloWorldLibraryTest
    {
        [TestMethod]
        public void ConsoleMessagePrinter_ValidateOutput()
        {
            //Arrange
            var HelloWorld = new ConsoleMessagePrinter();
            //Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.PrintMessage();

                string expected = "Hello World";
                //Assert
                Assert.AreEqual<string>(expected, sw.ToString());
            }
            
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void WebMessagePrinter_NotImplemented()
        {
            var HelloWorld = new WebMessagePrinter();
            HelloWorld.PrintMessage();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void WindowsServicesMessagePrinter_NotImplemented()
        {
            var HelloWorld = new WindowsServicesMessagePrinter();
            HelloWorld.PrintMessage();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void DatabaseWriter_NotImplemented()
        {
            var HelloWorld = new DatabaseWriter();
            HelloWorld.Write();
        }

        [TestMethod]
        public void MessagePrinterFactory_CreateConsoleMessagePrinter()
        {
            //arrange
            var HelloWorld = new MessagePrinterFactory();
            var controlled = new WindowsServicesMessagePrinter();
            //act
            var printer = HelloWorld.CreateMessagePrinter(MessageRecipientClientType.CONSOLE);
            //assert
            Assert.AreEqual(controlled, printer);
        }

        [TestMethod]
        public void MessagePrinterFactory_CreateMobileMessagePrinter()
        {
            //arrange
            var HelloWorld = new MessagePrinterFactory();
            var controlled = new WindowsServicesMessagePrinter();
            //act
            var printer = HelloWorld.CreateMessagePrinter(MessageRecipientClientType.MOBILE);
            //assert
            Assert.AreEqual(controlled, printer);
        }

        [TestMethod]
        public void MessagePrinterFactory_CreateWebMessagePrinter()
        {
            //arrange
            var HelloWorld = new MessagePrinterFactory();
            var controlled = new WindowsServicesMessagePrinter();
            //act
            var printer = HelloWorld.CreateMessagePrinter(MessageRecipientClientType.WEB);
            //assert
            Assert.AreEqual(controlled, printer);
        }

        [TestMethod]
        public void MessagePrinterFactory_CreateWindowsServicesMessagePrinter()
        {
            //arrange
            var HelloWorld = new MessagePrinterFactory();
            var controlled = new WindowsServicesMessagePrinter();
            //act
            var printer = HelloWorld.CreateMessagePrinter(MessageRecipientClientType.WINDOWS_SERVICES);
            //assert
            Assert.AreEqual(controlled, printer);
        }

        [TestMethod]
        public void MessageWriterFactory_CreateDatabaseWriter()
        {
            //arrange
            var HelloWorld = new MessageWriterFactory();
            var controlled = new DatabaseWriter();
            //act
            var writer = HelloWorld.CreateMessageWriter(ClientStoreType.DATABASE);
            //assert
            Assert.AreEqual(controlled, writer); 
        }


    }
}
