using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class Worker : Person, IWorker, IComparable<Worker>
    {
        public float baseSalary { get; set; }
        public string work { get; set; }
        public string Profile { get; set; }
        private int completedWork;

        public int DoSomething(string work)
        {
            if (work.Length > 0)
                completedWork++;
            return completedWork;
        }

        public float CalculateSalary(int counter)
        {
            float salary;
            salary = completedWork * baseSalary;
            return salary;
        }

        public Worker()
        {
            Name = "Undefined";
            this.birthDate = new DateTime(14, 11, 1988);
            baseSalary = 350;
            completedWork = 0;
            work = "";
        }

        public Worker(string name, DateTime birthDate, float baseSalary, string profile)
        {
            this.Name = name;
            this.birthDate = birthDate;
            this.work = "play tekken with buddy";
            this.baseSalary = baseSalary;
            this.Profile = profile;
        }
        public void Reset()
        {
            this.completedWork = 0;
        }

        public int CompareTo(Worker other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return this.Name.CompareTo(other.Name);
            }
        }
           /* public string Profile(string value)
            {
                this.profile = value;
                return profile;
            }*/
        
    }

}