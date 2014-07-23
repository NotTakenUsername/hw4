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
            List<Worker> Workers = new List<Worker>();
            bool AddWorker = true;            
           // Worker WorkerToAdd = new Worker();
            while (AddWorker)
            {

                string name;
                DateTime birthDate;
                float baseSalary;
                string profile ;
                name = GetData.Name();
                birthDate = GetData.Date();              
                baseSalary = GetData.Salary();
                profile = GetData.Profile();
                Worker CreateNew = new Worker(name,birthDate,baseSalary, profile);
               // Profiles.Add(CreateNew.Name, CreateNew.Profile(GetData.Profile()));
                Workers.Add(CreateNew);         
                          
                //quit or continue option
                Console.WriteLine("Do u want to add user? Y/N:");
                ConsoleKeyInfo choise = Console.ReadKey();
                AddWorker = Decision.AddOrQuit(AddWorker, choise);
            }
            //operations with dictionary
            Dictionary<string, List<Worker>> SortByProfiles = new Dictionary<string, List<Worker>>();
            foreach ( Worker w in Workers )
            {                 
                SortByProfiles.Add(w.Profile, Workers.Where() );
            }
            

            //try to create file
            string filePath;
            Console.WriteLine("*** Saving data to XML ***");
            Console.WriteLine("Specify filepath: ");
            filePath = Console.ReadLine();
            
            xmlProcessing<List<Worker>> xmlFile = new xmlProcessing<List<Worker>>(filePath);
            xmlFile.Save(Workers);
            //try to load existing file
            xmlFile.Load();
                                

        }                    
  

    }

   
}
