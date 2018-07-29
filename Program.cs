using System;

namespace TokenGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length!= 3) {
                Console.WriteLine("Invalid Arguments");
                Console.WriteLine("Usage: tg <uri> <keyName> <key>");
                Console.WriteLine("i.e. tg  myNamespace.servicebus.windows.net/myEventHub RootManageSharedAccessKey myPrimaryKey");
                return;
            }
            var uri = args[0]; // uri
            var keyName = args[1]; // keyName
            var key = args[2]; //key
        
            var token = Token.Create(uri, keyName, key);
            Console.WriteLine(token);

        }
    }
}
