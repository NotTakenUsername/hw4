using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW3
{
    class Person
    {
        public string Name {get; set;}
        public DateTime birthDate{get; set;}
        private int age {get; set;}
        
        public Person()
        {
            Name = "Untitled";
            birthDate = DateTime.Now;
        }
         public int Age()
        {
            int age = Convert.ToInt32((DateTime.Today - birthDate).TotalDays / 365);
            if (DateTime.Now.Month < birthDate.Month ||
                (DateTime.Now.Month == birthDate.Month && 
                  DateTime.Now.Day < birthDate.Day))
            {
                age--;
            }
            return age;
        }
    
       
        }

    }

