﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW3;

namespace HW4
{
  public  class JobDistributor
    {
      List<Worker> Workers = new List<Worker>();
      Dictionary<string, List<Worker>> SortByProfiles = new Dictionary<string, List<Worker>>();

      public void AddWorkers()
      {         
          bool AddWorker = true;

          while (AddWorker)
          {

              string name;
              DateTime birthDate;
              float baseSalary;
              string profile;
              name = GetData.Name();
              birthDate = GetData.Date();
              baseSalary = GetData.Salary();
              profile = GetData.Profile();
              Worker CreateNew = new Worker(name, birthDate, baseSalary, profile);

              Workers.Add(CreateNew);

              //quit or continue option
              Console.WriteLine("Do u want to add user? Y/N:");
              ConsoleKeyInfo choise = Console.ReadKey();
              AddWorker = Decision.AddOrQuit(AddWorker, choise);
          }
      }
      public void SortedDictionary()
      {         
          //foreach (Worker w in Workers) //why argument exception is thrown? 
        //  {
              SortByProfiles.Add("QC", Workers.Where(temp => temp.Profile == "QC").ToList());
              SortByProfiles.Add("Dev", Workers.Where(temp => temp.Profile == "Dev").ToList());
              SortByProfiles.Add("PM", Workers.Where(temp => temp.Profile == "PM").ToList());
        //  }
      }

      public void SaveToXML()
      {
          Console.WriteLine("*** Saving data to XML ***");
          string filePath = GetData.filePath();
          // serialization      
          xmlProcessing<List<Worker>> xmlFile = new xmlProcessing<List<Worker>>(filePath);
          //add trycatch for save and load
          //try to save           
          xmlFile.Save(Workers);
          
          
      }

      public void LoadXML()
      {
          Console.WriteLine("*** Loading data from XML ***");
          string filePath = GetData.filePath();
          // serialization      
          xmlProcessing<List<Worker>> xmlFile = new xmlProcessing<List<Worker>>(filePath);
          //add trycatch for save and load     
                   //try to load existing file
          xmlFile.Load();
      }
    }
}
