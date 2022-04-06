using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Entities.Interface
{
    public class Phone : IWriteMessage
    {
        public void Write()
        {
            Console.WriteLine("Writing on a phone");
        }
    }
}
