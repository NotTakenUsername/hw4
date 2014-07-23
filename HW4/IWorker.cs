using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    interface IWorker
    {
       int DoSomething(string work);
       float CalculateSalary(int counter);
    }
}
