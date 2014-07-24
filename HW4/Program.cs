using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using HW3;
using System.IO;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            JobDistributor NewWorkers = new JobDistributor();
               NewWorkers.AddWorkers();
               NewWorkers.SortedDictionary();
               NewWorkers.SaveToXML();
               NewWorkers.LoadXML();

        }                    
  

    }

   
}
