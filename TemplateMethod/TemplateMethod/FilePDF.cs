﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class FilePDF : EmailProcess
    {
        public override void WorkWithFile()
        {
            Console.WriteLine("The file has been opened with Adobe Reader.");
        }
    }
}
