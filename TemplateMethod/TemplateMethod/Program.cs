using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailProcess email = new FileWord();
            email.ProcessEmail();
            Console.WriteLine();

            email = new FilePDF();
            email.ProcessEmail();
            Console.WriteLine();

            email = new FileJPG();
            email.ProcessEmail();
            Console.WriteLine();

            email = new FileARJ();
            email.ProcessEmail();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
