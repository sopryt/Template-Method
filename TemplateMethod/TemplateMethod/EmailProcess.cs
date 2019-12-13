using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class EmailProcess
    {
        public void ProcessEmail()
        {
            OpenEmail();
            ReadText();
            WorkWithFile();
            ComposeAnswer();
            SendAnswer();
        }

        public void OpenEmail()
        {
            Console.WriteLine("The Email has been opened.");
        }

        public void ReadText()
        {
            Console.WriteLine("The text has been read.");
        }

        public abstract void WorkWithFile();

        public void ComposeAnswer()
        {
            Console.WriteLine("The answer has been composed.");
        }

        public void SendAnswer()
        {
            Console.WriteLine("The answer has been sent.");
        }
    }
}
