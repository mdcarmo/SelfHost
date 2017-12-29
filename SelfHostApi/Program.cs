using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostApi
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:9999"))
            {
                Console.WriteLine("Meu primeiro server host rodando!");

                Console.ReadLine();
            }
        }
    }
}
